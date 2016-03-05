using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerSeller.UIL.User
{
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
            ArrayList lists = new ArrayList();
            lists.Add(new Model.comBoxItem("男", "m"));
            lists.Add(new Model.comBoxItem("女", "f"));
            this.cb_gender.DisplayMember = "pkey";
            this.cb_gender.ValueMember = "pvalue";
            this.cb_gender.DataSource = lists;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ServiceReference1.User user = new ServiceReference1.User();
            user.userID = this.tb_user_id.Text.Trim();
            user.userName = this.tb_user_name.Text.Trim();
            user.gender = this.cb_gender.SelectedValue.ToString();
            user.entryTimeStart = this.dtp_startDate.Checked ? this.dtp_startDate.Value : DateTime.Parse("1900-01-01");
            user.entryTimeEnd = this.dtp_endDate.Checked ? this.dtp_endDate.Value: DateTime.Parse("2999-12-31");


            var users = DAL.CustomerSellerService.getService().GetUsers(user);
            if (users != null)
            {
                this.dgv_userList.DataSource = users.Tables[0];
            }
        }
    }
}
