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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_ris_username.Text;
            string password = textBox_ris_password.Text;
            string repassword = textBox_ris_repassword.Text;

            if (password != repassword)
            {
                MessageBox.Show("请再次输入相同的密码！");
            }
            else
            {
                builder.UserID = "root";
                builder.Password = "123456";
                builder.Server = "localhost";
                builder.Database = "student_management";
                connection = new MySqlConnection(builder.ConnectionString);
                connection.Open();

                string str0 = "select count(*) from login_stu_information where Sno = '" + username + "' group by Sno;";
                //MySqlCommand cmd0 = new MySqlCommand(str0, connection);
                //if ((int)cmd0.ExecuteScalar() > 1)
                //{
                //    MessageBox.Show("用户名已存在！");
                //}
                string sql = "insert into login_stu_information (Sno,password) values ('" + username + "','" + password + "')";
                //MySqlCommand cmd0 = new MySqlCommand(str0, connection);
                //MySqlConnection con = new MySqlConnection(str0);
                MySqlCommand cmd1 = new MySqlCommand(str0, connection);
                if (Convert.ToInt32(cmd1.ExecuteScalar()) >= 1)
                {
                    connection.Close();
                    MessageBox.Show("用户名已存在！");
                    this.Visible = true;
                }
                else
                {
                    //MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();//插入或者删除
                    MessageBox.Show("注册成功！");
                    connection.Close();
                    this.Visible = false;
                    new Login().Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Visible = true;
        }
    }
}
