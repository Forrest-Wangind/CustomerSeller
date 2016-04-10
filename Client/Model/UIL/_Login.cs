using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CustomerSeller.DAL;
using CustomerSeller.Common;
using CustomerSeller.ServiceReference1;
using WCFService.Common;

namespace CustomerSeller
{
    public partial class _Login : Office2007Form
    {
        public _Login()
        {
            InitializeComponent();
        }

        private void tb_userId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (this.tb_userId.Text.Trim() == "")
                return;
            else
                this.tb_Pwd.Focus();

        }

        private void tb_Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (this.tb_Pwd.Text.Trim() == "")
                return;
            else
            {
                UserInfo.Get_User().User_Id = this.tb_userId.Text.Trim();
                UserInfo.Get_User().User_Pwd = this.tb_Pwd.Text.Trim();
                Login();
            }
        }

        //取消
        private void bt_Cancer_Click(object sender, EventArgs e)
        {
            this.tb_userId.Text = "";
            this.tb_Pwd.Text = "";
            this.tb_userId.Focus();
        }

        //确定
        private void bt_Ok_Click(object sender, EventArgs e)
        {

            Login();
        }

        //登录主界面
        private void Login()
        {
            try
            {
                if (this.tb_Pwd.Text.Trim() == ""||this.tb_userId.Text.Trim()=="")
                {
                    MessageBox.Show("提示","用户名和密码不可为空!");
                    return;
                }
                   
                else
                {
                    UserInfo.Get_User().User_Id = this.tb_userId.Text.Trim();
                    UserInfo.Get_User().User_Pwd = this.tb_Pwd.Text.Trim();
                    //用户名和密码匹配
                    var userLoginStatus = JudgeUserExists(UserInfo.Get_User().User_Id, UserInfo.Get_User().User_Pwd);
                    if (userLoginStatus == LoginStatus.LoginSuccess)
                    {
                        UserInfo.Get_User().get_permissions();
                        this.Hide();
                        Form_Main Home = new Form_Main(this);
                        Home.Show();
                        Home.Activate();
                        this.Hide();
                    }
                    else if (userLoginStatus == LoginStatus.UserAlreadyLogin)
                    {
                        MessageBoxEx.Show("该用户已经登录系统，请先退出之前的账号!", "提示");
                        this.tb_userId.Focus();
                    }
                    else
                    {
                        MessageBoxEx.Show("用户名和密码不正确!", "提示");
                        this.tb_userId.Focus();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show("网络繁忙,请稍后再试!","提示");
            }

        }

        private LoginStatus JudgeUserExists(string UserID, string PassWord)
        {
            var loginStatus = LoginStatus.UserNameAndPasswordWrong;
            var loginUser = new User() { userID = UserID, password = Encrypt.DESEncrypt(PassWord, UserInfo.pwdKey) };
            var ds = CustomerInfo.GetServiceInstance().GetUserInfo(loginUser);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                var flag = ds.Tables[0].Rows[0][0].ToString();
                if (!flag.Equals("-1") && !flag.Equals("-2") && !flag.Equals("-3"))
                {
                    UserInfo.Get_User().User_Id = ds.Tables[0].Rows[0]["UserID"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["UserID"].ToString();
                    UserInfo.Get_User().User_Exten = ds.Tables[0].Rows[0]["Exten"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["Exten"].ToString();
                    UserInfo.Get_User().User_Grade = ds.Tables[0].Rows[0]["RoleName"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["RoleName"].ToString();
                    UserInfo.Get_User().UserName = ds.Tables[0].Rows[0]["UserName"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["UserName"].ToString();
                    loginStatus = LoginStatus.LoginSuccess;
                }
                else if (flag.Equals("-3"))
                {
                    loginStatus = LoginStatus.UserAlreadyLogin;
                }
                else
                {
                    loginStatus = LoginStatus.UserNameAndPasswordWrong;
                }

            }
            return loginStatus;
        }
    }

    public enum LoginStatus
    {
        LoginSuccess,
        UserNameAndPasswordWrong,
        UserAlreadyLogin
    }
}
