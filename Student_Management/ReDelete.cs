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
    public partial class ReDelete : Form
    {
        public ReDelete()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Delete().Visible = true;
        }

        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;

        private void GetData()
        {
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Server = "localhost";
            builder.Database = "student_management";
        }

        private string _no;
        public string No { get { return _no; } set { _no = value; } }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();

                string no = _no;

                string sql = "delete from add_stu_inf where Sno = '" + no + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
                connection.Close();

                this.Visible = false;
                new User().Visible = true;
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
    }
}
