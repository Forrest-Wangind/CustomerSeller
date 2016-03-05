using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CustomerSeller.BIL;
using CustomerSeller.DAL;

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
                if (Logon._Login())
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
                UserInfo.Get_User().get_permissions();
                this.Hide();
                Form_Main fm = new Form_Main();
                fm.Show();
                fm.Activate();
                this.Hide();
            }
        }


    }
}
