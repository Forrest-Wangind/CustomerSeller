using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerSeller.DAL;

namespace CustomerSeller.BIL
{
    class Logon
    {


        //登录
        public static Boolean _Login()
        {
            string user_Id  = UserInfo.Get_User().User_Id;
            string user_pwd = UserInfo.Get_User().User_Pwd;
            return D_Login._Login(user_Id, user_pwd);
        }
    }
}
