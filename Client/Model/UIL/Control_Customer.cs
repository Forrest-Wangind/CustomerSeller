﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerSeller.DAL;
using DevComponents.DotNetBar;
using System.IO;
using SQLHelper;
using CustomerSeller.UIL;
using System.Data.SqlClient;
using CustomerSeller.ServiceReference1;
using CustomerSeller.Common;

namespace CustomerSeller
{
    public partial class Control_Customer : UserControl
    {
       
        public Control_Customer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pagerControl1.OnPageChanged += pagerControl1_OnPageChanged;
        }

        private List<KeyValuePair<string, string>> GetCondition()
        {

            List<KeyValuePair<string,string>> listParameters = new List<KeyValuePair<string,string>>();
            if(!string.IsNullOrEmpty(this.tb_Customer_Name.Text))
                listParameters.Add(new KeyValuePair<string, string>("CustomerName like ", string.Format("%{0}%",tb_Customer_Name.Text)));
            if(!string.IsNullOrEmpty(this.tb_Customer_Phone.Text))
                listParameters.Add(new KeyValuePair<string, string>("CustomerPhone=", tb_Customer_Phone.Text));
            if(this.dtp_Create_StartTime.Checked)
                listParameters.Add(new KeyValuePair<string, string>("AllocateTime>=", this.dtp_Create_StartTime.Value.ToString("yyyy-MM-dd")));
            if (this.dtp_Create_EndTime.Checked)
                listParameters.Add(new KeyValuePair<string, string>("AllocateTime<=", this.dtp_Create_EndTime.Value.ToString("yyyy-MM-dd")));
            if(!string.IsNullOrEmpty(this.cb_status.Text))
                listParameters.Add(new KeyValuePair<string,string>("PhoneStratus=",this.cb_status.Text ));
            if(this.dtp_Start_DealTime.Checked)
                listParameters.Add(new KeyValuePair<string,string>("DealTime>=",this.dtp_Start_DealTime.Value.ToString("yyyy-MM-dd")));
            if(this.dtp_End_DealTime.Checked)
                listParameters.Add(new KeyValuePair<string,string>("DealTime<=",this.dtp_End_DealTime.Value.ToString("yyyy-MM-dd")));
            return listParameters;

        }
      
        private void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            try
            {
                
                var condition = GetCondition();
                Service1Client client = new Service1Client();
                var dataset=client.GetCustomer(this.pagerControl1.PageSize, this.pagerControl1.PageIndex, condition.ToArray());
                this.dgv_Customer.DataSource = dataset.Tables[1];
                this.dgv_Customer.Columns["CustomerID"].Visible = false;
                pagerControl1.DrawControl(Convert.ToInt32(dataset.Tables[0].Rows[0][0]));
                client.Close();
                
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show("系统繁忙，稍后再试", "提示");
            }
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            //将控件里面的信息清空
            this.tb_Customer_Name.Clear();
            this.tb_Customer_Phone.Clear();
            this.dtp_End_DealTime.Checked=false;
            this.dtp_Start_DealTime.Checked=false;
            this.dtp_Create_StartTime.Checked = false;
            this.dtp_Create_EndTime.Checked=false;
            
        }
        private void bt_Query_Click(object sender, EventArgs e)
        {
            pagerControl1_OnPageChanged(null, null);
        }

        private void dgv_Customer_DoubleClick(object sender, EventArgs e)
        {
            int index = this.dgv_Customer.CurrentRow.Index;    //取得选中行的索引   
            var row=(this.dgv_Customer.DataSource as DataTable).Rows[index];
            new Form_CustomerDetail() { DR = row }.ShowDialog();
        }

        private void bt_GetPhone_Click(object sender, EventArgs e)
        {   
            //员工静态信息获取添加进来
            var enployeeID = string.Empty;
            //var result = CustomerInfo.GetServiceInstance().AllocateEmployeePhone(enployeeID);
            //switch (result)
            //{
            //    case 0:
            //        MessageBoxEx.Show("电话分配完毕,没有可用资源!", "提示");
            //        break;
            //    case 1:
            //        MessageBoxEx.Show("电话分配完毕,没有可用资源!", "提示");
            //        break;
            //    default:
            //        MessageBoxEx.Show("电话分配出现异常!", "提示");
            //        break;
            //}           
        }
    }
}
