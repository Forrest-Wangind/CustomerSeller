using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CustomerSeller.DAL
{


    /// <summary>
    /// 用户信息
    /// </summary>
    class UserInfo
    {
        private static UserInfo user;//用户信息
        public  const string pwdKey = "12345678";
        private string user_Id;//用户编号
        private string user_pwd;//密码
        private string user_grade;//级别
        private string user_exten;//分机号
        
        private List<string> user_permissions = new List<string>();//用户权限

        //初始化
        static UserInfo()
        {
            user = new UserInfo();
        }

        public static UserInfo Get_User()
        {
            return user;
        }
        //用户编号属性
        public string User_Id
        {
            get
            {
                return user.user_Id;
            }
            set
            {
                user.user_Id = value;
            }
        }

        //用户密码属性
        public string User_Pwd
        {
            get
            {
                return user.user_pwd;
            }
            set
            {
                user.user_pwd = value;
            }
        }

        //用户密码属性
        public string User_Exten
        {
            get
            {
                return user.user_exten;
            }
            set
            {
                user.user_exten = value;
            }
        }

        public string User_Grade
        {
            get
            {
                return user.user_grade;
            }
            set
            {
                user.user_grade = value;
            }
        }

        //用户权限属性
        public List<string> User_permissions
        {
            get
            {
                return user.user_permissions;
            }
            set
            {
                user.user_permissions = value;
            }
        }
       //用户姓名
        public string UserName{ get;set;}

        public void get_permissions()
        {
            string[] result = DAL.CustomerSellerService.getService().GetUserPermissions(user.user_Id);
            if (result != null)
            {
                user_permissions = result.ToList<string>();
            }
        }
    }
}
