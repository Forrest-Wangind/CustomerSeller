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

namespace CustomerSeller.UIL.Role
{
    public partial class RoleList : UserControl
    {
        private Form_Main parentForm;
        private string selectedRoleId;

        public RoleList()
        {
            InitializeComponent();
        }

        public RoleList(Form_Main parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //查询所有的角色
            this.dgv_roles.DataSource = null;
            ServiceReference1.Role role = new ServiceReference1.Role();
            role.roleName = this.tb_role_name.Text.Trim();
            DataSet roles = CustomerSellerService.getService().GetRoles(role);
            if (roles != null && roles.Tables[0].Rows.Count > 0)
            {
                this.dgv_roles.DataSource = roles.Tables[0];
            }
        }

        private void tsm_add_Click(object sender, EventArgs e)
        {
            this.parentForm.addRolePanel("add", string.Empty);
        }

        private void tsm_update_Click(object sender, EventArgs e)
        {
            this.parentForm.addRolePanel("update", selectedRoleId);
        }

        private void tsm_delete_Click(object sender, EventArgs e)
        {
            this.parentForm.addRolePanel("delete", selectedRoleId);
        }

        private void dgv_roles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                selectedRoleId = this.dgv_roles.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
