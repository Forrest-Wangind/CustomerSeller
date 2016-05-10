using CustomerSeller.DAL;
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WCFService.Common;

namespace CustomerSeller.UIL.User
{
    public partial class SingleUser : UserControl
    {
        string operation = string.Empty;
        string theRole = string.Empty;
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
            lists.Add(new Model.comBoxItem("未知", "u"));
            lists.Add(new Model.comBoxItem("男", "m"));
            lists.Add(new Model.comBoxItem("女", "f"));
            this.cb_gender.DisplayMember = "pkey";
            this.cb_gender.ValueMember = "pvalue";
            this.cb_gender.DataSource = lists;

            //显示系统中所有的角色
            showRoles(userId);

            showLevels();

            switch (operation)
            {
                case "add":
                    initButtonSubmit("添加");
                    this.dt_entryTine.Enabled = true;
                    this.gp_password.Text = "新密码";
                    this.gp_user_info.Visible = true;
                    this.gp_password.Visible = true;
                    this.tb_user_id.Enabled = true;
                    this.gp_role.Visible = true;
                    this.tb_extension.Enabled = true;
                    break;
                case "update":
                    initButtonSubmit("修改");
                    this.cb_change_pass.Visible = true;
                    this.gp_user_info.Visible = true;
                    this.dt_entryTine.Enabled = true;
                    //如果有修改其他用户的权限
                    if (UserInfo.Get_User().User_permissions.Contains("001004"))
                    {
                        this.gp_role.Visible = true;
                    }
                    //如果有修改分机号的权限
                    if (UserInfo.Get_User().User_permissions.Contains("001005"))
                    {
                        this.tb_extension.Enabled = true;
                    }

                    showUser(userId);
                    //显示该用户的当前信息
                    break;
                case "delete":
                    this.gp_user_info.Visible = true;
                    this.gp_role.Visible = true;
                    initButtonSubmit("删除");
                    showUser(userId);
                    break;
                default:
                    showUser(userId);
                    //调整修改密码panel居中显示
                    Point location = new Point();
                    location.X = (this.btn_submit.Width - this.gp_password.Width) / 2 + this.btn_submit.Location.X;
                    location.Y = (this.Height - this.gp_password.Height) / 2 + this.Location.Y;
                    this.gp_password.Visible = true;
                    this.gp_password.Location = location;
                    initButtonSubmit("修改");
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
        private void showRoles(string userId)
        {
            DataSet roles = CustomerSellerService.getService().GetUserRoles(userId);
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
                    theRole = roles.Tables[1].Rows[index]["id"].ToString();
                    if(theRole.Equals("002"))
                    {
                        showSaleLevel(true);
                    }

                    SelectTree(this.tree_role, theRole);
                    index++;
                }
            }
        }

        /// <summary>
        /// 显示所有的销售级别
        /// </summary>
        private void showLevels()
        {
            ServiceReference1.SaleLevel level = new ServiceReference1.SaleLevel();
            level.levelName = string.Empty;
            level.isSample = true;
            DataSet levels = CustomerSellerService.getService().GetSaleLevels(level);
            if (levels != null && levels.Tables.Count > 0)
            {
                ArrayList lists = new ArrayList();
                for (int index = 0; index < levels.Tables[0].Rows.Count; index++)
                {
                    string value = levels.Tables[0].Rows[index]["id"].ToString();
                    string key = levels.Tables[0].Rows[index]["name"].ToString();
                    lists.Add(new Model.comBoxItem(key, value));
                }
                this.cbLevel.DisplayMember = "pkey";
                this.cbLevel.ValueMember = "pvalue";
                this.cbLevel.DataSource = lists;
            }
        }

        private void SelectTree(TreeView tree, string node)
        {
            foreach (TreeNode tn in tree.Nodes)
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
                    //this.tb_password.Text = user.password;
                    //this.tb_password_again.Text = user.password;
                    this.cb_gender.SelectedIndex = user.gender == "u" ? 0 : (user.gender == "m" ? 1 : 2);
                    this.tb_extension.Text = user.exten;
                    this.dt_entryTine.Value = user.entryTimeStart;
                    this.cbLevel.SelectedValue = user.saleLevel;
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
                case "changePWD":
                    changePassword();
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
                    user.password = Encrypt.DESEncrypt(this.tb_password.Text, UserInfo.pwdKey);
                    user.role = getSelectedTree(this.tree_role);
                    user.exten = this.tb_extension.Text.Trim();
                    user.gender = this.cb_gender.SelectedValue.ToString();
                    user.entryTimeStart = this.dt_entryTine.IsEmpty ? DateTime.Now : this.dt_entryTine.Value;
                    user.saleLevel = this.cbLevel.Visible ? this.cbLevel.SelectedValue.ToString() : null;

                    if (!user.role.Equals(string.Empty))
                    {
                        if (CustomerSellerService.getService().AddUser(user))
                            MessageBoxEx.Show("添加用户成功！");
                        else
                            MessageBoxEx.Show("添加用户失败，请仔细核对您输入的信息！");
                    }
                    else
                    {
                        MessageBoxEx.Show("请给该用户选择一个角色");
                    }
                }
            }
            else {
                MessageBoxEx.Show("请输入用户编号！");
            }
        }

        private void changePassword()
        {
            if (!string.IsNullOrEmpty(UserInfo.Get_User().User_Id))
            {
                if (isPasswordSame())
                {
                    user = new ServiceReference1.User();
                    user.userID = UserInfo.Get_User().User_Id;
                    user.password = Encrypt.DESEncrypt(this.tb_password.Text, UserInfo.pwdKey);

                    if (CustomerSellerService.getService().ChangeUserPwd(user))
                        MessageBoxEx.Show("修改密码成功！");
                    else
                        MessageBoxEx.Show("修改密码失败，请联系管理员！");
                }
            }
            else
            {
                MessageBoxEx.Show("用户编号为空，请重新登录！");
            }
        }

        //判断密码是否一致
        private bool isPasswordSame()
        {
            if (!this.cb_change_pass.Checked)
                return true;

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
                        user.password = this.cb_change_pass.Checked ? Encrypt.DESEncrypt(this.tb_password.Text, UserInfo.pwdKey) : string.Empty;
                        user.role = getSelectedTree(this.tree_role);
                        user.gender = this.cb_gender.SelectedValue.ToString();
                        user.exten = this.tb_extension.Text.Trim();
                        user.entryTimeStart = this.dt_entryTine.Value;
                        user.saleLevel = this.cbLevel.Visible ? this.cbLevel.SelectedValue.ToString() : null;

                        if (!user.role.Equals(string.Empty))
                        {
                            if (CustomerSellerService.getService().UpdateUser(user))
                            {
                                MessageBoxEx.Show("修改用户成功");
                            }
                            else
                            {
                                MessageBoxEx.Show("修改用户失败，请仔细核对您输入的信息");
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("请给该用户选择一个角色");
                        }
                    }
                    catch (Exception ex)
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

        private void tree_role_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Checked)
                {
                    if (e.Node.Name.Equals("002"))
                    {
                        //显示销售级别
                        showSaleLevel(true);
                    }
                    else
                    {
                        showSaleLevel(false);
                    }

                    foreach (TreeNode node in tree_role.Nodes)
                    {
                        if (node.Name != e.Node.Name)
                        {
                            node.Checked = false;
                        }
                    }
                }
                else
                {
                    showSaleLevel(false);
                }
            }
        }

        private void showSaleLevel(bool isSaleLevel)
        {
            this.lblLevel.Visible = isSaleLevel;
            this.cbLevel.Visible = isSaleLevel;
        }
    }
}