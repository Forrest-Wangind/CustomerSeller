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
    public class RoleDAL
    {
        internal static DataSet GetRoles(Role role)
        {
            //传递users的参数
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", role.roleID));
            paras.Add(new SqlParameter("@name", role.roleName));
            paras.Add(new SqlParameter("@remark", role.roleRemark));

            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getRoles", paras.ToArray());

        }

        internal static Role GetRoleDetail(string roleId)
        {
            Role role = new Role();
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", roleId));
            SqlDataReader reader = SqlServerHelper.ExecuteReader(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getRoleDetail", paras.ToArray());
            while (reader.Read())
            {
                if (reader != null && reader.FieldCount > 0)
                {
                    role.roleID = reader[0].ToString();
                    role.roleName = reader[1].ToString();
                    role.roleRemark = reader[2].ToString();
                    break;
                }
            }
            reader.Close();
            return role;
        }

        internal static DataSet GetRoleFunctions(string roleId)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", roleId));
            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getRoleFunctions", paras.ToArray());
        }

        internal static SqlResult UpdateRole(Role role)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", role.roleID));
            paras.Add(new SqlParameter("@name", role.roleName));
            paras.Add(new SqlParameter("@remark", role.roleRemark));
            string functions = string.Empty;
            string split = ",";
            paras.Add(new SqlParameter("@split", split));
            foreach (string str in role.functions)
            {
                functions += str + split;
            }
            paras.Add(new SqlParameter("@functions", functions));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_updateRole", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult AddRole(Role role)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", role.roleID));
            paras.Add(new SqlParameter("@name", role.roleName));
            paras.Add(new SqlParameter("@remark", role.roleRemark));
            string functions = string.Empty;
            string split = ",";
            paras.Add(new SqlParameter("@split", split));
            foreach (string str in role.functions)
            {
                functions += str + split;
            }

            paras.Add(new SqlParameter("@functions", functions));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_addRole", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult DeleteRole(string roleId)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", roleId));
            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_deleteRole", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }
    }
} 