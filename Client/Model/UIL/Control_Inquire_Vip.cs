using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using Model.DAL;

namespace Model
{
    public partial class Control_Inquire_Vip : UserControl
    {
        private string file_path = string.Empty;
        private string path = Application.StartupPath + @"\fruit";
        private string tb_Fruit_Path = string.Empty;
        private string tb_Fruit_Path_temp = string.Empty;
        private string id=string.Empty;

        public Control_Inquire_Vip()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }



        //设置信息
        private void set_Msg(DataTable dt)
        {
            try
            {
                if (dt == null)
                {
                    MessageBox.Show("信息不存在！", "提示");
                    setNUll();
                }
                   
                else
                {
                    this.tb_Fruit_Name.Text = dt.Rows[0]["frt_name"].ToString();
                    this.tb_fruit_OutPrice.Text = dt.Rows[0]["selling_Price"].ToString();
                    this.tb_Fruit_InPrice.Text = dt.Rows[0]["buying_Price"].ToString();
                    this.tb_Fruit_Remark.Text = dt.Rows[0]["remark"].ToString();
                    System.IO.FileStream fs = new System.IO.FileStream(dt.Rows[0]["pic_directory"].ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read); 
                    this.pb_fruit.Image = System.Drawing.Image.FromStream(fs); 
                    fs.Close();
                    file_path = dt.Rows[0]["pic_directory"].ToString();
                    id = dt.Rows[0]["frt_Id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //查询信息
        //private void bt_Inquire_Click(object sender, EventArgs e)
        //{
        //    if (this.cb_Condition.SelectedIndex == -1 || this.tb_Inquire.Text.Trim() == "")
        //    {
        //        MessageBox.Show("请选择查询条件，并输入值!", "提示", MessageBoxButtons.OK);
        //        return;

        //    }
        //    else
        //    {
        //        string execute_sql = "select * from fruit_info where " + get_Inquire_str();
        //        set_Msg(D_Customer.Query_Fruit(execute_sql));
        //    }

        //}


        //获取查询条件
        private string get_Inquire_str()
        {
            string str = null;
            if (this.cb_Condition.SelectedIndex == -1)
                str = "";
            else
                str = "frt_name='" + tb_Inquire.Text.Trim() + "'";
            return str;
        }


        //设置可编辑否
        public void setEdit(Boolean b)
        {
            this.tb_Fruit_Name.Enabled = b;
            this.tb_fruit_OutPrice.Enabled = b;
            this.tb_Fruit_InPrice.Enabled = b;
            this.tb_Fruit_Remark.Enabled = b;
            this.bt_inport.Enabled = b;

        }

        //设置为空
        public void setNUll()
        {
            this.tb_Fruit_Name.Text = "";
            this.tb_fruit_OutPrice.Text = "";
            this.tb_Fruit_InPrice.Text = "";
            this.tb_Fruit_Remark.Text = "";
            file_path = string.Empty;
            this.id = string.Empty;
            tb_Fruit_Path = string.Empty;
            tb_Fruit_Path_temp = string.Empty;
            this.pb_fruit.Image = null;
        }

        //设置bt_Update可见否
        public void Update_Visible(Boolean b)
        {
            this.bt_Update.Visible = b;
        }

        //设置bt_delete可见否
        public void Del_Visible(Boolean b)
        {
            this.bt_delete.Visible = b;

        }

        //更新贵宾信息
        private void bt_Update_Click(object sender, EventArgs e)
        {
            string condition="";
            try
            {
                if (this.cb_Condition.SelectedIndex == -1 || this.tb_Inquire.Text.Trim() == "")
                {
                    MessageBox.Show("更新条件不可为空!", "提示", MessageBoxButtons.OK);
                    return;

                }
                else
                {
                    if (tb_Fruit_Path_temp!=string.Empty)
                    {
                        File.Delete(file_path);
                        tb_Fruit_Path = path + @"\" + System.DateTime.Now.ToString("YYYY-MM-DD-HH-mm-SS") + tb_Fruit_Path_temp.Substring(tb_Fruit_Path_temp.IndexOf('.'));
                        File.Copy(tb_Fruit_Path_temp, tb_Fruit_Path);
                        condition = " , pic_directory='"+tb_Fruit_Path+"' ";
                    }

                    string execute_sql = "update fruit_info set frt_name='" + this.tb_Fruit_Name.Text.Trim() + "',  selling_Price=" + this.tb_fruit_OutPrice.Text.Trim() +
                        ",buying_Price=" + this.tb_Fruit_InPrice.Text.Trim() + ",remark='" + this.tb_Fruit_Remark.Text.Trim() +
                        "'" + condition + " where frt_Id=" + id;

                    if (D_Customer.Execute_Fruit(execute_sql))
                        MessageBox.Show("信息更新成功!", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //删除贵宾信息
        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cb_Condition.SelectedIndex == -1 || this.tb_Inquire.Text.Trim() == "")
                {
                    MessageBox.Show("请选择查询条件，并输入值!", "提示", MessageBoxButtons.OK);
                    return;

                }
                else
                {

                    string execute_sql = "delete from fruit_info where " + get_Inquire_str();
                    if (D_Customer.Execute_Fruit(execute_sql))
                    {
                        if (File.Exists(file_path))
                            File.Delete(file_path);
                        MessageBox.Show("信息删除成功!", "提示");
                        setNUll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "导入水果图片";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (DialogResult.OK == f.ShowDialog())
            {
                if (f.FileName.Trim() == "")
                {
                    MessageBox.Show("请选择该水果的样图");
                }
                else
                {
                    tb_Fruit_Path_temp = f.FileName;
                    System.IO.FileStream fs = new System.IO.FileStream(tb_Fruit_Path_temp, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    this.pb_fruit.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();               
                }
            }
           
        }



    }
}
