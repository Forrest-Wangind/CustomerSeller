using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.DAL;
using DevComponents.DotNetBar;

namespace Model.UIL
{
    public partial class User_Add : UserControl
    {
        public User_Add()
        {
            InitializeComponent();
        }

        //添加用户
        private void bt_Ok_Click(object sender, EventArgs e)
        {

            try
            {
                  string execute_sql = "insert into user_info([user_Id],user_Pwd,user_Grade) values('" + this.tb_userId.Text.Trim() + "', '" + this.tb_Pwd.Text.Trim() + "',"+(this.cb_grade.Checked ? 1:0).ToString()+")";
                 if (D_Customer.Execute_Fruit(execute_sql))
                    MessageBox.Show("添加用户成功", "提示");
                else
                   MessageBox.Show("添加用户失败", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
                
        } 

        private void tb_userId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.tb_userId.Text.Trim() == "")
                return;
            if (e.KeyCode != Keys.Enter)
                return;
            else
                this.tb_Pwd.Focus();
        }

        private void bt_Cancer_Click(object sender, EventArgs e)
        {
            this.tb_Pwd.Text = "";
            this.tb_userId.Text = "";
            this.tb_userId.Focus();
        }


        //删除用户
        private void bt_Del_Click(object sender, EventArgs e)
        {
            try
            {
                string execute_sql = "delete from user_info where [user_Id]='" + this.tb_userId.Text.Trim() + "'";
                if (D_Customer.Execute_Fruit(execute_sql))
                    MessageBox.Show("删除用户成功", "提示");
                else
                    MessageBox.Show("删除用户失败", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
        }

        //显示与否
        public void set_Visible(Boolean b)
        {
            this.bt_Del.Visible = b;
        }

        //Ok显示与否
        public void set_Ok_Visible(Boolean b)
        {
            this.bt_Del.Location=this.bt_Ok.Location;
            this.bt_Ok.Visible = b;
        }

      
    }
}
