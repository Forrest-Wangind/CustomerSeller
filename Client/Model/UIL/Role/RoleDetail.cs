using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerSeller.DAL;
using DevComponents.DotNetBar;

namespace CustomerSeller.UIL.Role
{
    public partial class RoleDetail : UserControl
    {
        string operation = string.Empty;

        public RoleDetail()
        {
            InitializeComponent();
            string roleId = "001";
            showRole(roleId);
            showFunctions(roleId);
        }

        public RoleDetail(string _operation, string roleId)
        {
            InitializeComponent();
            this.operation = _operation;
            switch (operation)
            {
                case "add":
                    initButtonSubmit("添加");
                    showFunctions(roleId);
                    this.tb_role_id.Enabled = true;
                    break;
                case "update":
                    initButtonSubmit("修改");
                    showRole(roleId);
                    showFunctions(roleId);
                    break;
                case "delete":
                    initButtonSubmit("删除");
                    showRole(roleId);
                    showFunctions(roleId);
                    break;
                default:
                    showRole(roleId);
                    break;
            }
        }

        private void initButtonSubmit(string name)
        {
            this.btn_submit.Visible = true;
            this.btn_submit.Text = name;
        }

        private void showRole(string roleId)
        {
            ServiceReference1.Role role = DAL.CustomerSellerService.getService().GetRoleDetail(roleId);
            this.tb_role_id.Text = role.roleID;
            this.tb_user_name.Text = role.roleName;
            this.tb_remark.Text = role.roleRemark;
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

        private List<string> getSelectedTree(TreeView tree)
        {
            List<string> selectedFunctions = new List<string>();
            string selectedRole = string.Empty;
            foreach (TreeNode tn in tree.Nodes)
            {
                if (tn.Checked)
                {
                    selectedFunctions.Add(tn.Name);
                }
            }

            return selectedFunctions;
        }

        private void showFunctions(string roleId)
        {
            DataSet functions =  DAL.CustomerSellerService.getService().GetRoleFunctions(roleId);
            if (functions != null && functions.Tables[0].Rows.Count > 0)
            {
                int index = 0;
                while (index < functions.Tables[0].Rows.Count)
                {
                    TreeNode role = new TreeNode();
                    role.Text = functions.Tables[0].Rows[index]["name"].ToString();
                    role.Name = functions.Tables[0].Rows[index]["id"].ToString();
                    this.tree_functions.Nodes.Add(role);

                    index++;
                }
            }

            if (functions.Tables.Count > 1)
            {
                int index = 0;
                while (index < functions.Tables[1].Rows.Count)
                {
                    SelectTree(this.tree_functions, functions.Tables[1].Rows[index]["id"].ToString());
                    index++;
                }
            }
        }

        private void addRole()
        {
            if (!string.IsNullOrEmpty(this.tb_role_id.Text.Trim()))
            {
                ServiceReference1.Role role = new ServiceReference1.Role();
                role.roleID = this.tb_role_id.Text.Trim();
                role.roleName = this.tb_user_name.Text.Trim();
                role.roleRemark = this.tb_remark.Text.Trim();
                role.functions = getSelectedTree(this.tree_functions).ToArray();

                if (CustomerSellerService.getService().AddRole(role))
                    MessageBoxEx.Show("添加角色成功！");
                else
                    MessageBoxEx.Show("添加角色失败，请仔细核对您输入的信息！");
            }
        }

        private void updateRole()
        {
            if (!string.IsNullOrEmpty(this.tb_role_id.Text.Trim()))
            {
                ServiceReference1.Role role = new ServiceReference1.Role();
                role.roleID = this.tb_role_id.Text.Trim();
                role.roleName = this.tb_user_name.Text.Trim();
                role.roleRemark = this.tb_remark.Text.Trim();
                role.functions = getSelectedTree(this.tree_functions).ToArray();

                if (CustomerSellerService.getService().UpdateRole(role))
                    MessageBoxEx.Show("修改角色成功！");
                else
                    MessageBoxEx.Show("修改角色失败，请仔细核对您输入的信息！");
            }
        }

        private void deleteRole()
        {
            string roleId = this.tb_role_id.Text.Trim();
            if (!string.IsNullOrEmpty(roleId))
            {
                try
                {
                    if (CustomerSellerService.getService().DeleteRole(roleId))
                    {
                        MessageBoxEx.Show("删除角色成功");
                    }
                    else
                    {
                        MessageBoxEx.Show("删除角色失败，请仔细核对您输入的信息");
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "错误:");
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "add":
                    addRole();
                    break;
                case "update":
                    updateRole();
                    break;
                case "delete":
                    deleteRole();
                    break;
                default:
                    break;
            }
        }
    }
}
