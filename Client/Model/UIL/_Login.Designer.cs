namespace CustomerSeller
{
    partial class _Login
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
            this.lb_user_Id = new DevComponents.DotNetBar.LabelX();
            this.lb_Pwd = new DevComponents.DotNetBar.LabelX();
            this.tb_userId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_Ok = new DevComponents.DotNetBar.ButtonX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lb_user_Id
            // 
            this.lb_user_Id.Location = new System.Drawing.Point(51, 72);
            this.lb_user_Id.Name = "lb_user_Id";
            this.lb_user_Id.Size = new System.Drawing.Size(132, 23);
            this.lb_user_Id.TabIndex = 0;
            this.lb_user_Id.Text = "用户编号：";
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.Location = new System.Drawing.Point(51, 104);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(132, 23);
            this.lb_Pwd.TabIndex = 1;
            this.lb_Pwd.Text = "密    码：";
            // 
            // tb_userId
            // 
            // 
            // 
            // 
            this.tb_userId.Border.Class = "TextBoxBorder";
            this.tb_userId.Location = new System.Drawing.Point(150, 72);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(157, 21);
            this.tb_userId.TabIndex = 2;
            this.tb_userId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userId_KeyDown);
            // 
            // tb_Pwd
            // 
            // 
            // 
            // 
            this.tb_Pwd.Border.Class = "TextBoxBorder";
            this.tb_Pwd.Location = new System.Drawing.Point(150, 105);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.PasswordChar = '*';
            this.tb_Pwd.Size = new System.Drawing.Size(157, 21);
            this.tb_Pwd.TabIndex = 3;
            this.tb_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Pwd_KeyDown);
            // 
            // bt_Ok
            // 
            this.bt_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Ok.Location = new System.Drawing.Point(51, 172);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 4;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.Location = new System.Drawing.Point(232, 172);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 5;
            this.bt_Cancer.Text = "取消";
            this.bt_Cancer.Click += new System.EventHandler(this.bt_Cancer_Click);
            // 
            // _Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 233);
            this.Controls.Add(this.bt_Cancer);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.lb_Pwd);
            this.Controls.Add(this.lb_user_Id);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lb_user_Id;
        private DevComponents.DotNetBar.LabelX lb_Pwd;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userId;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Pwd;
        private DevComponents.DotNetBar.ButtonX bt_Ok;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
    }
}