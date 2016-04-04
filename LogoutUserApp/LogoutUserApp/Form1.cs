using LogoutUserApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoutUserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool logoutSingleUser(string userId)
        {
            return CustomerSellerService.getService().LogoutUser(userId);
        }

        private bool logoutAllUsers()
        {
            return CustomerSellerService.getService().LogoutAllUsers();
        }

        private void btn_logout_single_user_Click(object sender, EventArgs e)
        {
            string userId = this.tb_userId.Text.Trim();
            if (!string.IsNullOrEmpty(userId))
            {
                if (DialogResult.Yes == MessageBox.Show("是否退出该用户", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (logoutSingleUser(userId))
                    {
                        MessageBox.Show("成功退出用户!");
                    }
                    else
                    {
                        MessageBox.Show("用户退出失败, 请联系系统管理员!");
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入用户编号!");
            }
        }

        private void btn_all_users_logout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否退出所有用户", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (logoutAllUsers())
                {
                    MessageBox.Show("成功退出所有用户!");
                }
                else
                {
                    MessageBox.Show("所有用户退出失败, 请联系系统管理员!");
                }
            }
        }
    }
}
