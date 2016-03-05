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
    public partial class User_Update : UserControl
    {
        public User_Update()
        {
            InitializeComponent();
        }

        //private void bt_Ok_Click(object sender, EventArgs e)
        //{
        //    if (this.tb_New_Pwd.Text.Trim() != this.tb_Repeated_Pwd.Text.Trim())
        //        MessageBox.Show("两次输入的密码不一致！", "提示");
        //    else
        //    {
        //        if (!Pwd_RW())
        //            MessageBox.Show("原来的密码不正确！", "提示");
        //        else
        //        {
        //            if (Pwd_Update())
        //                MessageBox.Show("修改成功！", "提示");
        //        }


        //    }

        //}

        private void bt_Cancer_Click(object sender, EventArgs e)
        {
            this.tb_New_Pwd.Text = "";
            this.tb_Pwd.Text = "";
            this.tb_userId.Text = "";
            this.tb_Repeated_Pwd.Text = "";
        }

        //原来密码是否正确
        //private Boolean Pwd_RW()
        //{
        //    try
        //    {
        //        string str = "select 1 from user_info where [user_Id]='" + this.tb_userId.Text.Trim() + "' and user_Pwd='" +
        //            this.tb_Pwd.Text.Trim() + "'";
        //        if (D_Customer.Query_Fruit(str) != null)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //       return false;
        //    }
        //}


        //修改密码
        //private Boolean Pwd_Update()
        //{

        //    try
        //    {
        //        string str = "Update user_info set user_Pwd='" + this.tb_New_Pwd.Text.Trim() + "' where  [user_Id]='" +
        //        this.tb_userId.Text.Trim() + "'";
        //        if (D_Customer.Execute_Fruit(str))
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
