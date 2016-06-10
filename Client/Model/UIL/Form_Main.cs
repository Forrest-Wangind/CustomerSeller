using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SystemSet;
using System.Threading;
using CustomerSeller.UIL;
using CustomerSeller.DAL;
using CustomerSeller.Common;
using CustomerSeller.Control;
using CustomerSeller.UIL.Customer;

namespace CustomerSeller
{
    public partial class Form_Main : Office2007Form
    {
        private _Login loginForm;
        private UserInfo loginUser = UserInfo.Get_User();

        public Form_Main()
        {   
            InitializeComponent();
            this.DoubleBuffered = true;
            set_Text((object)this.Date_label);
            this.WindowState = FormWindowState.Maximized;
            showPermissions();
        }

        public Form_Main(_Login login)
        {
            InitializeComponent();
            this.loginForm = login;
            this.DoubleBuffered = true;
            this.lbl_user.Text = "工号/" + loginUser.User_Id;
            this.lbl_user.Text += "     姓名/" + loginUser.UserName;
            this.lbl_user.Text += "     坐席工号/" + loginUser.User_Exten;
            set_Text((object)this.Date_label);
            this.WindowState = FormWindowState.Maximized;
            showPermissions();
            this.FormClosing += new FormClosingEventHandler(this.Exit);
        }

        private void showPermissions()
        {
            foreach (string permission in loginUser.User_permissions)
            {
                switch (permission)
                {
                    case "001":
                        this.user_ManageMent.Visible = true;
                        break;
                    case "001001":
                        this.AllUsers.Visible = true;
                        this.AddUser.Visible = true;
                        break;
                    case "001002":
                        this.AddUser.Visible = true;
                        break;
                    case "001004":
                        this.AddUser.Visible = true;
                        break;
                    case "001006":
                        this.btitemPhoneParams.Visible = true;
                        break;
                    case "002":
                        this.RoleManagement.Visible = true;
                        break;
                    case "003":
                        this.Customer_Management.Visible = true;
                        break;
                    case "003001":
                        this.Import_CustomerInfo.Visible = true;
                        break;
                    case "003002":
                        this.Query_CustomerInfo.Visible = true;
                        break;
                    case "003003":
                        this.Add_CustomerInfo.Visible = true;
                        break;
                    case "004":
                        this.SaleLevelManagement.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void expandableSplitter2_Click(object sender, EventArgs e)
        {
            if (this.panel4.Visible)
                this.panel4.Visible = false;
            else
                this.panel4.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Time_label.Text = System.DateTime.Now.ToString("HH:mm:ss");
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            Set_MouseEnter(sender);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            Set_MouseLeave(sender);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否注销", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //Exit_Message_Notice("正在注销...");
                if (logout())
                {
                    this.Main_panel.Controls.Clear();
                    Application.DoEvents();
                    Thread.Sleep(50);
                    Main m = new Main();
                    m.Dock = DockStyle.Fill;
                    this.Main_panel.Controls.Add(m);
                    this.loginForm.Show();
                    this.FormClosing -= new FormClosingEventHandler(this.Exit);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户注销失败, 请联系系统管理员!");
                }
            }
            else
            {
                return;
            }
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            Set_MouseEnter(sender);
        }

        private void Set_MouseEnter(object sender)
        {
            ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
        }

        private void Set_MouseLeave(object sender)
        {
            ((Panel)sender).BorderStyle = BorderStyle.None;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            Set_MouseLeave(sender);
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            Set_MouseEnter(sender);
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            Set_MouseLeave(sender);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            Application.DoEvents();
            Thread.Sleep(50);
            Main m = new Main();
            m.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(m);
            App_Exit();
        }

        ///// <summary>
        ///// 设置信息条的信息
        ///// </summary>
        ///// <param name="str"></param>
        //private void Exit_Message_Notice(string str)
        //{
        //    Label L = new Label();
        //    L.Text = str;
        //    L.FlatStyle = FlatStyle.Flat;
        //    L.BackColor = Color.Transparent;
        //    L.ForeColor = Color.Red;
        //    L.Font = new Font(L.Font.FontFamily, 18, L.Font.Style);
        //    L.SetBounds(this.Main_panel.Location.X + this.Main_panel.Size.Width / 2 - L.Margin.Size.Width,
        //    this.Main_panel.Location.Y + this.Main_panel.Size.Height / 2 - L.Margin.Size.Height, L.Width + 200, L.Height + 10);
        //    this.Main_panel.Controls.Add(L);
        //    Application.DoEvents();
        //    Thread.Sleep(500);
        //    L.Text = L.Text.ToString() + ".";
        //    Application.DoEvents();
        //    Thread.Sleep(500);
        //    L.Text = L.Text = L.Text.ToString() + ".";
        //    Application.DoEvents();
        //    Thread.Sleep(500);
        //    this.Main_panel.Controls.Remove(L);
        //    Application.DoEvents();
        //}

        /// <summary>
        /// 关闭系统
        /// </summary>
        private void App_Exit()
        {
            if (DialogResult.Yes == MessageBox.Show("是否关闭系统", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //Exit_Message_Notice("正在关闭系统.");
                if (logout())
                {
                    ShutDown.App_Exit();
                }
                else
                {
                    MessageBox.Show("用户退出失败, 请联系系统管理员!");
                }
            }
            else
            {
                return;
            }
        }

        private void App_Return()
        {
            if (DialogResult.Yes == MessageBoxEx.Show("是否返回主界面", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //Exit_Message_Notice("正在返回系统主界面.");
                Application.DoEvents();
                Thread.Sleep(50);
                Main m = new Main();
                m.Dock = DockStyle.Fill;
                this.Main_panel.Controls.Add(m);
                ShutDown.Set_Panel_Message(this.Put_panel, this.Main_panel);
            }
            else
            {
                return;
            }
        }

       

        private void Main_panel_Click(object sender, EventArgs e)
        {
            App_Return();
        }

        private void set_Text(object sender)
        {
            string Datastr = null;
            int year, month, day;
            year = month = day = 0;
            year = System.DateTime.Today.Year;
            month = System.DateTime.Today.Month;
            day = System.DateTime.Today.Day;
            Datastr=ShutDown.CaculateWeekDay(year, month, day);
            ((LabelX)sender).Text = year.ToString() + "年" + month.ToString() + "月" + day.ToString() + "日  " + Datastr+" ";
        }

        //修改
        private void Import_CustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {   
                var resultFile=string.Empty;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "D:\\Patch";
                openFileDialog1.Filter = "Excel files (*.excel)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    resultFile = openFileDialog1.FileName;
                    Thread t = new Thread(CustomerInfo.Run);
                    t.Start(resultFile);
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //删除贵宾信息
        private void Add_CustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Main_panel.Controls.Clear();
                AddCustomer control = new AddCustomer();
                control.Dock = DockStyle.Left;
                this.Main_panel.Controls.Add(control);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }

        //添加贵宾信息
        private void Query_CustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Main_panel.Controls.Clear();
                Control_Customer control = new Control_Customer();
                control.Dock = DockStyle.Left;
                this.Main_panel.Controls.Add(control);
       
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(m);
            if (loginUser.User_Grade=="0")
            {
                this.sideBar1.Panels.Remove("user_ManageMent");
            }
        }

        private void btitemPhoneParams_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            PhoneParamSetting control = new PhoneParamSetting();
            control.Dock = DockStyle.Left;
            this.Main_panel.Controls.Add(control);
        }

        private void AllUsers_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.User.UserList userlist = new UIL.User.UserList(this);
            userlist.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(userlist);
        }

        private void singleUser_Click(object sender, EventArgs e)
        {
            addUserPanel("changePWD", loginUser.User_Id);
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            addUserPanel("update", loginUser.User_Id);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            addUserPanel("add", string.Empty);
        }

        public void addUserPanel(string panelName, string userId)
        {
            this.Main_panel.Controls.Clear();
            UIL.User.SingleUser singleUser = new UIL.User.SingleUser(panelName, userId);
            singleUser.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(singleUser);
        }

        public void addRolePanel(string panelName, string roleId)
        {
            this.Main_panel.Controls.Clear();
            UIL.Role.RoleDetail roleDetail = new UIL.Role.RoleDetail(panelName, roleId);
            roleDetail.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(roleDetail);
        }

        public void addLevelPanel(string panelName, string roleId)
        {
            this.Main_panel.Controls.Clear();
            UIL.SaleLevel.LevelDetail levelDetail = new UIL.SaleLevel.LevelDetail(panelName, roleId);
            levelDetail.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(levelDetail);
        }

        public void addGroupPanel(string panelName, string groupId, string groupName)
        {
            this.Main_panel.Controls.Clear();
            UIL.SaleGroup.GroupDetail groupDetail = new UIL.SaleGroup.GroupDetail(panelName, groupId, groupName);
            groupDetail.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(groupDetail);
        }

        private void AllRoles_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.Role.RoleList roleList = new UIL.Role.RoleList(this);
            roleList.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(roleList);
        }

