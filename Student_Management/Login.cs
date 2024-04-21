using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button_login_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                //打开数据库连接
                connection.Open();

                string username = textBox_username.Text;
                string password = textBox_password.Text;
                string sql = "select sno,password from login_stu_information where sno = '" + username + "' and password = '" + password + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                if (reader.HasRows)
                {
                    MessageBox.Show("登录成功！");
                    User user = new User();
                    this.Visible = false;
                    user.ShowDialog();
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register ris = new Register();
            ris.ShowDialog();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_register.PerformClick();//实现“注册”控件的功能
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_exit.PerformClick();//实现“退出”控件的功能
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            content.ShowDialog();
        }

        private void 数据库支持ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataExplain dataExplain = new DataExplain();
            dataExplain.ShowDialog();
        }

        private void 使用说明UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseExplain useExplain = new UseExplain();
            useExplain.ShowDialog();
        }
    }
}
