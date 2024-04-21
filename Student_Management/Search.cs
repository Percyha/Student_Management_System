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

namespace Student_Management
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;

        private void button1_Click(object sender, EventArgs e)
        {
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Server = "localhost";
            builder.Database = "student_management";
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                //打开数据库连接
                connection.Open();

                string Stusno = textBox_SearchGrade.Text;
                string sql = "select _No from add_stu_grade where _No = '" + Stusno + "';";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                if (reader.HasRows)
                {
                    this.Visible = false;
                    StuGrade sg = new StuGrade();
                    sg.Sno = textBox_SearchGrade.Text;
                    sg.Visible = true;
                }
                else
                {
                    MessageBox.Show("暂无此学生信息！");
                }
                connection.Close();//关闭通道
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new User().Visible = true;
        }
    }
}
