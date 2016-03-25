namespace CustomerSeller.UIL.User
{
    partial class UserList
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user_id = new System.Windows.Forms.TextBox();
            this.lab_user_id = new System.Windows.Forms.Label();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.lab_user_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_userList = new System.Windows.Forms.DataGridView();
            this.cms_user = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pagerControl1 = new TActionProject.PagerControl();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userList)).BeginInit();
            this.cms_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.dtp_endDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_startDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_user_id);
            this.groupBox1.Controls.Add(this.lab_user_id);
            this.groupBox1.Controls.Add(this.tb_user_name);
            this.groupBox1.Controls.Add(this.lab_user_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(121, 212);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(367, 103);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(200, 20);
            this.cb_gender.TabIndex = 10;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Location = new System.Drawing.Point(367, 154);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.ShowCheckBox = true;
            this.dtp_endDate.Size = new System.Drawing.Size(200, 21);
            this.dtp_endDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "到";
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(121, 154);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.ShowCheckBox = true;
            this.dtp_startDate.Size = new System.Drawing.Size(200, 21);
            this.dtp_startDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "入职时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "性别：";
            // 
            // tb_user_id
            // 
            this.tb_user_id.Location = new System.Drawing.Point(121, 52);
            this.tb_user_id.Name = "tb_user_id";
            this.tb_user_id.Size = new System.Drawing.Size(161, 21);
            this.tb_user_id.TabIndex = 3;
            // 
            // lab_user_id
            // 
            this.lab_user_id.AutoSize = true;
            this.lab_user_id.Location = new System.Drawing.Point(50, 55);
            this.lab_user_id.Name = "lab_user_id";
            this.lab_user_id.Size = new System.Drawing.Size(65, 12);
            this.lab_user_id.TabIndex = 2;
            this.lab_user_id.Text = "用户编号：";
            // 
            // tb_user_name
            // 
            this.tb_user_name.Location = new System.Drawing.Point(121, 103);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(161, 21);
            this.tb_user_name.TabIndex = 1;
            // 
            // lab_user_name
            // 
            this.lab_user_name.AutoSize = true;
            this.lab_user_name.Location = new System.Drawing.Point(50, 106);
            this.lab_user_name.Name = "lab_user_name";
            this.lab_user_name.Size = new System.Drawing.Size(65, 12);
            this.lab_user_name.TabIndex = 0;
            this.lab_user_name.Text = "用户姓名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 270);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_userList);
            this.panel2.Controls.Add(this.pagerControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 421);
            this.panel2.TabIndex = 2;
            // 
            // dgv_userList
            // 
            this.dgv_userList.AllowUserToAddRows = false;
            this.dgv_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userList.ContextMenuStrip = this.cms_user;
            this.dgv_userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_userList.Location = new System.Drawing.Point(0, 0);
            this.dgv_userList.Name = "dgv_userList";
            this.dgv_userList.RowTemplate.Height = 23;
            this.dgv_userList.Size = new System.Drawing.Size(1030, 392);
            this.dgv_userList.TabIndex = 1;
            this.dgv_userList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_userList_CellMouseDown);
            // 
            // cms_user
            // 
            this.cms_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_add,
            this.tsm_update,
            this.tsm_delete});
            this.cms_user.Name = "cms_user";
            this.cms_user.Size = new System.Drawing.Size(101, 70);
            this.cms_user.Text = "操作";
            // 
            // tsm_add
            // 
            this.tsm_add.Name = "tsm_add";
            this.tsm_add.Size = new System.Drawing.Size(100, 22);
            this.tsm_add.Text = "添加";
            this.tsm_add.Click += new System.EventHandler(this.tsm_add_Click);
            // 
            // tsm_update
            // 
            this.tsm_update.Name = "tsm_update";
            this.tsm_update.Size = new System.Drawing.Size(100, 22);
            this.tsm_update.Text = "修改";
            this.tsm_update.Click += new System.EventHandler(this.tsm_update_Click);
            // 
            // tsm_delete
            // 
            this.tsm_delete.Name = "tsm_delete";
            this.tsm_delete.Size = new System.Drawing.Size(100, 22);
            this.tsm_delete.Text = "删除";
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 392);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 100;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(1030, 29);
            this.pagerControl1.TabIndex = 0;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(1030, 691);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userList)).EndInit();
            this.cms_user.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.Label lab_user_name;
        private System.Windows.Forms.TextBox tb_user_id;
        private System.Windows.Forms.Label lab_user_id;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TActionProject.PagerControl pagerControl1;
        private System.Windows.Forms.DataGridView dgv_userList;
        private System.Windows.Forms.ContextMenuStrip cms_user;
        private System.Windows.Forms.ToolStripMenuItem tsm_add;
        private System.Windows.Forms.ToolStripMenuItem tsm_update;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
    }
}