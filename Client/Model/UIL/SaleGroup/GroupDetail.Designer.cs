namespace CustomerSeller.UIL.SaleGroup
{
    partial class GroupDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btClear = new DevComponents.DotNetBar.ButtonX();
            this.tbGroupName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRemark = new DevComponents.DotNetBar.LabelX();
            this.tbGroupId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(321, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btClear
            // 
            this.btClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClear.Location = new System.Drawing.Point(420, 284);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "清空";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbGroupName
            // 
            // 
            // 
            // 
            this.tbGroupName.Border.Class = "TextBoxBorder";
            this.tbGroupName.Location = new System.Drawing.Point(396, 192);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(139, 21);
            this.tbGroupName.TabIndex = 11;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(286, 192);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(94, 23);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "销售部门名称：";
            // 
            // tbGroupId
            // 
            // 
            // 
            // 
            this.tbGroupId.Border.Class = "TextBoxBorder";
            this.tbGroupId.Location = new System.Drawing.Point(396, 149);
            this.tbGroupId.Name = "tbGroupId";
            this.tbGroupId.Size = new System.Drawing.Size(139, 21);
            this.tbGroupId.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(286, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "销售部门编号：";
            // 
            // GroupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.tbGroupId);
            this.Controls.Add(this.lblName);
            this.Name = "GroupDetail";
            this.Size = new System.Drawing.Size(809, 483);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btClear;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupName;
        private DevComponents.DotNetBar.LabelX lblRemark;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupId;
        private DevComponents.DotNetBar.LabelX lblName;
    }
}