using CustomerSeller.Common;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                Regex _mobileRegex = new Regex("^[0-9]{11,11}$", RegexOptions.Singleline);
                if(!_mobileRegex.IsMatch(this.tb_CustomerPhone.Text.Trim()))
                {
                     MessageBoxEx.Show("请输入有效的电话号码");
                     return;
                }
                var phoneType = string.Empty;
                if (!string.IsNullOrEmpty(this.comboBoxExPhoneType.Text.Trim()))
                    switch (this.comboBoxExPhoneType.Text.Trim())
                    {
                        case "A类型电话": phoneType = "A"; break;
                        case "B类型电话": phoneType = "B"; break;
                        case "C类型电话": phoneType = "C"; break;
                        default: phoneType = "C"; break;
                    }
                var customerInfoDataTable = CustomerInfo.GetCustomerInfoTable();
                var dr = customerInfoDataTable.NewRow();
                dr["CustomerGender"]  = this.cb_Agender.Text.Trim();
                dr["CustomerPhone"]   = this.tb_CustomerPhone.Text.Trim();
                dr["CustomerAddress"] = this.tb_CustomerAddress.Text.Trim();
                dr["CustomerName"]    = this.tb_Customer_Name.Text.Trim();
                dr["PhoneType"] = phoneType;
                customerInfoDataTable.Rows.Add(dr);
                var ds = new DataSet();
                ds.Tables.Add(customerInfoDataTable);
                if (CustomerInfo.GetServiceInstance().BatchImportCustomerInfo(ds))
                    MessageBoxEx.Show("客户信息添加成功!", "提示");
                else
                    MessageBoxEx.Show("数据库中已存在相同的电话", "提示");
            }
            catch
            {
                MessageBoxEx.Show("网络繁忙，稍后再试");
            }
        }
    }
}
