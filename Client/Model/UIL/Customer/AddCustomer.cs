using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerSeller.Common;
using DevComponents.DotNetBar;

namespace CustomerSeller.UIL
{
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            this.tb_Customer_Name.Clear();
            this.tb_CustomerAddress.Clear();
            this.tb_CustomerPhone.Clear();
            this.cb_Agender.SelectedIndex = -1;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var customerInfoDataTable = CustomerInfo.GetCustomerInfoTable();
                var dr = customerInfoDataTable.NewRow();
                dr["CustomerGender"] = this.cb_Agender.Text.Trim();
                dr["CustomerPhone"] = this.tb_CustomerPhone.Text.Trim();
                dr["CustomerAddress"] = this.tb_CustomerAddress.Text.Trim();
                dr["CustomerName"] = this.tb_Customer_Name.Text.Trim();
                customerInfoDataTable.Rows.Add(dr);
                var ds = new DataSet();
                ds.Tables.Add(customerInfoDataTable);
                CustomerInfo.GetServiceInstance().BatchImportCustomerInfo(ds);
                MessageBoxEx.Show("客户信息添加成功!","提示");
            }
            catch
            {
                MessageBoxEx.Show("网络繁忙，稍后再试");
            }
        }
    }
}
