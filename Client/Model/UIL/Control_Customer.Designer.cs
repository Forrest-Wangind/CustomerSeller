using TActionProject;
namespace CustomerSeller
{
    partial class Control_Customer
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
            this.lb_Customer_Name = new DevComponents.DotNetBar.LabelX();
            this.lb_Customer_Phone = new DevComponents.DotNetBar.LabelX();
            this.tb_Customer_Phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Customer_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_Query = new DevComponents.DotNetBar.ButtonX();
            this.bt_Del = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_Status = new DevComponents.DotNetBar.LabelX();
            this.dtp_End_DealTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_Create_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start_DealTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_Create_StartTime = new System.Windows.Forms.DateTimePicker();
            this.lb_Success_StartTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Success_EndTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Create_StartTime = new DevComponents.DotNetBar.LabelX();
            this.lb_Create_EndTime = new DevComponents.DotNetBar.LabelX();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.bt_GetPhone = new DevComponents.DotNetBar.ButtonX();
            this.pagerControl1 = new TActionProject.PagerControl();
            this.groupBox1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Customer_Name
            // 
            this.lb_Customer_Name.Location = new System.Drawing.Point(20, 20);
            this.lb_Customer_Name.Name = "lb_Customer_Name";
            this.lb_Customer_Name.Size = new System.Drawing.Size(67, 21);
            this.lb_Customer_Name.TabIndex = 0;
            this.lb_Customer_Name.Text = "客户姓名:";
            // 
            // lb_Customer_Phone
            // 
            this.lb_Customer_Phone.Location = new System.Drawing.Point(196, 14);
            this.lb_Customer_Phone.Name = "lb_Customer_Phone";
            this.lb_Customer_Phone.Size = new System.Drawing.Size(64, 33);
            this.lb_Customer_Phone.TabIndex = 4;
            this.lb_Customer_Phone.Text = "客户手机:";
            // 
            // tb_Customer_Phone
            // 
            // 
            // 
            // 
            this.tb_Customer_Phone.Border.Class = "TextBoxBorder";
            this.tb_Customer_Phone.Location = new System.Drawing.Point(278, 20);
            this.tb_Customer_Phone.Name = "tb_Customer_Phone";
            this.tb_Customer_Phone.Size = new System.Drawing.Size(105, 21);
            this.tb_Customer_Phone.TabIndex = 10;
            // 
            // tb_Customer_Name
            // 
            // 
            // 
            // 
            this.tb_Customer_Name.Border.Class = "TextBoxBorder";
            this.tb_Customer_Name.Location = new System.Drawing.Point(93, 20);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(88, 21);
            this.tb_Customer_Name.TabIndex = 8;
            // 
            // bt_Query
            // 
            this.bt_Query.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Query.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Query.Location = new System.Drawing.Point(18, 113);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(75, 23);
            this.bt_Query.TabIndex = 12;
            this.bt_Query.Text = "查询";
            this.bt_Query.Click += new System.EventHandler(this.bt_Query_Click);
            // 
            // bt_Del
            // 
            this.bt_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Del.Location = new System.Drawing.Point(141, 113);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(75, 23);
            this.bt_Del.TabIndex = 13;
            this.bt_Del.Text = "清空";
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_GetPhone);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.bt_Del);
            this.groupBox1.Controls.Add(this.bt_Query);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Controls.Add(this.dtp_End_DealTime);
            this.groupBox1.Controls.Add(this.dtp_Create_EndTime);
            this.groupBox1.Controls.Add(this.dtp_Start_DealTime);
            this.groupBox1.Controls.Add(this.dtp_Create_StartTime);
            this.groupBox1.Controls.Add(this.lb_Success_StartTime);
            this.groupBox1.Controls.Add(this.lb_Success_EndTime);
            this.groupBox1.Controls.Add(this.lb_Create_StartTime);
            this.groupBox1.Controls.Add(this.lb_Create_EndTime);
            this.groupBox1.Controls.Add(this.lb_Customer_Name);
            this.groupBox1.Controls.Add(this.tb_Customer_Name);
            this.groupBox1.Controls.Add(this.lb_Customer_Phone);
            this.groupBox1.Controls.Add(this.tb_Customer_Phone);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(94, 65);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(87, 20);
            this.cb_status.TabIndex = 18;
            // 
            // lb_Status
            // 
            this.lb_Status.Location = new System.Drawing.Point(20, 65);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(67, 21);
            this.lb_Status.TabIndex = 17;
            this.lb_Status.Text = "成交状态:";
            // 
            // dtp_End_DealTime
            // 
            this.dtp_End_DealTime.Location = new System.Drawing.Point(513, 65);
            this.dtp_End_DealTime.Name = "dtp_End_DealTime";
            this.dtp_End_DealTime.ShowCheckBox = true;
            this.dtp_End_DealTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_End_DealTime.TabIndex = 16;
            // 
            // dtp_Create_EndTime
            // 
            this.dtp_Create_EndTime.Location = new System.Drawing.Point(733, 14);
            this.dtp_Create_EndTime.Name = "dtp_Create_EndTime";
            this.dtp_Create_EndTime.ShowCheckBox = true;
            this.dtp_Create_EndTime.Size = new System.Drawing.Size(106, 21);
            this.dtp_Create_EndTime.TabIndex = 16;
            // 
            // dtp_Start_DealTime
            // 
            this.dtp_Start_DealTime.Location = new System.Drawing.Point(278, 65);
            this.dtp_Start_DealTime.Name = "dtp_Start_DealTime";
            this.dtp_Start_DealTime.ShowCheckBox = true;
            this.dtp_Start_DealTime.Size = new System.Drawing.Size(107, 21);
            this.dtp_Start_DealTime.TabIndex = 15;
            // 
            // dtp_Create_StartTime
            // 
            this.dtp_Create_StartTime.Location = new System.Drawing.Point(513, 19);
            this.dtp_Create_StartTime.Name = "dtp_Create_StartTime";
            this.dtp_Create_StartTime.ShowCheckBox = true;
            this.dtp_Create_StartTime.Size = new System.Drawing.Size(107, 21);
            this.dtp_Create_StartTime.TabIndex = 15;
            // 
            // lb_Success_StartTime
            // 
            this.lb_Success_StartTime.Location = new System.Drawing.Point(196, 65);
            this.lb_Success_StartTime.Name = "lb_Success_StartTime";
            this.lb_Success_StartTime.Size = new System.Drawing.Size(87, 21);
            this.lb_Success_StartTime.TabIndex = 11;
            this.lb_Success_StartTime.Text = "成交开始时间:";
            // 
            // lb_Success_EndTime
            // 
            this.lb_Success_EndTime.Location = new System.Drawing.Point(409, 60);
            this.lb_Success_EndTime.Name = "lb_Success_EndTime";
            this.lb_Success_EndTime.Size = new System.Drawing.Size(99, 33);
            this.lb_Success_EndTime.TabIndex = 12;
            this.lb_Success_EndTime.Text = "成交截止时间：";
            // 
            // lb_Create_StartTime
            // 
            this.lb_Create_StartTime.Location = new System.Drawing.Point(409, 20);
            this.lb_Create_StartTime.Name = "lb_Create_StartTime";
            this.lb_Create_StartTime.Size = new System.Drawing.Size(98, 21);
            this.lb_Create_StartTime.TabIndex = 11;
            this.lb_Create_StartTime.Text = "获取开始时间:";
            // 
            // lb_Create_EndTime
            // 
            this.lb_Create_EndTime.Location = new System.Drawing.Point(644, 11);
            this.lb_Create_EndTime.Name = "lb_Create_EndTime";
            this.lb_Create_EndTime.Size = new System.Drawing.Size(99, 33);
            this.lb_Create_EndTime.TabIndex = 12;
            this.lb_Create_EndTime.Text = "获取截止时间：";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgv_Customer);
            this.panelData.Controls.Add(this.pagerControl1);
            this.panelData.Location = new System.Drawing.Point(10, 220);
            this.panelData.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(872, 276);
            this.panelData.TabIndex = 15;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowTemplate.Height = 23;
            this.dgv_Customer.Size = new System.Drawing.Size(872, 244);
            this.dgv_Customer.TabIndex = 0;
            this.dgv_Customer.DoubleClick += new System.EventHandler(this.dgv_Customer_DoubleClick);
            // 
            // bt_GetPhone
            // 
            this.bt_GetPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_GetPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_GetPhone.Location = new System.Drawing.Point(278, 113);
            this.bt_GetPhone.Name = "bt_GetPhone";
            this.bt_GetPhone.Size = new System.Drawing.Size(75, 23);
            this.bt_GetPhone.TabIndex = 19;
            this.bt_GetPhone.Text = "取电话";
            this.bt_GetPhone.Click += new System.EventHandler(this.bt_GetPhone_Click);
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 247);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 100;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(872, 29);
            this.pagerControl1.TabIndex = 1;
            // 
            // Control_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control_Customer";
            this.Size = new System.Drawing.Size(1080, 515);
            this.groupBox1.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lb_Customer_Name;
        private PagerControl pagerControl1;
        private DevComponents.DotNetBar.LabelX lb_Customer_Phone;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Customer_Phone;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Customer_Name;
        private DevComponents.DotNetBar.ButtonX bt_Query;
        private DevComponents.DotNetBar.ButtonX bt_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_status;
        private DevComponents.DotNetBar.LabelX lb_Status;
        private System.Windows.Forms.DateTimePicker dtp_End_DealTime;
        private System.Windows.Forms.DateTimePicker dtp_Create_EndTime;
        private System.Windows.Forms.DateTimePicker dtp_Start_DealTime;
        private System.Windows.Forms.DateTimePicker dtp_Create_StartTime;
        private DevComponents.DotNetBar.LabelX lb_Success_StartTime;
        private DevComponents.DotNetBar.LabelX lb_Success_EndTime;
        private DevComponents.DotNetBar.LabelX lb_Create_StartTime;
        private DevComponents.DotNetBar.LabelX lb_Create_EndTime;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private DevComponents.DotNetBar.ButtonX bt_GetPhone;

            




    }
}
