using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerSeller.DAL;
using DevComponents.DotNetBar;

namespace CustomerSeller.UIL.SaleLevel
{
    public partial class LevelDetail : UserControl
    {
        string operation = string.Empty;
        string levelId = string.Empty;
        ServiceReference1.SaleLevel saleLevel;

        public LevelDetail()
        {
            InitializeComponent();
        }

        public LevelDetail(string operation, string levelId)
        {
            InitializeComponent();
            this.operation = operation;

            switch (operation)
            {
                case "add":
                    initButtonSubmit("添加");
                    break;
                case "update":
                    initButtonSubmit("修改");
                    this.levelId = levelId;
                    showLevel();
                    break;
                case "delete":
                    initButtonSubmit("删除");
                    this.levelId = levelId;
                    showLevel();
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

        private void showLevel()
        {
            ServiceReference1.SaleLevel level = DAL.CustomerSellerService.getService().GetSaleLevelDetail(levelId);
            if (level != null)
            {
                this.tbLevelName.Text = level.levelName;
                this.tbRemark.Text = level.levelRemark;
                this.tbAMaxNumber.Value = level.AMaxNumber;
                this.tbADailyNumber.Value = level.ADailyNumber;
                this.tbARemark.Text = level.ARemark;
                this.tbBMaxNumber.Value = level.BMaxNumber;
                this.tbBDailyNumber.Value = level.BDailyNumber;
                this.tbBRemark.Text = level.BRemark;
                this.tbCMaxNumber.Value = level.CMaxNumber;
                this.tbCDailyNumber.Value = level.CDailyNumber;
                this.tbCRemark.Text = level.CRemark;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "add":
                    addLevel();
                    break;
                case "update":
                    updateLevel();
                    break;
                case "delete":
                    deleteLevel();
                    break;
                default:
                    break;
            }
        }

        private void deleteLevel()
        {
            if (!string.IsNullOrEmpty(levelId))
            {
                if (CustomerSellerService.getService().DeleteSaleLevel(levelId))
                    MessageBoxEx.Show("删除销售员级别成功！");
                else
                    MessageBoxEx.Show("删除销售员级别失败！");
            }
        }

        private void updateLevel()
        {
            if(!string.IsNullOrEmpty(levelId))
            {
                saleLevel = new ServiceReference1.SaleLevel();
                saleLevel.levelID = this.levelId;
                saleLevel.levelName = this.tbLevelName.Text.Trim();
                saleLevel.levelRemark = this.tbRemark.Text.Trim();
                saleLevel.AMaxNumber = (int)tbAMaxNumber.Value;
                saleLevel.ADailyNumber = (int)tbADailyNumber.Value;
                saleLevel.ARemark = this.tbARemark.Text.Trim();
                saleLevel.BMaxNumber = (int)tbBMaxNumber.Value;
                saleLevel.BDailyNumber = (int)tbBDailyNumber.Value;
                saleLevel.BRemark = this.tbBRemark.Text.Trim();
                saleLevel.CMaxNumber = (int)tbCMaxNumber.Value;
                saleLevel.CDailyNumber = (int)tbCDailyNumber.Value;
                saleLevel.CRemark = this.tbCRemark.Text.Trim();

                if (CustomerSellerService.getService().UpdateSaleLevel(saleLevel))
                    MessageBoxEx.Show("修改销售员级别成功！");
                else
                    MessageBoxEx.Show("修改销售员级别失败，请仔细核对您输入的信息！");
            }
        }

        private void addLevel()
        {
            if (!string.IsNullOrEmpty(this.tbLevelName.Text.Trim()))
            {
                saleLevel = new ServiceReference1.SaleLevel();
                saleLevel.levelName = this.tbLevelName.Text.Trim();
                saleLevel.levelRemark = this.tbRemark.Text.Trim();
                saleLevel.AMaxNumber = (int)tbAMaxNumber.Value;
                saleLevel.ADailyNumber = (int)tbADailyNumber.Value;
                saleLevel.ARemark = this.tbARemark.Text.Trim();
                saleLevel.BMaxNumber = (int)tbBMaxNumber.Value;
                saleLevel.BDailyNumber = (int)tbBDailyNumber.Value;
                saleLevel.BRemark = this.tbBRemark.Text.Trim();
                saleLevel.CMaxNumber = (int)tbCMaxNumber.Value;
                saleLevel.CDailyNumber = (int)tbCDailyNumber.Value;
                saleLevel.CRemark = this.tbCRemark.Text.Trim();
                if (CustomerSellerService.getService().AddSaleLevel(saleLevel))
                    MessageBoxEx.Show("添加销售员级别成功！");
                else
                    MessageBoxEx.Show("添加销售员级别失败，请仔细核对您输入的信息！");
            }
        }
    }
}
