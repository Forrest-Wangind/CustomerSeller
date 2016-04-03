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

        private void _Login_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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
            if (this.tb_Pwd.Text.Trim() == "")
                return;
            else
            {
                UserInfo.Get_User().User_Id = this.tb_userId.Text.Trim();
                UserInfo.Get_User().User_Pwd = this.tb_Pwd.Text.Trim();
                //用户名和密码匹配
                if (JudgeUserExists(UserInfo.Get_User().User_Id, UserInfo.Get_User().User_Pwd))
                {
                    UserInfo.Get_User().get_permissions();
                    this.Hide();
                    Form_Main fm = new Form_Main(this);
                    fm.Show();
                    fm.Activate();
                    this.Hide();
                }

            }
        }

        private Boolean JudgeUserExists(string UserID,string PassWord)
        {   
            var result=false;
            var loginUser = new User() { userID = UserID, password = Encrypt.DESEncrypt(PassWord, Encrypt.EncryptKey) };
            var ds = CustomerInfo.GetServiceInstance().GetUserInfo(loginUser);
            if(ds!=null&&ds.Tables[0].Rows.Count>0)
            {   var flag= ds.Tables[0].Rows[0][0].ToString();
                if(!flag.Equals("-1")&&!flag.Equals("-2"))
                {
                    UserInfo.Get_User().User_Id = ds.Tables[0].Rows[0]["UserID"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["UserID"].ToString();
                    UserInfo.Get_User().User_Exten =  ds.Tables[0].Rows[0]["Exten"]==DBNull.Value ? string.Empty:ds.Tables[0].Rows[0]["Exten"].ToString();
                    UserInfo.Get_User().User_Grade = ds.Tables[0].Rows[0]["RoleName"] == DBNull.Value ? string.Empty : ds.Tables[0].Rows[0]["RoleName"].ToString();
                    result = true;
                }
            }
            return result;
        }
    }
}
