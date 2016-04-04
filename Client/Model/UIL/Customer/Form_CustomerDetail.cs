using DevComponents.DotNetBar;
using CustomerSeller.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerSeller.DAL;

namespace CustomerSeller.UIL
{
    public partial class Form_CustomerDetail : Office2007Form
    {
        public DataRow DR
        {
            get;
            set;
        }
        public string CustomerPhone
        {
            get;
            set;
        }

        public Form_CustomerDetail()
        {
            InitializeComponent();
        }

        private void bt_Cancer_Click(object sender, EventArgs e)
        {
            this.tb_Agender.SelectedIndex = -1;
            this.tb_CustomerAddress.Clear();
            this.tb_CustomerName.Clear();
            this.tb_CustomerPhone.Clear();
            this.tb_Remark.Clear();
            this.cb_PhoneStatus.SelectedIndex = 0;
            this.dtp_SuccessTime.ResetText();
        }

        private void Form_CustomerDetail_Load(object sender, EventArgs e)
        {
            var id = DR["CustomerID"].ToString();
            var client = CustomerInfo.GetServiceInstance();
            var dataset = client.GetCustomerDetail(id);
            this.tb_Agender.Text = dataset.Tables[0].Rows[0]["CustomerGender"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["CustomerGender"].ToString();
            this.tb_CustomerAddress.Text = dataset.Tables[0].Rows[0]["CustomerAddress"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["CustomerAddress"].ToString();
            this.tb_CustomerName.Text = dataset.Tables[0].Rows[0]["CustomerName"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["CustomerName"].ToString();
            this.tb_Remark.Text = dataset.Tables[0].Rows[0]["Remark"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["Remark"].ToString();
            this.dtp_SuccessTime.Value = Convert.ToDateTime(dataset.Tables[0].Rows[0]["DealTime"] == DBNull.Value ? null : dataset.Tables[0].Rows[0]["DealTime"]);
            SetStatus(dataset, dataset.Tables[0].Rows[0]["PhoneStratus"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["PhoneStratus"].ToString());
            CustomerPhone = dataset.Tables[0].Rows[0]["CustomerPhone"] == DBNull.Value ? string.Empty : dataset.Tables[0].Rows[0]["CustomerPhone"].ToString();
            this.tb_CustomerPhone.Text = CustomerPhone.Length == 11 ? CustomerPhone.Substring(0, 3) + "*****" + CustomerPhone.Substring(8, 3) : string.Empty;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;

        }

        public void SetStatus(DataSet ds, string status)
        {
            if (ds.Tables[0].Rows[0]["PhoneStratus"].ToString().Contains("已成交"))
                this.cb_PhoneStatus.SelectedIndex = Convert.ToInt32(PhoneType.Success);
            if (ds.Tables[0].Rows[0]["PhoneStratus"].ToString().Contains("预成交"))
                this.cb_PhoneStatus.SelectedIndex = Convert.ToInt32(PhoneType.NearSuccess);
            if (ds.Tables[0].Rows[0]["PhoneStratus"].ToString().Contains("有意向"))
                this.cb_PhoneStatus.SelectedIndex = Convert.ToInt32(PhoneType.Mind);
            if (ds.Tables[0].Rows[0]["PhoneStratus"].ToString().Contains("无意向"))
                this.cb_PhoneStatus.SelectedIndex = Convert.ToInt32(PhoneType.NoMind);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dt = null;
                var remarkInfo = this.tb_Remark.Text;
                if (!string.IsNullOrEmpty(this.tb_AppendRemark.Text))
                    remarkInfo = this.tb_Remark.Text + "\r\n" + System.DateTime.Now.ToShortDateString() + "  " + UserInfo.Get_User().UserName + ":" + this.tb_AppendRemark.Text;
                CustomerInfo.GetServiceInstance().UpdateCustomerInfo(string.IsNullOrEmpty(this.tb_CustomerAddress.Text) ? string.Empty : this.tb_CustomerAddress.Text, remarkInfo.TrimStart('\r').TrimStart('\n'),
                    string.IsNullOrEmpty(this.cb_PhoneStatus.Text) ? string.Empty : this.cb_PhoneStatus.Text, this.dtp_SuccessTime.Value < DateTime.Now ? dt : this.dtp_SuccessTime.Value, DR["CustomerID"].ToString(),
                    !this.tb_CustomerPhone.Text.Contains("*") && this.tb_CustomerPhone.Text.Length == 11 ? this.tb_CustomerPhone.Text : string.Empty,
                     string.IsNullOrEmpty(this.tb_CustomerName.Text) ? string.Empty : this.tb_CustomerName.Text);
                MessageBoxEx.Show("用户信息修改成功!");
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("网络异常，请稍后再试!");
            }

        }

        private void bt_RecycleCustomerPhone_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeID = UserInfo.Get_User().User_Id;
                var result = CustomerInfo.GetServiceInstance().RecycleCustomerPhone(DR["CustomerID"].ToString(), employeeID);

                switch (result)
                {
                    case 1:
                        MessageBoxEx.Show("电话资源回收成功!", "提示");
                        break;
                    default:
                        MessageBoxEx.Show("没有可回收的电话资源或回收异常!", "提示");
                        break;
                }

            }
            catch
            {
                MessageBoxEx.Show("网络异常，稍后再试!", "提示");
            }

        }

        private void bt_CallPhone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CustomerPhone))
                {
                    MessageBoxEx.Show("不是有效的电话！", "提示");
                    return;
                }
                var Exten = UserInfo.Get_User().User_Exten;
                var employeeID = UserInfo.Get_User().User_Id;
                if (!CustomerInfo.GetServiceInstance().CallMobilePhone(CustomerPhone.Trim(), employeeID, Exten))
                    throw new Exception("异常");
            }
            catch
            {
                MessageBoxEx.Show("网络异常，稍后再试!", "提示");
            }
        }



    }

    public enum PhoneType
    {
        //预成交
        NearSuccess,
        //已成交
        Success,
        //有意向
        Mind,
        //无意向
        NoMind

    }
}
