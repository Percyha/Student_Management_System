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
    public partial class StuLogin : Form
    {
        public StuLogin()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*new Login().*/
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                //打开数据库连接
                connection.Open();

                string username = textBox_Id.Text;
                string password = textBox_Password.Text;
                string sql = "select ID,password from login_Stu_Select where ID = '" + username + "' and password = '" + password + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                if (reader.HasRows)
                {
                    MessageBox.Show("登录成功！");
                    this.Visible = false;
                    SelectCourse sc = new SelectCourse();
                    sc.Id = textBox_Id.Text;
                    sc.Visible = true;
                    //MessageBox.Show("数据库已经连接了！");
                }
                else
                {
                    MessageBox.Show("账号或密码错误或未注册");
                }
                //connection.Close();//关闭通道
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
