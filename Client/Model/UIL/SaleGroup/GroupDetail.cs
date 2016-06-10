using CustomerSeller.DAL;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSeller.UIL.SaleGroup
{
    public partial class GroupDetail : UserControl
    {
        private ServiceReference1.SaleGroup saleGroup;
        private string operation;
        private string groupId;
        public GroupDetail()
        {
            InitializeComponent();
        }

        public GroupDetail(string operation, string groupId, string groupName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.operation = operation;
            this.groupId = groupId;

            switch (operation)
            {
                case "add":
                    initButtonSubmit("添加");
                    break;
                case "update":
                    initButtonSubmit("修改");
                    this.groupId = groupId;
                    this.tbGroupId.Text = groupId;
                    this.tbGroupName.Text = groupName;
                    break;
                case "delete":
                    initButtonSubmit("删除");
                    this.groupId = groupId;
                    this.tbGroupId.Text = groupId;
                    this.tbGroupName.Text = groupName;
                    break;
                default:
                    break;
            }
        }

        private void initButtonSubmit(string name)
        {
            this.btnSave.Visible = true;
            this.btnSave.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "add":
                    addGroup();
                    break;
                case "update":
                    updateGroup();
                    break;
                case "delete":
                    deleteGroup();
                    break;
                default:
                    break;
            }
        }

        private void deleteGroup()
        {
            if (!string.IsNullOrEmpty(groupId))
            {
                if (CustomerSellerService.getService().DeleteSaleGroup(groupId))
                    MessageBoxEx.Show("删除销售员级别成功！");
                else
                    MessageBoxEx.Show("删除销售员级别失败！");
            }
        }

        private void updateGroup()
        {
            if (!string.IsNullOrEmpty(groupId))
            {
                saleGroup = new ServiceReference1.SaleGroup();
                saleGroup.groupID = this.groupId;
                saleGroup.groupName = this.tbGroupName.Text.Trim();

                if (CustomerSellerService.getService().UpdateSaleGroup(saleGroup))
                    MessageBoxEx.Show("修改销售部门成功！");
                else
                    MessageBoxEx.Show("修改销售部门失败，请仔细核对您输入的信息！");
            }
        }

        private void addGroup()
        {
            if (!string.IsNullOrEmpty(this.tbGroupId.Text.Trim()))
            {
                saleGroup = new ServiceReference1.SaleGroup();
                saleGroup.groupID = this.tbGroupId.Text.Trim();
                saleGroup.groupName = this.tbGroupName.Text.Trim();
                if (CustomerSellerService.getService().AddSaleGroup(saleGroup))
                    MessageBoxEx.Show("添加销售部门成功！");
                else
                    MessageBoxEx.Show("修改销售部门失败，请仔细核对您输入的信息！");
            }
            else
            {
                MessageBoxEx.Show("销售部门部门不能为空！");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbGroupId.Text = string.Empty;
            this.tbGroupName.Text = string.Empty;
        }
    }
}
