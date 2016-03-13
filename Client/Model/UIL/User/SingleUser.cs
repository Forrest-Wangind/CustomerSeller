using CustomerSeller.DAL;
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFService.Common;

namespace CustomerSeller.UIL.User
{
    public partial class SingleUser : UserControl
    {
        string operation = string.Empty;
        ServiceReference1.User user;

        public SingleUser()
        {
            InitializeComponent();
        }

        public SingleUser(string _operation)
        {
            InitializeComponent();
            this.operation = _operation;
            ArrayList lists = new ArrayList();
            lists.Add(new Model.comBoxItem("男", "m"));
            lists.Add(new Model.comBoxItem("女", "f"));
            this.cb_gender.DisplayMember = "pkey";
            this.cb_gender.ValueMember = "pvalue";
            this.cb_gender.DataSource = lists;

            switch (operation)
            {
                case "add":
                    initButtonSubmit("添加");
                    this.dt_entryTine.Enabled = true;
                    this.gp_password.Visible = true;
                    this.tb_user_id.Enabled = true;
                    break;
                case "update":
                    initButtonSubmit("修改");
                    this.cb_change_pass.Visible = true;
                    this.dt_entryTine.Enabled = true;
                    showUser();
                    //显示该用户的当前信息
                    break;
                case "delete":
                    initButtonSubmit("删除");
                    showUser();
                    break;
                default:
                    showUser();
                    break;
            }
        }

        private void initButtonSubmit(string name)
        {
            this.btn_submit.Visible = true;
            this.btn_submit.Text = name;
        }

        private void showUser()
        {
            user = CustomerSellerService.getService().GetSingleUser(UserInfo.Get_User().User_Id);
            if(user != null)
            {
                this.tb_user_id.Text = user.userID;
                this.tb_user_name.Text = user.userName;
                this.tb_password.Text = user.password;
                this.tb_password_again.Text = user.password;
                this.cb_gender.SelectedIndex = user.gender == "m" ? 0 : 1;
                this.dt_entryTine.Value = user.entryTimeStart;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "add":
                    addUser();
                    break;
                case "update":
                    updateUser();
                    break;
                case "delete":
                    deleteUser();
                    break;
                default:
                    break;
            }
        }

        private void addUser()
        {
            if (!string.IsNullOrEmpty(this.tb_user_name.Text.Trim()))
            {
                if (isPasswordSame())
                {
                    user = new ServiceReference1.User();
                    user.userID = this.tb_user_id.Text.Trim();
                    user.userName = this.tb_user_name.Text.Trim();
                    user.password = Encrypt.DESEncrypt(this.tb_password.Text, "12345678");
                    user.gender = this.cb_gender.SelectedValue.ToString();
                    user.entryTimeStart = this.dt_entryTine.Value;

                    if (CustomerSellerService.getService().AddUser(user))
                        MessageBoxEx.Show("添加用户成功！");
                    else
                        MessageBoxEx.Show("添加用户失败，请仔细核对您输入的信息！");
                }
            }
            else {
                MessageBoxEx.Show("请输入用户编号！");
            }
        }

        //判断密码是否一致
        private bool isPasswordSame()
        {
            if (!string.IsNullOrEmpty(this.tb_password.Text))
            {
                if (this.tb_password.Text != this.tb_password_again.Text)
                {
                    MessageBoxEx.Show("密码两次输入不一致");
                    return false;
                }

                return true;
            }
            else {
                MessageBoxEx.Show("密码不能为空");
                return false;
            }
        }

        private void cb_change_pass_CheckedChanged(object sender, EventArgs e)
        {
            this.gp_password.Visible = this.cb_change_pass.Checked;
        }

        private void updateUser()
        {
            if (!string.IsNullOrEmpty(this.tb_user_name.Text.Trim()))
            {
                if (isPasswordSame())
                {
                    try
                    {
                        user = new ServiceReference1.User();
                        user.userID = this.tb_user_id.Text.Trim();
                        user.userName = this.tb_user_name.Text.Trim();
                        string passKey = string.IsNullOrEmpty(tb_passKey.Text) ? "12345678" : tb_passKey.Text;
                        user.password = this.cb_change_pass.Checked ? Encrypt.DESEncrypt(this.tb_password.Text, passKey) : string.Empty;
                        user.gender = this.cb_gender.SelectedValue.ToString();
                        user.entryTimeStart = this.dt_entryTine.Value;

                        if (CustomerSellerService.getService().UpdateUser(user))
                        {
                            MessageBoxEx.Show("修改用户成功");
                        }
                        else
                        {
                            MessageBoxEx.Show("修改用户失败，请仔细核对您输入的信息");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBoxEx.Show(ex.Message, "错误:");
                    }
                }
            }
            else {
                MessageBoxEx.Show("用户编号不能为空！");
            }
        }

        private void deleteUser()
        {

        }
    }
}
