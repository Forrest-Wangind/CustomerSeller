﻿using SQLHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.DAL;
using WCFService.Model;
using Common.Log;
using WCFService.Common;
using WCFService.Entity;

namespace WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {

        public DataSet GetCustomer(int PageSize, int CurrentPage, List<KeyValuePair<string, string>> Parameters)
        {
            try
            {
                var condition = string.Empty;
                DataSet result = null;
                Parameters.ToList().ForEach(item =>
                {
                    condition += string.Format("and {0}'{1}' ", item.Key, item.Value);
                });
                var execute_sql = string.Format(Sql.customerTotalNumber, condition) + ";" + string.Format(Sql.customerInfoDetail, PageSize, CurrentPage, condition);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.Text, execute_sql);
                if (dataSet.Tables.Count > 0)
                    result = dataSet;
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Method = "GetCustomer", Result = result == null ? "null" : "a object" });
                return result;

            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Method = "GetCustomer", Exception = ex.Message });
                return null;
            }

        }

        public DataSet GetCustomerDetail(string CustomerID)
        {
            try
            {
                var execute_sql = string.Format(Sql.CustomerInfo, CustomerID);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.Con, CommandType.Text, execute_sql);
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Request = "CustomerID:" + CustomerID, Method = "GetCustomerDetail", Result = dataSet == null ? "null" : "a object" });
                return dataSet;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Request = "CustomerID:" + CustomerID, Method = "GetCustomerDetail", Exception = ex.Message });
                return null;
            }
        }

        public int UpdateCustomerInfo(string CustomerAddress = "", string Remark = "", string PhoneStratus = "", DateTime? DealTime = null, string CustomerID = "", string MobilePhone = "", string CustomerName = "")
        {
            string setStr = string.Empty;
            try
            {
                string sql = string.Empty;
                setStr = string.IsNullOrEmpty(CustomerAddress) ? string.Empty : string.Format(" CustomerAddress='{0}' ,", CustomerAddress);
                setStr += string.IsNullOrEmpty(Remark) ? string.Empty : string.Format(" Remark='{0}' ,", CustomerAddress);
                setStr += string.IsNullOrEmpty(PhoneStratus) ? string.Empty : string.Format(" PhoneStratus='{0}' ,", PhoneStratus);
                setStr += DealTime == null ? string.Empty : string.Format(" DealTime='{0}' ,", DealTime.ToString());
                setStr += string.IsNullOrEmpty(MobilePhone) ? string.Empty : string.Format(" CustomerPhone='{0}' ,", MobilePhone.ToString());
                setStr += string.IsNullOrEmpty(CustomerName) ? string.Empty : string.Format(" CustomerName='{0}' ,", CustomerName.ToString());
                if (!string.IsNullOrEmpty(setStr))
                    sql = string.Format("update CustomerInfo set {0} where CustomerID='{1}'", setStr.TrimEnd(','), CustomerID);
                var result = SqlServerHelper.ExecuteNonQuery(SqlServerHelper.Con, CommandType.Text, sql);
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Request = setStr, Method = "UpdateCustomerInfo", Result = result.ToString() });
                return result;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Request = setStr, Method = "UpdateCustomerInfo", Exception = ex.Message });
                return -1;
            }

        }

        public Boolean BatchImportCustomerInfo(DataSet ds)
        {
            try
            {
                var dataTable = CustomerInfoHelper.FillDataTable(ds);
                var dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                FilterTheSamePhone(dataSet);
                CustomerInfoHelper.BatchWriteToDB(dataSet);
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Method = "BatchImportCustomerInfo", Result = true.ToString() });
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Method = "BatchImportCustomerInfo", Exception = ex.Message });
                return false;
            }

        }

        public int AllocateEmployeePhone(string UserID)
        {
            int result = 0;
            try
            {
                var execute_sql = string.Format(Sql.AllocateEmployeePhone, ConfigurationManager.AppSettings["MaxCount"], ConfigurationManager.AppSettings["DailyMaxCount"], UserID);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.Con, CommandType.Text, execute_sql);
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Request = "UserID:" + UserID, Method = "AllocateEmployeePhone", Result = dataSet.Tables[0].Rows[0][0].ToString() });
                return Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Request = "UserID:" + UserID, Method = "AllocateEmployeePhone", Exception = ex.Message });
                return result;
            }
        }

        public int RecycleCustomerPhone(string customerID, string employeeID)
        {
            int result = 0;
            try
            {
                var execute_sql = string.Format(Sql.RecycleCustomerPhone, customerID, employeeID);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.Con, CommandType.Text, execute_sql);
                LoggerWrapper.Instance().LogInfo(new LogInfo() { Request = "customerID:" + customerID + ",employeeID:" + employeeID, Method = "RecycleCustomerPhone", Result = dataSet.Tables[0].Rows[0][0].ToString() });
                return Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError(new LogInfo() { Request = "customerID:" + customerID + ",employeeID:" + employeeID, Method = "RecycleCustomerPhone", Exception = ex.Message });
                return result;
            }
        }
        public DataSet GetUsers(User user)
        {
            try
            {
                return UserDAL.GetUser(user);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("get users fail. " + ex.Message);
                return null;
            }
        }

        public User GetSingleUser(string userId)
        {
            try
            {
                return UserDAL.GetSingleUser(userId);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("get single user fail. " + ex.Message);
                return null;
            }
        }

        public int test(int a)
        {
            return ++a;
        }

        public string[] GetUserPermissions(string userId)
        {
            try
            {
                return UserDAL.GetUserPermissions(userId);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("get user permissions fail. " + ex.Message);
                return null;
            }
        }

        public void FilterTheSamePhone(DataSet ds)
        {
            //文件本身去重
            //保存电话
            List<string> phoneCollection = new List<string>();
            List<DataRow> dataRowCollection = new List<DataRow>();

            //数据库去重
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (phoneCollection.Contains(dr["CustomerPhone"].ToString()))
                    {
                        dataRowCollection.Add(dr);
                    }
                    else
                    {
                        phoneCollection.Add(dr["CustomerPhone"].ToString());
                    }
                }

            }
            dataRowCollection.ForEach(item => ds.Tables[0].Rows.Remove(item));
            //数据库去重
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataRowCollection.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //查询数据库
                    var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.Text, string.Format(Sql.JudgePhoneExists, dr["CustomerPhone"].ToString()));
                    if (dataSet.Tables[0].Rows[0][0].ToString().Equals("1"))
                        dataRowCollection.Add(dr);
                }
            }
            dataRowCollection.ForEach(item => ds.Tables[0].Rows.Remove(item));
        }

        public bool AddUser(User user)
        {
            try
            {
                SqlResult result = UserDAL.AddUser(user);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when add user. " + user);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when add user. " + ex.Message);
                return false;
            }
        }

        public bool AddRole(Role role)
        {
            try
            {
                SqlResult result = RoleDAL.AddRole(role);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when add role. " + role);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when add role. " + ex.Message);
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                SqlResult result = UserDAL.UpdateUser(user);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when update user. " + user);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when update user. " + ex.Message);
                return false;
            }
        }

        public bool UpdateRole(Role role)
        {
            try
            {
                SqlResult result = RoleDAL.UpdateRole(role);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when update role. " + role);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when update role. " + ex.Message);
                return false;
            }
        }

        public DataSet GetUserRoles(string userId)
        {
            try
            {
                DataSet roles = UserDAL.GetUserRoles(userId);
                return roles;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when get roles. " + ex.Message);
            }

            return null;
        }

        public DataSet GetRoles(Role role)
        {
            try
            {
                DataSet roles = RoleDAL.GetRoles(role);
                return roles;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when get roles. " + ex.Message);
            }

            return null;
        }

        public bool DeleteUser(string userId)
        {
            try
            {
                SqlResult result = UserDAL.DeleteUser(userId);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when delete user. " + userId);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when delete user. " + ex.Message);
                return false;
            }
        }

        public bool DeleteRole(string roleId)
        {
            try
            {
                SqlResult result = RoleDAL.DeleteRole(roleId);
                if (result.flag != FlagType.success)
                {
                    LoggerWrapper.Instance().LogError("fail when delete role. " + roleId);
                    LoggerWrapper.Instance().LogError(result.message);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("fail when delete role. " + ex.Message);
                return false;
            }
        }

        public DataSet GetPermissions(string userId)
        {
            throw new NotImplementedException();
        }

        public Role GetRoleDetail(string roleId)
        {
            try
            {
                return RoleDAL.GetRoleDetail(roleId);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("get single user fail. " + ex.Message);
                return null;
            }
        }

        public DataSet GetRoleFunctions(string roleId)
        {
            try
            {
                return RoleDAL.GetRoleFunctions(roleId);
            }
            catch (Exception ex)
            {
                LoggerWrapper.Instance().LogError("get user permissions fail. " + ex.Message);
                return null;
            }
        }
    }
}
