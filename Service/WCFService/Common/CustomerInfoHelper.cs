using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WCFService.Common
{
    public class CustomerInfoHelper
    {
        internal static DataTable GetCustomerInfoTable()
        {
            DataTable dt = new DataTable();
            dt.TableName = "CustomerInfo";
            dt.Columns.AddRange(new DataColumn[]
            { 
                new DataColumn("CustomerID",typeof(System.Guid)),
                new DataColumn("CustomerGender",typeof(string)),
                new DataColumn("CustomerPhone",typeof(string)),
                new DataColumn("CustomerAddress",typeof(string)),
                new DataColumn("CreateTime",typeof(DateTime)),
                new DataColumn("CustomerName",typeof(string))
            });

            return dt;
        }

        //CustomerInfo表的匹配
        internal static void BuildSqlBulkOfCustomerInfo(SqlBulkCopy sqlbulk)
        {
            sqlbulk.ColumnMappings.Add("CustomerID", "CustomerID");
            sqlbulk.ColumnMappings.Add("CustomerGender", "CustomerGender");
            sqlbulk.ColumnMappings.Add("CustomerPhone", "CustomerPhone");
            sqlbulk.ColumnMappings.Add("CustomerAddress", "CustomerAddress");
            sqlbulk.ColumnMappings.Add("CreateTime", "CreateTime");
            sqlbulk.ColumnMappings.Add("CustomerName", "CustomerName");
        }
        internal static DataTable FillDataTable(DataSet ds)
        {
            try
            {

                DataTable customerInfoTable = GetCustomerInfoTable();
                customerInfoTable.TableName = "CustomerInfo";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow customerInfoRow = customerInfoTable.NewRow();
                    customerInfoRow["CustomerID"] = System.Guid.NewGuid();
                    customerInfoRow["CustomerGender"] = ds.Tables[0].Rows[i]["CustomerGender"];
                    customerInfoRow["CustomerPhone"] = ds.Tables[0].Rows[i]["CustomerPhone"]; ;
                    customerInfoRow["CustomerAddress"] = ds.Tables[0].Rows[i]["CustomerAddress"]; ; ;
                    customerInfoRow["CreateTime"] = System.DateTime.Now;
                    customerInfoRow["CustomerName"] = ds.Tables[0].Rows[i]["CustomerName"];
                    customerInfoTable.Rows.Add(customerInfoRow);
                }
                return customerInfoTable;
            }

            catch (Exception ex)
            {
                ds = null;
                throw ex;
            }
        }

        //import
        //批量更新数据库信息
        internal static void BatchWriteToDB(DataSet ds)
        {
          
            using (DbConnection con =SqlServerHelper.Con)
            {
                con.Open();
                DbTransaction tran = con.BeginTransaction();
                try
                {
                    SqlBulkCopy sqlbulk1 = new SqlBulkCopy((SqlConnection)con, SqlBulkCopyOptions.Default, (SqlTransaction)tran);
                    sqlbulk1.BatchSize = 100;
                    BuildSqlBulkOfCustomerInfo(sqlbulk1);
                    sqlbulk1.DestinationTableName = "CustomerInfo";
                    sqlbulk1.WriteToServer(ds.Tables["CustomerInfo"]);
                    sqlbulk1.Close();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}