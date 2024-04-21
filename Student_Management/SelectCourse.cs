using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management
{
    public partial class SelectCourse : Form
    {
        public SelectCourse()
        {
            InitializeComponent();
        }

        private void listView_ShowCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.listView_ShowCourse.ContextMenuStrip = this.contextMenuStrip1;
            //contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);

        }

        private void listView_ShowCourse_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void listView_ShowCourse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = listView_ShowCourse.HitTest(e.X, e.Y);

                if (hitTestInfo.Item != null)
                {
                    var loc = e.Location;
                    loc.Offset(listView_ShowCourse.Location);

                    // Adjust context menu (or it's contents) based on hitTestInfo details
                    if (falg)
                    {
                        this.contextMenuStri_LvQuickClick.Show(this, loc);
                    }
                    else
                    {
                        this.contextMenuStrip_LtQuickClick.Show(this, loc);
                    }
                }
            }

        }

        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;

        public void GetData()
        {
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Server = "localhost";
            builder.Database = "student_management";
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.listView_ShowCourse.Items.Clear();
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                string sql = "select * from Course;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询

                while (reader.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = reader["Ccode"].ToString();
                    lt.SubItems.Add(reader["Cno"].ToString());
                    lt.SubItems.Add(reader["Cname"].ToString());
                    lt.SubItems.Add(reader["Cdept"].ToString());
                    lt.SubItems.Add(reader["Cteacher"].ToString());
                    lt.SubItems.Add(reader["Ccredit"].ToString());
                    lt.SubItems.Add(reader["Cper"].ToString());
                    //将lt数据添加到listView1控件中
                    listView_ShowCourse.Items.Add(lt);
                }
                MessageBox.Show("查询成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_AlCourse_Click(object sender, EventArgs e)
        {
            this.listView_ShowCourse.Items.Clear();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                string sql = "select Course.* from sc,course where Sno = '" + _id + "' and SC.Cno = Course.Cno;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询

                while (reader.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = reader["Ccode"].ToString();
                    lt.SubItems.Add(reader["Cno"].ToString());
                    lt.SubItems.Add(reader["Cname"].ToString());
                    lt.SubItems.Add(reader["Cdept"].ToString());
                    lt.SubItems.Add(reader["Cteacher"].ToString());
                    lt.SubItems.Add(reader["Ccredit"].ToString());
                    lt.SubItems.Add(reader["Cper"].ToString());
                    //将lt数据添加到listView1控件中
                    listView_ShowCourse.Items.Add(lt);
                }
                MessageBox.Show("查询成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string _id;
        public string Id { get { return _id; } set { _id = value; } }

        private void button_Add_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                int ipos = listView_ShowCourse.Items.IndexOf(listView_ShowCourse.FocusedItem);
                string sql = "insert into sc (Sno,Cno) values ('" + _id + "','" + listView_ShowCourse.Items[ipos].SubItems[1].Text + "');";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void 添加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Add.PerformClick();
        }

        private void button_Add_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();

                int ipos = listView_ShowCourse.Items.IndexOf(listView_ShowCourse.FocusedItem);

                string sql = "delete from sc where Sno = '" + _id + "' and Cno = '" + listView_ShowCourse.Items[ipos].SubItems[1].Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void 删除CToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            button_Cancle.PerformClick();
        }

        private void 查询SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_SearchDetails.PerformClick();
        }

        private void 删除CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_SearchDetails.PerformClick();
        }

        private void button_SearchDetails_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                int ipos = listView_ShowCourse.Items.IndexOf(listView_ShowCourse.FocusedItem);
                string sql = "select Course.Cname,Course.Ccredit, Course.Cteacher,Course.Cdept,specific_Course.Difficult,specific_Course.Score,specific_Course.Year from specific_Course,course " +
                    "where Course.Cno = '" + listView_ShowCourse.Items[ipos].SubItems[1].Text + "' and  specific_Course.Cno = '" + listView_ShowCourse.Items[ipos].SubItems[1].Text + "';";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询

                while (reader.Read())
                {
                    textBox_Cname.Text = reader["Cname"].ToString();
                    textBox_Cname.Enabled = false;
                    textBox_Tea.Text = reader["Cteacher"].ToString();
                    textBox_Tea.Enabled = false;
                    textBox_Dept.Text = reader["Cdept"].ToString();
                    textBox_Dept.Enabled = false;
                    textBox_Cre.Text = reader["Ccredit"].ToString();
                    textBox_Cre.Enabled = false;
                    textBox_Just.Text = reader["Score"].ToString();
                    textBox_Just.Enabled = false;
                    textBox_Diff.Text = reader["Difficult"].ToString();
                    textBox_Diff.Enabled = false;
                    textBox_Year.Text = reader["Year"].ToString();
                    textBox_Year.Enabled = false;
                }
                MessageBox.Show("查询成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void contextMenuStri_LvQuickClick_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 返回上一级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new DataBaseType().Visible = true;
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        bool falg = false;
        private void button_Search_MouseClick(object sender, MouseEventArgs e)
        {
            falg = true;
        }

        private void button_AlCourse_MouseClick(object sender, MouseEventArgs e)
        {
            falg = false;
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Content1().ShowDialog();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
