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
    public partial class PhoneParamSetting : UserControl
    {
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
                var PhoneType = string.Empty;
                switch(comboBoxExPhoneType.SelectedIndex)
                {
                    case 0:
                        PhoneType = "A";break;
                    case 1:
                        PhoneType = "B"; break;
                    case 2:
                        PhoneType = "C"; break;

                }
                CustomerInfo.GetServiceInstance().SetPhoneParams(this.tb_DailyPhoneNumber.Text.Trim(),
                                 this.tb_PhoneTotalNumber.Text.Trim(), PhoneType);
                MessageBoxEx.Show("修改成功!", "提示");
            }
            catch
            {
                MessageBoxEx.Show("网络异常!", "提示");
            }

        }
    }
}
