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
using CustomerSeller.UIL.Customer;
using CustomerSeller.UIL.User;

namespace CustomerSeller
{
    public partial class Control_Customer : UserControl
    {
        public EmployeePhoneInfo employeePhoneInfo;
        public Control_Customer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pagerControl1.OnPageChanged += pagerControl1_OnPageChanged;
            this.dgv_Customer.AllowUserToAddRows = false;
            employeePhoneInfo = new EmployeePhoneInfo() { EmployeeInfo = new EmployeePhoneInfo.Employee(), PhoneID = new List<string>() };
            InitComponent();

        }
        private void InitComponent()
        {
            if (!UserInfo.Get_User().User_Grade.Trim().Equals("管理员"))
            {
                this.bt_AllocatePhone.Visible = false;
                this.bt_RecyclePhone.Visible = false;
            }
            else
            {
                Point P_A = this.bt_GetPhoneOfA.Location;
                Point P_B = this.bt_GetPhoneOfB.Location;
                this.bt_GetPhoneOfA.Visible = false;
                this.bt_GetPhoneOfB.Visible = false;
                this.bt_GetPhoneOfC.Visible = false;

                this.bt_AllocatePhone.Location = P_A;
                this.bt_RecyclePhone.Location = P_B;
            }
        }
        private List<KeyValuePair<string, string>> GetCondition()
        {

            List<KeyValuePair<string, string>> listParameters = new List<KeyValuePair<string, string>>();
            if (!UserInfo.Get_User().User_Grade.Trim().Equals("管理员"))
                listParameters.Add(new KeyValuePair<string, string>("EmployeeID=", UserInfo.Get_User().User_Id));
            if (!string.IsNullOrEmpty(this.tb_Customer_Name.Text))
                listParameters.Add(new KeyValuePair<string, string>("CustomerName like ", string.Format("%{0}%", tb_Customer_Name.Text)));
            if (!string.IsNullOrEmpty(this.tb_Customer_Phone.Text))
                listParameters.Add(new KeyValuePair<string, string>("CustomerPhone=", tb_Customer_Phone.Text));
            if (!this.dtp_Create_StartTime.IsEmpty)
                listParameters.Add(new KeyValuePair<string, string>("AllocateTime>=", this.dtp_Create_StartTime.Value.ToString("yyyy-MM-dd")));
            if (!this.dtp_Create_EndTime.IsEmpty)
                listParameters.Add(new KeyValuePair<string, string>("AllocateTime<=", this.dtp_Create_EndTime.Value.ToString("yyyy-MM-dd")));
            if (!string.IsNullOrEmpty(this.cb_status.Text))
                listParameters.Add(new KeyValuePair<string, string>("PhoneStratus=", this.cb_status.Text));
            if (!this.dtp_Start_DealTime.IsEmpty)
                listParameters.Add(new KeyValuePair<string, string>("DealTime>=", this.dtp_Start_DealTime.Value.ToString("yyyy-MM-dd")));
            if (!this.dtp_End_DealTime.IsEmpty)
                listParameters.Add(new KeyValuePair<string, string>("DealTime<=", this.dtp_End_DealTime.Value.ToString("yyyy-MM-dd")));
            if (this.comboBoxExPhoneType.SelectedIndex != -1)
                listParameters.Add(new KeyValuePair<string, string>("PhoneType=", this.getPhoneType(this.comboBoxExPhoneType)));
            return listParameters;
        }

