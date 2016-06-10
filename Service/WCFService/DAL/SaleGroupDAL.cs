using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.Entity;

namespace WCFService.DAL
{
    public class SaleGroupDAL
    {
        internal static System.Data.DataSet GetSaleGroups(Model.SaleGroup saleGroup)
        {
            //传递users的参数
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@name", saleGroup.groupName));

            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getGroups", paras.ToArray());
        }

        internal static Entity.SqlResult AddSaleGroup(Model.SaleGroup group)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", group.groupID));
            paras.Add(new SqlParameter("@name", group.groupName));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_addGroup", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult UpdateSaleGroup(Model.SaleGroup group)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", group.groupID));
            paras.Add(new SqlParameter("@name", group.groupName));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_updateGroup", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult DeleteSaleGroup(string groupId)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", groupId));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_deleteGroup", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }
    }
}