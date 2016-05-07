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

namespace CustomerSeller.UIL.SaleLevel
{
    public partial class LevelList : UserControl
    {
        private Form_Main parentForm;
        private string selectedLevelId;

        public LevelList()
        {
            InitializeComponent();
        }

        public LevelList(Form_Main parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void tsm_add_Click(object sender, EventArgs e)
        {
            this.parentForm.addLevelPanel("add", string.Empty);
        }

        private void tsm_update_Click(object sender, EventArgs e)
        {
            this.parentForm.addLevelPanel("update", selectedLevelId);
        }

        private void tsm_delete_Click(object sender, EventArgs e)
        {
            this.parentForm.addLevelPanel("delete", selectedLevelId);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ServiceReference1.SaleLevel level = new ServiceReference1.SaleLevel();
            level.levelName = this.tb_level_name.Text.Trim();
            DataSet levels = CustomerSellerService.getService().GetSaleLevels(level);
            if (levels != null && levels.Tables[0].Rows.Count > 0)
            {
                this.dgv_levels.DataSource = levels.Tables[0];
            }
        }

        private void dgv_levels_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                selectedLevelId = this.dgv_levels.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