        private void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            try
            {
                var condition = GetCondition();
                var dataset = CustomerInfo.GetServiceInstance().GetCustomer(this.pagerControl1.PageSize, this.pagerControl1.PageIndex, condition.ToArray());
                if (UserInfo.Get_User().User_Grade.Trim().Equals("管理员") && !this.dgv_Customer.Columns.Contains("Choice"))
                {
                    DataGridViewCheckBoxColumn newColumn = new DataGridViewCheckBoxColumn();
                    newColumn.HeaderText = "选择";
                    newColumn.Name = "Choice";
                    this.dgv_Customer.Columns.Add(newColumn);
                }
                /*变成不可编辑的列*/
                for (int index = 0; index < this.dgv_Customer.Columns.Count; index++)
                {
                    if (this.dgv_Customer.Columns[index].Name == "Choice")
                        continue;
                    this.dgv_Customer.Columns[index].ReadOnly = true;
                }

                this.dgv_Customer.DataSource = dataset.Tables[1];
                this.dgv_Customer.Columns["CustomerID"].Visible = false;

                pagerControl1.DrawControl(Convert.ToInt32(dataset.Tables[0].Rows[0][0]));

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("系统繁忙，稍后再试", "提示");
            }
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            //将控件里面的信息清空
            this.tb_Customer_Name.Clear();
            this.tb_Customer_Phone.Clear();
            this.dtp_End_DealTime.ResetText();
            this.dtp_Start_DealTime.ResetText();
            this.dtp_Create_StartTime.ResetText();
            this.dtp_Create_EndTime.ResetText();
            this.cb_status.SelectedIndex = -1;

        }
        private void bt_Query_Click(object sender, EventArgs e)
        {
            pagerControl1_OnPageChanged(null, null);
        }

        private void bt_GetPhone_Click(object sender, EventArgs e)
        {
            //员工静态信息获取添加进来
            var employeeID = UserInfo.Get_User().User_Id;
            var phoneType = (sender as DevComponents.DotNetBar.ButtonX).Tag.ToString();
            ShowTips(CustomerInfo.GetServiceInstance().AllocateEmployeePhone(employeeID, phoneType));

        }

        private void dgv_Customer_DoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var dataGridRow = this.dgv_Customer.CurrentRow;
                if (dataGridRow == null)
                    MessageBoxEx.Show("没有选中任何一条电话记录", "提示");
                int index = dataGridRow.Index;    //取得选中行的索引   
                var row = (this.dgv_Customer.DataSource as DataTable).Rows[index];
                new Form_CustomerDetail() { DR = row }.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("出现未知错误!", "提示");
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

        private void bt_AllocatePhone_Click(object sender, EventArgs e)
        {
            try
            {
                var SuccessNumber = 0;
                var FailNumber = 0;
                employeePhoneInfo.PhoneID.Clear();
                if (new QuerySaler(employeePhoneInfo.EmployeeInfo).ShowDialog() == DialogResult.Cancel)
                    return;
                foreach (DataGridViewRow vr in this.dgv_Customer.Rows)
                {
                    if (Convert.ToBoolean(vr.Cells["Choice"].Value)&&Convert.ToString(vr.Cells["分配的员工"].Value)!=employeePhoneInfo.EmployeeInfo.EmployeeName)
                        employeePhoneInfo.PhoneID.Add(Convert.ToString(vr.Cells["CustomerID"].Value));
                }

                if (employeePhoneInfo.PhoneID.Count <= 0 || string.IsNullOrEmpty(employeePhoneInfo.EmployeeInfo.EmployeeID))
                {
                    MessageBoxEx.Show("没有选择电话或业务员", "提示");
                    return;
                }
                employeePhoneInfo.PhoneID.ForEach(item =>
                    {
                        if (CustomerInfo.GetServiceInstance().AllocateEmployeePhoneByAdmin(item, employeePhoneInfo.EmployeeInfo.EmployeeID).Equals(1))
                            SuccessNumber++;
                        else
                            FailNumber++;
                    });
                MessageBoxEx.Show(string.Format("分配给业务员：{0},成功个数:{1},失败个数:{2}", employeePhoneInfo.EmployeeInfo.EmployeeName, SuccessNumber, FailNumber), "提示");
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("批量分配出现异常");
            }


        }


        private void ShowTips(int result)
        {
            switch (result)
            {
                case 0:
                    MessageBoxEx.Show("电话分配完毕,没有可用资源!", "提示");
                    break;
                case 1:
                    MessageBoxEx.Show("电话获取成功，可以在刷新后看到!", "提示");
                    break;
                case 2:
                    MessageBoxEx.Show("已经超过你可以获取的电话的总数!", "提示");
                    break;
                case 3:
                    MessageBoxEx.Show("已经超过每天可以取的电话的总数!", "提示");
                    break;
                default:
                    MessageBoxEx.Show("电话分配出现异常!", "提示");
                    break;
            }
        }

        private void bt_RecyclePhone_Click(object sender, EventArgs e)
        {
            try
            {
                var SuccessNumber = 0;
                var FailNumber = 0;
                employeePhoneInfo.PhoneID.Clear();
                foreach (DataGridViewRow vr in this.dgv_Customer.Rows)
                {
                    if (Convert.ToBoolean(vr.Cells["Choice"].Value) && !string.IsNullOrEmpty(Convert.ToString(vr.Cells["分配的员工"].Value)))
                        employeePhoneInfo.PhoneID.Add(Convert.ToString(vr.Cells["CustomerID"].Value));
                }

                if (employeePhoneInfo.PhoneID.Count <= 0)
                {
                    MessageBoxEx.Show("没有选择回收的电话，或者回收的电话不被业务员所占有，这类型无效", "提示");
                    return;
                }
                employeePhoneInfo.PhoneID.ForEach(item =>
                {
                    if (CustomerInfo.GetServiceInstance().RecycleCustomerPhone(item, "").Equals(1))
                        SuccessNumber++;
                    else
                        FailNumber++;
                });
                MessageBoxEx.Show(string.Format("回收电话,成功个数:{0},失败个数:{1}", SuccessNumber, FailNumber), "提示");
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show("批量回收出现异常");
            }
        }
    }


    public class EmployeePhoneInfo
    {
        public List<string> PhoneID { get; set; }

        public Employee EmployeeInfo { get; set; }

        public class Employee
        {
            public string EmployeeID;
            public string EmployeeName;
        }

    }

}

