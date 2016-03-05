namespace CustomerSeller.UIL
{
    partial class Form_CustomerDetail
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
            this.bt_Save = new DevComponents.DotNetBar.ButtonX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_SuccessTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_PhoneStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_CustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_CustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Agender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_CallPhone = new DevComponents.DotNetBar.ButtonX();
            this.bt_RecycleCustomerPhone = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Save.Location = new System.Drawing.Point(115, 4);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 14;
            this.bt_Save.Text = "保存";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.Location = new System.Drawing.Point(216, 4);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 15;
            this.bt_Cancer.Text = "清空";
            this.bt_Cancer.Click += new System.EventHandler(this.bt_Cancer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_SuccessTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_PhoneStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_Remark);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_CustomerAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_CustomerPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_Agender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_CustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 338);
            this.panel1.TabIndex = 16;
            // 
            // dtp_SuccessTime
            // 
            this.dtp_SuccessTime.Location = new System.Drawing.Point(114, 223);
            this.dtp_SuccessTime.Name = "dtp_SuccessTime";
            this.dtp_SuccessTime.Size = new System.Drawing.Size(117, 21);
            this.dtp_SuccessTime.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "成交时间：";
            // 
            // cb_PhoneStatus
            // 
            this.cb_PhoneStatus.FormattingEnabled = true;
            this.cb_PhoneStatus.Items.AddRange(new object[] {
            "预成交",
            "已成交",
            "有意向",
            "无意向"});
            this.cb_PhoneStatus.Location = new System.Drawing.Point(114, 185);
            this.cb_PhoneStatus.Name = "cb_PhoneStatus";
            this.cb_PhoneStatus.Size = new System.Drawing.Size(117, 20);
            this.cb_PhoneStatus.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "电话状态：";
            // 
            // tb_Remark
            // 
            this.tb_Remark.Location = new System.Drawing.Point(501, 26);
            this.tb_Remark.Multiline = true;
            this.tb_Remark.Name = "tb_Remark";
            this.tb_Remark.Size = new System.Drawing.Size(375, 218);
            this.tb_Remark.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "备注：";
            // 
            // tb_CustomerAddress
            // 
            this.tb_CustomerAddress.Location = new System.Drawing.Point(114, 141);
            this.tb_CustomerAddress.Name = "tb_CustomerAddress";
            this.tb_CustomerAddress.Size = new System.Drawing.Size(117, 21);
            this.tb_CustomerAddress.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "客户地址：";
            // 
            // tb_CustomerPhone
            // 
            this.tb_CustomerPhone.Location = new System.Drawing.Point(114, 104);
            this.tb_CustomerPhone.Name = "tb_CustomerPhone";
            this.tb_CustomerPhone.Size = new System.Drawing.Size(117, 21);
            this.tb_CustomerPhone.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "客户电话：";
            // 
            // tb_Agender
            // 
            this.tb_Agender.Location = new System.Drawing.Point(114, 66);
            this.tb_Agender.Name = "tb_Agender";
            this.tb_Agender.Size = new System.Drawing.Size(117, 21);
            this.tb_Agender.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "客户性别：";
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Location = new System.Drawing.Point(114, 29);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(117, 21);
            this.tb_CustomerName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "客户姓名：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_CallPhone);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.bt_RecycleCustomerPhone);
            this.panel2.Controls.Add(this.bt_Cancer);
            this.panel2.Location = new System.Drawing.Point(12, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 33);
            this.panel2.TabIndex = 17;
            // 
            // bt_CallPhone
            // 
            this.bt_CallPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_CallPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_CallPhone.Location = new System.Drawing.Point(13, 4);
            this.bt_CallPhone.Name = "bt_CallPhone";
            this.bt_CallPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_CallPhone.TabIndex = 17;
            this.bt_CallPhone.Text = "拨打电话";
            // 
            // bt_RecycleCustomerPhone
            // 
            this.bt_RecycleCustomerPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_RecycleCustomerPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_RecycleCustomerPhone.Location = new System.Drawing.Point(322, 4);
            this.bt_RecycleCustomerPhone.Name = "bt_RecycleCustomerPhone";
            this.bt_RecycleCustomerPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_RecycleCustomerPhone.TabIndex = 15;
            this.bt_RecycleCustomerPhone.Text = "回收电话";
            this.bt_RecycleCustomerPhone.Click += new System.EventHandler(this.bt_RecycleCustomerPhone_Click);
            // 
            // Form_CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form_CustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "客户信息的详细界面";
            this.Load += new System.EventHandler(this.Form_CustomerDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bt_Save;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_SuccessTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_PhoneStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_CustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_CustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Agender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX bt_CallPhone;
        private DevComponents.DotNetBar.ButtonX bt_RecycleCustomerPhone;

    }
}