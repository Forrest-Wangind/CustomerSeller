using CustomerSeller.DAL;
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
        private Form_Main parentForm;
        private string selectedUserId = string.Empty;
        private UserInfo loginUser = UserInfo.Get_User();

        public UserList()
        {
            initForm();
        }

        public UserList(Form_Main parent)
        {
            this.parentForm = parent;
            initForm();
        }

        private void initForm()
        {
            InitializeComponent();
            ArrayList lists = new ArrayList();
            lists.Add(new Model.comBoxItem("未知", "u"));
            lists.Add(new Model.comBoxItem("男", "m"));
            lists.Add(new Model.comBoxItem("女", "f"));
            this.cb_gender.DisplayMember = "pkey";
            this.cb_gender.ValueMember = "pvalue";
            this.cb_gender.DataSource = lists;
            foreach (string permission in loginUser.User_permissions)
            {
                switch (permission)
                {
                    case "001002":
                        this.tsm_add.Visible = true;
                        break;
                    case "001003":
                        this.tsm_update.Visible = true;
                        break;
                    case "001004":
                        this.tsm_delete.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ServiceReference1.User user = new ServiceReference1.User();
            user.userID = this.tb_user_id.Text.Trim();
            user.userName = this.tb_user_name.Text.Trim();
            user.role = null;
            user.gender = this.cb_gender.SelectedValue.ToString() == "u" ? "" : this.cb_gender.SelectedValue.ToString();
            user.entryTimeStart = this.dti_startDate.IsEmpty ? DateTime.Parse("1900-01-01") : this.dti_startDate.Value;
            user.entryTimeEnd = this.dti_endDate.IsEmpty ? DateTime.Parse("2999-12-31") : this.dti_endDate.Value;
            var users = DAL.CustomerSellerService.getService().GetUsersForSaleMan(user, loginUser.User_Id);
            if (users != null)
            {
                this.dgv_userList.DataSource = users.Tables[0];
            }
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_add_Click(object sender, EventArgs e)
        {
            parentForm.addUserPanel("add", string.Empty);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_update_Click(object sender, EventArgs e)
        {
            parentForm.addUserPanel("update", selectedUserId);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_delete_Click(object sender, EventArgs e)
        {
            parentForm.addUserPanel("delete", selectedUserId);
        }

        private void dgv_userList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                selectedUserId = this.dgv_userList.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
