namespace CustomerSeller.UIL.User
{
    partial class QuerySaler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuerySaler));
            this.lb_EmployeeID = new DevComponents.DotNetBar.LabelX();
            this.tb_EmployeeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bt_Cancer = new DevComponents.DotNetBar.ButtonX();
            this.bt_OK = new DevComponents.DotNetBar.ButtonX();
            this.pbQuery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_EmployeeID
            // 
            this.lb_EmployeeID.Location = new System.Drawing.Point(12, 20);
            this.lb_EmployeeID.Name = "lb_EmployeeID";
            this.lb_EmployeeID.Size = new System.Drawing.Size(75, 23);
            this.lb_EmployeeID.TabIndex = 1;
            this.lb_EmployeeID.Text = "员工：";
            // 
            // tb_EmployeeName
            // 
            // 
            // 
            // 
            this.tb_EmployeeName.Border.Class = "TextBoxBorder";
            this.tb_EmployeeName.Location = new System.Drawing.Point(69, 20);
            this.tb_EmployeeName.Name = "tb_EmployeeName";
            this.tb_EmployeeName.Size = new System.Drawing.Size(132, 21);
            this.tb_EmployeeName.TabIndex = 2;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgView.Location = new System.Drawing.Point(11, 62);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 23;
            this.dgView.Size = new System.Drawing.Size(277, 310);
            this.dgView.TabIndex = 3;
            // 
            // bt_Cancer
            // 
            this.bt_Cancer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancer.Location = new System.Drawing.Point(213, 393);
            this.bt_Cancer.Name = "bt_Cancer";
            this.bt_Cancer.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancer.TabIndex = 0;
            this.bt_Cancer.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(12, 393);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 4;
            this.bt_OK.Text = "确认";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // pbQuery
            // 
            this.pbQuery.Image = ((System.Drawing.Image)(resources.GetObject("pbQuery.Image")));
            this.pbQuery.Location = new System.Drawing.Point(252, 15);
            this.pbQuery.Name = "pbQuery";
            this.pbQuery.Size = new System.Drawing.Size(36, 32);
            this.pbQuery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuery.TabIndex = 5;
            this.pbQuery.TabStop = false;
            this.pbQuery.Click += new System.EventHandler(this.pbQuery_Click);
            // 
            // QuerySaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 428);
            this.Controls.Add(this.pbQuery);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.tb_EmployeeName);
            this.Controls.Add(this.lb_EmployeeID);
            this.Controls.Add(this.bt_Cancer);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "QuerySaler";
            this.Text = "选择员工";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lb_EmployeeID;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_EmployeeName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgView;
        private DevComponents.DotNetBar.ButtonX bt_Cancer;
        private DevComponents.DotNetBar.ButtonX bt_OK;
        private System.Windows.Forms.PictureBox pbQuery;
    }
}