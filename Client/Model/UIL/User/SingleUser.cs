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

        public SingleUser(string _operation, string userId)
        {
            InitializeComponent();
            this.operation = _operation;
            ArrayList lists = new ArrayList();
            lists.Add(new Model.comBoxItem("男", "m"));
            lists.Add(new Model.comBoxItem("女", "f"));
            lists.Add(new Model.comBoxItem("未知", "u"));
            this.cb_gender.DisplayMember = "pkey";
            this.cb_gender.ValueMember = "pvalue";
            this.cb_gender.DataSource = lists;

            //显示系统中所有的角色
            showRoles();

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
                    showUser(userId);
                    //显示该用户的当前信息
                    break;
                case "delete":
                    initButtonSubmit("删除");
                    showUser(userId);
                    break;
                default:
                    showUser(userId);
                    break;
            }
        }

        private void initButtonSubmit(string name)
        {
            this.btn_submit.Visible = true;
            this.btn_submit.Text = name;
        }

        /// <summary>
        /// 显示系统中所有的角色
        /// </summary>
        private void showRoles()
        {
            DataSet roles = CustomerSellerService.getService().GetUserRoles(UserInfo.Get_User().User_Id);
            if (roles != null && roles.Tables[0].Rows.Count > 0)
            {
                int index = 0;
                while (index < roles.Tables[0].Rows.Count)
                {
                    TreeNode role = new TreeNode();
                    role.Text = roles.Tables[0].Rows[index]["name"].ToString();
                    role.Name = roles.Tables[0].Rows[index]["id"].ToString();
                    this.tree_role.Nodes.Add(role);

                    index++;
                }
            }

            if (roles.Tables.Count > 1)
            {
                int index = 0;
                while (index < roles.Tables[1].Rows.Count)
                {
                    SelectTree(this.tree_role, roles.Tables[1].Rows[index]["id"].ToString());
                    index++;
                }
            }
        }

        private void SelectTree(TreeView tree, string node)
        {
            foreach(TreeNode tn in tree.Nodes)
            {
                if (tn.Name == node)
                {
                    tn.Checked = true;
                    break;
                }
            }
        }

        private string getSelectedTree(TreeView tree)
        {
            string selectedRole = string.Empty;
            foreach (TreeNode tn in tree.Nodes)
            {
                if (tn.Checked)
                {
                    selectedRole = tn.Name;
                    break;
                }
            }

            return selectedRole;
        }

        public void showUser(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                user = CustomerSellerService.getService().GetSingleUser(userId);
                if (user != null)
                {
                    this.tb_user_id.Text = user.userID;
                    this.tb_user_name.Text = user.userName;
                    this.tb_password.Text = user.password;
                    this.tb_password_again.Text = user.password;
                    this.cb_gender.SelectedIndex = user.gender == "m" ? 0 : (user.gender == "f" ? 1 : 2);
                    this.tb_extension.Text = user.exten;
                    this.dt_entryTine.Value = user.entryTimeStart;
                }
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
                    string passKey = string.IsNullOrEmpty(tb_passKey.Text) ? "12345678" : tb_passKey.Text;
                    user.password = Encrypt.DESEncrypt(this.tb_password.Text, passKey);
                    user.role = getSelectedTree(this.tree_role);
                    user.exten = this.tb_extension.Text.Trim();
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
                        user.exten = this.tb_extension.Text.Trim();
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
            string userId = this.tb_user_id.Text.Trim();
            if (!string.IsNullOrEmpty(userId))
            {
                try
                {
                    if (CustomerSellerService.getService().DeleteUser(userId))
                    {
                        MessageBoxEx.Show("删除用户成功");
                    }
                    else
                    {
                        MessageBoxEx.Show("删除用户失败，请仔细核对您输入的信息");
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "错误:");
                }
            }
        }
    }
}
