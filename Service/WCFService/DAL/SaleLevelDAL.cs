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
    public class SaleLevelDAL
    {
        internal static SqlResult AddLevel(SaleLevel level)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@name", level.levelName));
            paras.Add(new SqlParameter("@remark", level.levelRemark));
            paras.Add(new SqlParameter("@AMaxNumber", level.AMaxNumber));
            paras.Add(new SqlParameter("@ADailyNumber", level.ADailyNumber));
            paras.Add(new SqlParameter("@ARemark", level.ARemark));
            paras.Add(new SqlParameter("@BMaxNumber", level.BMaxNumber));
            paras.Add(new SqlParameter("@BDailyNumber", level.BDailyNumber));
            paras.Add(new SqlParameter("@BRemark", level.BRemark));
            paras.Add(new SqlParameter("@CMaxNumber", level.CMaxNumber));
            paras.Add(new SqlParameter("@CDailyNumber", level.CDailyNumber));
            paras.Add(new SqlParameter("@CRemark", level.CRemark));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_addLevel", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult UpdateSaleLevel(SaleLevel level)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", level.levelID));
            paras.Add(new SqlParameter("@name", level.levelName));
            paras.Add(new SqlParameter("@remark", level.levelRemark));
            paras.Add(new SqlParameter("@AMaxNumber", level.AMaxNumber));
            paras.Add(new SqlParameter("@ADailyNumber", level.ADailyNumber));
            paras.Add(new SqlParameter("@ARemark", level.ARemark));
            paras.Add(new SqlParameter("@BMaxNumber", level.BMaxNumber));
            paras.Add(new SqlParameter("@BDailyNumber", level.BDailyNumber));
            paras.Add(new SqlParameter("@BRemark", level.BRemark));
            paras.Add(new SqlParameter("@CMaxNumber", level.CMaxNumber));
            paras.Add(new SqlParameter("@CDailyNumber", level.CDailyNumber));
            paras.Add(new SqlParameter("@CRemark", level.CRemark));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_updateLevel", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static SqlResult DeleteSaleLevel(string levelId)
        {
            int flag = 0;
            string message = string.Empty;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", levelId));

            SqlParameter flagPara = new SqlParameter("@flag", flag);
            SqlParameter messagePara = new SqlParameter("@message", message);
            flagPara.Direction = ParameterDirection.Output;
            messagePara.Direction = ParameterDirection.Output;
            messagePara.SqlDbType = SqlDbType.VarChar;
            messagePara.Size = 100;
            paras.Add(flagPara);
            paras.Add(messagePara);

            SqlServerHelper.ExecuteNonQuery(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_deleteLevel", paras.ToArray());
            flag = Convert.ToInt16(flagPara.Value);
            message = Convert.ToString(messagePara.Value);
            SqlResult result = new SqlResult(Convert.ToInt16(flagPara.Value), Convert.ToString(messagePara.Value));
            return result;
        }

        internal static DataSet GetSaleLevels(SaleLevel saleLevel)
        {
            //传递users的参数
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@name", saleLevel.levelName));
            paras.Add(new SqlParameter("@isSample", saleLevel.isSample ? 1 : 0));

            return SqlServerHelper.ExecuteDataset(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getLevels", paras.ToArray());
        }

        internal static SaleLevel GetLevelDetail(string levelId)
        {
            SaleLevel level = new SaleLevel();
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", levelId));
            SqlDataReader reader = SqlServerHelper.ExecuteReader(SqlServerHelper.conString, CommandType.StoredProcedure, "pro_getLevelDetail", paras.ToArray());
            while (reader.Read())
            {
                if (reader != null && reader.FieldCount > 0)
                {
                    level.levelID = reader[0].ToString();
                    level.levelName = reader[1].ToString();
                    level.levelRemark = reader[2].ToString();
                    level.AMaxNumber = reader[3] != DBNull.Value ? (int)reader[3] : 0;
                    level.ADailyNumber = reader[4] != DBNull.Value ? (int)reader[4] : 0;
                    level.ARemark = reader[5].ToString();
                    level.BMaxNumber = reader[6] != DBNull.Value ? (int)reader[6] : 0;
                    level.BDailyNumber = reader[7] != DBNull.Value ? (int)reader[7] : 0;
                    level.BRemark = reader[8].ToString();
                    level.CMaxNumber = reader[9] != DBNull.Value ? (int)reader[9] : 0;
                    level.CDailyNumber = reader[10] != DBNull.Value ? (int)reader[10] : 0;
                    level.CRemark = reader[11].ToString();
                    break;
                }
            }
            reader.Close();
            return level;
        }
    }
}