using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.Model;

namespace WCFService.DAL
{
    public class UserDAL
    {
        public static DataSet GetUser(User user)
        {
            //传递users的参数
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", user.userID));
            paras.Add(new SqlParameter("@name", user.userName));
            paras.Add(new SqlParameter("@gender", user.gender));
            paras.Add(new SqlParameter("@entryTimeStart", user.entryTimeStart));
            paras.Add(new SqlParameter("@entryTimeEnd", user.entryTimeEnd));

            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getUsers", paras.ToArray());
        }

        public static string[] GetUserPermissions(string userId)
        {
            List<string> permissions = new List<string>();
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", userId));
            SqlDataReader reader = SqlServerHelper.ExecuteReader(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getUserPermissions", paras.ToArray());
            while (reader.Read())
            {
                if (reader != null && reader[0] != null)
                    permissions.Add(reader[0].ToString());
            }

            return permissions.ToArray();
        }
    }
}