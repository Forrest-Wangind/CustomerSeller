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

namespace CustomerSeller.UIL
{
    public partial class PhoneParamSetting : UserControl
    {
        ServiceReference1.User user;

        public PhoneParamSetting()
        {
            InitializeComponent();
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
                case 0:
                    phoneType = "A"; break;
                case 1:
                    phoneType = "B"; break;
                case 2:
                    phoneType = "C"; break;
                default:
                    break;
            }

            return phoneType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string phoneType = getPhoneType(cbPhoneType);
            user = new ServiceReference1.User();
            user.userID = this.tbUserId.Text.Trim();

            DataSet phoneDs = CustomerSellerService.getService().GetPhoneDetail(phoneType, user);
            if(phoneDs != null && phoneDs.Tables.Count > 1)
            {
                this.dgv_phone_detail.DataSource = phoneDs.Tables[0];
                this.dgv_phone_general.DataSource = phoneDs.Tables[1];
            }
        }
    }
}
