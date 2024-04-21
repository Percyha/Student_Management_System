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

namespace Student_Management
{
    public partial class StuGrade : Form
    {
        public StuGrade()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;

        private string _sno;
        public string Sno { get { return _sno; } set { _sno = value; } }

        private void button_stugradeSerch_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Server = "localhost";
            builder.Database = "student_management";
            connection = new MySqlConnection(builder.ConnectionString);

            string sql0 = "select distinct s1.Sname from add_stu_grade s0,add_stu_inf s1 where s0._No = '" + _sno + "'" + " and s1.Sno = s0._No ;";

            //打开数据库连接
            connection.Open();
            MySqlCommand cmd0 = new MySqlCommand(sql0, connection);
            MySqlDataReader reader0 = cmd0.ExecuteReader();//执行查询
            reader0.Read();
            textBox_Name.Text = reader0["Sname"].ToString();
            connection.Close();

            try
            {
                //打开数据库连接
                connection.Open();
                string a = _sno;
                string b = Convert.ToString(comboBox_Terminfomation.SelectedItem);
                string sql = "select * from add_stu_grade where _No = '" + _sno + "' and  Term = '" + Convert.ToString(comboBox_Terminfomation.SelectedItem) + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                while (reader.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = reader["_No"].ToString();
                    lt.SubItems.Add(reader["Pno"].ToString());
                    lt.SubItems.Add(reader["Cname"].ToString());
                    lt.SubItems.Add(reader["Cxingzhi"].ToString());
                    lt.SubItems.Add(reader["Ccrdict"].ToString());
                    lt.SubItems.Add(reader["Term"].ToString());
                    lt.SubItems.Add(reader["Grade"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Search().Visible = true;
        }

        private void comboBox_Terminfomation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
