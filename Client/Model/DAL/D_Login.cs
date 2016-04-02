using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLHelper;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace CustomerSeller.DAL
{

    static class ClassData
    {
        #region  参数
        public static string con_str = null;
        //sqlconnection对象
        public static SqlConnection con = new SqlConnection();
        //sqlcommand对象
        public static SqlCommand com = new SqlCommand();
        //DataTable对象
        public static DataTable dt = new DataTable();
        //SqlDataAdapter对象
        public static SqlDataAdapter sda = new SqlDataAdapter();
        //DataSet对象
        public static DataSet ds = new DataSet();
        #endregion



    }


    /// <summary>
    /// 登录信息
    /// </summary>
    class D_Login
    {

        //初始化连接字符串
        static D_Login()
        {
            try
            {

                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath +
                    "\\DataBase_Link.txt");
                ClassData.con_str = sr.ReadToEnd();
                sr.Close();
                ClassData.con.ConnectionString = ClassData.con_str;
                ClassData.con.Open();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        //登录
        public static Boolean _Login(string user_Id, string user_Pwd)

        {
            try
            {
                string execute_sql = "select * from user_info where [user_Id]='" + user_Id.Trim().ToString() + "'  and  user_Pwd='" +
                user_Pwd + "'";
                DataSet ds = SqlServerHelper.ExecuteDataset(ClassData.con, CommandType.Text, execute_sql);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    UserInfo.Get_User().User_Grade = ds.Tables[0].Rows[0]["user_Grade"].ToString();
                    UserInfo.Get_User().User_Pwd = ds.Tables[0].Rows[0]["user_Pwd"].ToString();
                    UserInfo.Get_User().User_Id = ds.Tables[0].Rows[0]["user_Id"].ToString();
                    UserInfo.Get_User().User_Exten = ds.Tables[0].Rows[0]["Exten"].ToString();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception Ex)
            {
                return false;
            }

        }


    }

    /// <summary>
    /// VIP信息的处理
    /// </summary>
    class D_Customer

    {

        /// <summary>
        /// 添加ViP编号
        /// </summary>
        /// <param name="vip_Id"></param>
        /// <param name="vip_name"></param>
        /// <param name="vip_IdentityCard"></param>
        /// <param name="vip_Tel"></param>
        /// <param name="vip_Credits"></param>
        /// <returns></returns>
        public static Boolean Add_Fruit(string buying_Price, string selling_Price, string remark, string pic_directory, string fruit_name)
        {

            try
            {
                string execute_sql = "insert into fruit_info values (" + buying_Price.Trim() + ",  " +
                selling_Price.Trim() + ",  '" + remark.Trim() + "',  '" + pic_directory + "','" + fruit_name + "')";
                SqlServerHelper.ExecuteNonQuery(ClassData.con, CommandType.Text, execute_sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }



        /// <summary>
        /// 查询Vip信息
        /// </summary>
        /// <param name="execute_sql"></param>
        /// <returns></returns>
        public static DataSet Query_Customer(string execute_sql)
        {

            try
            {
                var dataSet = SqlServerHelper.ExecuteDataset(ClassData.con, CommandType.Text, execute_sql);
                if (dataSet.Tables.Count > 0)
                    return dataSet;
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }




        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="execute_sql"></param>
        /// <returns></returns>
        public static Boolean Execute_Fruit(string execute_sql)
        {

            try
            {
                SqlServerHelper.ExecuteNonQuery(ClassData.con, CommandType.Text, execute_sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
                return false;
            }

        }

    }

}
