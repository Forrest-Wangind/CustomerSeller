using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.Entity;
using WCFService.Model;

namespace WCFService.DAL
{
    public class UserDAL
    {
        internal static DataSet GetUser(User user)
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

        internal static string[] GetUserPermissions(string userId)
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
            reader.Close();
            return permissions.ToArray();
        }

        internal static User GetSingleUser(string userId)
        {
            User user = new User();
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", userId));
            SqlDataReader reader = SqlServerHelper.ExecuteReader(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getSingleUser", paras.ToArray());
            while (reader.Read())
            {
                if (reader != null && reader.FieldCount > 0)
                {
                    user.userID = reader[0].ToString();
                    user.userName = reader[1].ToString();
                    user.password = reader[2].ToString();
                    user.gender = reader[3].ToString();
                    user.role = reader[4].ToString();
                    user.exten = reader[5].ToString();
                    user.entryTimeStart = DateTime.Parse(reader[6].ToString());
                    break;
                }
            }
            reader.Close();
            return user;
        }

        internal static SqlResult AddUser(User user)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", user.userID));
            paras.Add(new SqlParameter("@name", user.userName));
            paras.Add(new SqlParameter("@pass", user.password));
            paras.Add(new SqlParameter("@gender", user.gender));
            paras.Add(new SqlParameter("@role", user.role));
            paras.Add(new SqlParameter("@exten", user.exten));
            paras.Add(new SqlParameter("@entryTime", user.entryTimeStart));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_addUser", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult UpdateUser(User user)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", user.userID));
            paras.Add(new SqlParameter("@name", user.userName));
            paras.Add(new SqlParameter("@pass", user.password));
            paras.Add(new SqlParameter("@gender", user.gender));
            paras.Add(new SqlParameter("@exten", user.exten));
            paras.Add(new SqlParameter("@entryTime", user.entryTimeStart));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_updateUser", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static DataSet GetUserRoles(string userId)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", userId));
            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getUserRoles", paras.ToArray());
        }

        internal static SqlResult DeleteUser(string userId)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", userId));
            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_deleteUser", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }
    }
}