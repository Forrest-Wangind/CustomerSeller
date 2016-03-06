using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSeller.ServiceReference1;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CustomerSeller.Common
{
    public class CustomerInfo
    {
        private static Service1Client instance;
        internal static DataTable GetCustomerInfoTable()
        {
           
            DataTable dt = new DataTable();
            dt.TableName = "CustomerInfo";
            dt.Columns.AddRange(new DataColumn[]
            { 
                new DataColumn("CustomerGender",typeof(string)),
                new DataColumn("CustomerPhone",typeof(string)),
                new DataColumn("CustomerAddress",typeof(string)),
                new DataColumn("CustomerName",typeof(string))
            });

            return dt;
        }
        internal static Service1Client GetServiceInstance()
        {
            if (instance == null)
                instance = new Service1Client();
            return instance;
        }
        internal static DataSet ExcelToDataSet(string filename, string TSql)
        {
            DataSet ds;
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;data source=" + filename;
            OleDbConnection myConn = new OleDbConnection(strCon);
            string strCom = TSql;
            myConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            ds = new DataSet();
            myCommand.Fill(ds);
            myConn.Close();
            return ds;
        }
        internal static string GetExcelFirstTableName(string excelFileName)
        {
            string tableName = null;
            if (File.Exists(excelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + excelFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
        }

        //导入客户信息
        internal static void Run(object obj)
        {
            try
            {
                var file = Convert.ToString(obj);
                var sheet = GetExcelFirstTableName(file);
                var ds = ExcelToDataSet(file, string.Format("SELECT  * FROM [{0}]", sheet));
                var dataTable = GetCustomerInfoTable();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DataRow _dr = dataTable.NewRow();
                    _dr["CustomerGender"] = dr["CustomerGender"];
                    _dr["CustomerPhone"] = dr["CustomerPhone"];
                    _dr["CustomerAddress"] = dr["CustomerAddress"];
                    _dr["CustomerName"] = dr["CustomerName"];
                    dataTable.Rows.Add(_dr);
                }
                DataSet dsOfCustomerInfo = new DataSet();
                dsOfCustomerInfo.Tables.Add(dataTable);
                CustomerInfo.GetServiceInstance().BatchImportCustomerInfo(dsOfCustomerInfo);
                MessageBoxEx.Show("数据导入成功！", "提示");

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("系统繁忙，稍后再试", "提示");
            }

        }
    }
}