        private void RoleDetail_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.Role.RoleDetail roleList = new UIL.Role.RoleDetail();
            roleList.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(roleList);
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            this.Main_panel.Controls.Clear();
            Application.DoEvents();
            Thread.Sleep(10);
            //Main m = new Main();
            //m.Dock = DockStyle.Fill;
            //this.Main_panel.Controls.Add(m);
            if (DialogResult.Yes == MessageBox.Show("是否关闭系统", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //Exit_Message_Notice("正在关闭系统.");
                if (logout())
                {
                    ShutDown.App_Exit();
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("用户退出失败, 请联系系统管理员!");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool logout()
        {
            if (!string.IsNullOrEmpty(loginUser.User_Id))
            {
                return CustomerSellerService.getService().LogoutUser(loginUser.User_Id);
            }

            return false;
        }

        private void LevelDetail_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.SaleLevel.LevelDetail levelDetail = new UIL.SaleLevel.LevelDetail();
            levelDetail.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(levelDetail);
        }

        private void AllLevels_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.SaleLevel.LevelList levelList = new UIL.SaleLevel.LevelList(this);
            levelList.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(levelList);
        }

        private void AllGroups_Click(object sender, EventArgs e)
        {
            this.Main_panel.Controls.Clear();
            UIL.SaleGroup.GroupList groupList = new UIL.SaleGroup.GroupList(this);
            groupList.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(groupList);
        }
    }
}
