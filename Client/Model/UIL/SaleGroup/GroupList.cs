using CustomerSeller.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSeller.UIL.SaleGroup
{
    public partial class GroupList : UserControl
    {
        private Form_Main parentForm;
        private string selectedGroupId;
        private string selectedGroupName;

        public GroupList()
        {
            InitializeComponent();
        }

        public GroupList(Form_Main parent)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            parentForm = parent;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ServiceReference1.SaleGroup group = new ServiceReference1.SaleGroup();
            group.groupName = this.tb_sale_group.Text.Trim();
            DataSet levels = CustomerSellerService.getService().GetSaleGroups(group);
            if (levels != null && levels.Tables[0].Rows.Count > 0)
            {
                this.dgv_groups.DataSource = levels.Tables[0];
            }
        }

        private void tsm_add_Click(object sender, EventArgs e)
        {
            this.parentForm.addGroupPanel("add", string.Empty, string.Empty);
        }

        private void tsm_update_Click(object sender, EventArgs e)
        {
            this.parentForm.addGroupPanel("update", selectedGroupId, selectedGroupName);
        }

        private void tsm_delete_Click(object sender, EventArgs e)
        {
            this.parentForm.addGroupPanel("delete", selectedGroupId, selectedGroupName);
        }

        private void dgv_groups_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedGroupId = this.dgv_groups.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedGroupName = this.dgv_groups.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
