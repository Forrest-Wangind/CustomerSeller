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
using CustomerSeller.DAL;
using System.Collections;

namespace CustomerSeller.UIL
{
    public partial class PhoneParamSetting : UserControl
    {
        ServiceReference1.User user;

        public PhoneParamSetting()
        {
            InitializeComponent();
            showGroups();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            this.tb_DailyPhoneNumber.Clear();
            this.tb_PhoneTotalNumber.Clear();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                var PhoneType = getPhoneType(comboBoxExPhoneType);
                CustomerInfo.GetServiceInstance().SetPhoneParams(this.tb_DailyPhoneNumber.Text.Trim(),
                                 this.tb_PhoneTotalNumber.Text.Trim(), PhoneType);
                MessageBoxEx.Show("修改成功!", "提示");
            }
            catch
            {
                MessageBoxEx.Show("网络异常!", "提示");
            }

        }

        private string getPhoneType(ComboBox cb)
        {
            string phoneType = string.Empty;
            switch (cb.SelectedIndex)
            {
                case 1:
                    phoneType = "A"; break;
                case 2:
                    phoneType = "B"; break;
                case 3:
                    phoneType = "C"; break;
                default:
                    break;
            }

            return phoneType;
        }

        /// <summary>
        /// 显示所有的销售部门
        /// </summary>
        private void showGroups()
        {
            ServiceReference1.SaleGroup group = new ServiceReference1.SaleGroup();
            group.groupName = string.Empty;
            DataSet groups = CustomerSellerService.getService().GetSaleGroups(group);
            if (groups != null && groups.Tables.Count > 0)
            {
                ArrayList lists = new ArrayList();
                lists.Add(new Model.comBoxItem(" ", ""));
                for (int index = 0; index < groups.Tables[0].Rows.Count; index++)
                {
                    string value = groups.Tables[0].Rows[index][0].ToString();
                    string key = groups.Tables[0].Rows[index][1].ToString();
                    lists.Add(new Model.comBoxItem(key, value));
                }

                this.cbGroup.DisplayMember = "pkey";
                this.cbGroup.ValueMember = "pvalue";
                this.cbGroup.DataSource = lists;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string phoneType = getPhoneType(cbPhoneType);
            user = new ServiceReference1.User();
            user.userID = this.tbUserId.Text.Trim();
            user.userName = this.tbUserName.Text.Trim();
            user.saleGroup = this.cbGroup.SelectedValue.ToString().Trim();

            DataSet phoneDs = CustomerSellerService.getService().GetPhoneDetail(phoneType, user);
            if(phoneDs != null && phoneDs.Tables.Count > 1)
            {
                this.dgv_phone_detail.DataSource = phoneDs.Tables[0];
                this.dgv_phone_general.DataSource = phoneDs.Tables[1];
            }
        }
    }
}
