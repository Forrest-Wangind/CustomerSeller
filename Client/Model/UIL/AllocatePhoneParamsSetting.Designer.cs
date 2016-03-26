namespace CustomerSeller.UIL
{
    partial class PhoneParamSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_PhoneTotalNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_DailyPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bt_save = new DevComponents.DotNetBar.ButtonX();
            this.bt_clear = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(38, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(140, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "业务可取电话总数：";
            // 
            // tb_PhoneTotalNumber
            // 
            // 
            // 
            // 
            this.tb_PhoneTotalNumber.Border.Class = "TextBoxBorder";
            this.tb_PhoneTotalNumber.Location = new System.Drawing.Point(214, 34);
            this.tb_PhoneTotalNumber.Name = "tb_PhoneTotalNumber";
            this.tb_PhoneTotalNumber.Size = new System.Drawing.Size(139, 21);
            this.tb_PhoneTotalNumber.TabIndex = 1;
            // 
            // tb_DailyPhoneNumber
            // 
            // 
            // 
            // 
            this.tb_DailyPhoneNumber.Border.Class = "TextBoxBorder";
            this.tb_DailyPhoneNumber.Location = new System.Drawing.Point(214, 86);
            this.tb_DailyPhoneNumber.Name = "tb_DailyPhoneNumber";
            this.tb_DailyPhoneNumber.Size = new System.Drawing.Size(139, 21);
            this.tb_DailyPhoneNumber.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(38, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "业务每天可取电话量：";
            // 
            // bt_save
            // 
            this.bt_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_save.Location = new System.Drawing.Point(103, 191);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "保存";
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_clear.Location = new System.Drawing.Point(242, 191);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "清空";
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // PhoneParamSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tb_DailyPhoneNumber);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tb_PhoneTotalNumber);
            this.Controls.Add(this.labelX1);
            this.Name = "PhoneParamSetting";
            this.Size = new System.Drawing.Size(437, 282);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PhoneTotalNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_DailyPhoneNumber;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bt_save;
        private DevComponents.DotNetBar.ButtonX bt_clear;
    }
}
