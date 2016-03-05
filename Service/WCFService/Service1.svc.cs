using SQLHelper;
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
                Parameters.ToList().ForEach(item =>
                {
                    condition += string.Format("and {0}'{1}' ", item.Key, item.Value);
                });
                var execute_sql = string.Format(Sql.customerTotalNumber, condition) + ";" + string.Format(Sql.customerInfoDetail, PageSize, CurrentPage, condition);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.Con, CommandType.Text, execute_sql);
                if (dataSet.Tables.Count > 0)
                    return dataSet;
                else
                    return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataSet GetCustomerDetail(string CustomerID)
        {
            try
            {
                var execute_sql = string.Format(Sql.CustomerInfo,CustomerID);
                var dataSet = SqlServerHelper.ExecuteDataset(SqlServerHelper.Con, CommandType.Text, execute_sql);
                return dataSet;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int UpdateCustomerDetail(string sql)
        {
            try
            {
                return SqlServerHelper.ExecuteNonQuery(SqlServerHelper.Con, CommandType.Text,sql);
            }
            catch(Exception ex)
            {
                return -1;
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
                LoggerWrapper.Instance().LogError("getUsers fail. " + ex.Message);
                return null;
            }
        }

        public User GetSingleUser(User user)
        {
            throw new NotImplementedException();
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
                LoggerWrapper.Instance().LogError("getUsers fail. " + ex.Message);
                return null;
            }
        }
    }
}
