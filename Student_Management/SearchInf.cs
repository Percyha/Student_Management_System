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
    public partial class SearchInf : Form
    {
        public SearchInf()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new User().Visible = true;
        }

        private void button_SearchInf_Click(object sender, EventArgs e)
        {
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);
            User user = new User();

            try
            {
                connection.Open();

                string sql = "select * from add_stu_inf where Sno = '" + textBox_Sno.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询

                while (reader.Read())
                {
                    user.textBox_Sno.Text = reader.GetString("Sno");
                    user.textBox_Sno.Enabled = false;
                    user.textBox_Sname.Text = reader.GetString("Sname");
                    user.textBox_Sname.Enabled = false;
                    user.comboBox_Gender.Text = reader.GetString("Gender");
                    user.comboBox_Gender.Enabled = false;
                    user.textBox_Sage.Text = reader.GetString("Age");
                    user.textBox_Sage.Enabled = false;
                    user.comboBox_Nation.Text = reader.GetString("Nation");
                    user.comboBox_Nation.Enabled = false;
                    user.textBox_Sbirth.Text = reader.GetString("Birth");
                    user.textBox_Sbirth.Enabled = false;
                    user.comboBox_PolticsStatues.Text = reader.GetString("Polic_Face");
                    user.comboBox_PolticsStatues.Enabled = false;
                    user.textBox_SphoneNum.Text = reader.GetString("Contance");
                    user.textBox_SphoneNum.Enabled = false;
                    user.textBox_Native.Text = reader.GetString("Native");
                    user.textBox_Native.Enabled = false;
                    user.textBox_NowAdress.Text = reader.GetString("Now_Adress");
                    user.textBox_NowAdress.Enabled = false;
                    user.comboBox_Origin.Text = reader.GetString("Origin");
                    user.comboBox_Origin.Enabled = false;
                    user.comboBox_LuquOrifin.Text = reader.GetString("Luqu_Orifin");
                    user.comboBox_LuquOrifin.Enabled = false;
                    user.textBox_motherschool.Text = reader.GetString("MotherHighSchool");
                    user.textBox_motherschool.Enabled = false;
                    user.textBox_entrydate.Text = reader.GetString("EntryDate");
                    user.textBox_entrydate.Enabled = false;
                    user.comboBox_XuejiStatus.Text = reader.GetString("XuejiStatus");
                    user.comboBox_XuejiStatus.Enabled = false;
                    user.comboBox_NowGrade.Text = reader.GetString("NowGrade");
                    user.comboBox_NowGrade.Enabled = false;
                    user.comboBox_Professyuan.Text = reader.GetString("Professyuan");
                    user.comboBox_Professyuan.Enabled = false;
                    user.textBox_academy.Text = reader.GetString("ProfessClass");
                    user.textBox_academy.Enabled = false;
                    user.richTextBox_WorkExperiment.Text = reader.GetString("Work_Experiments");
                    user.richTextBox_WorkExperiment.Enabled = false;
                    user.richTextBox_HonorExperiment.Text = reader.GetString("Honor_Experiments");
                    user.richTextBox_HonorExperiment.Enabled = false;
                    user.richTextBox_PunishExperiment.Text = reader.GetString("Punishments");
                    user.richTextBox_PunishExperiment.Enabled = false;
                    user.richTextBox_SocialExperiments.Text = reader.GetString("Social_Experiments");
                    user.richTextBox_SocialExperiments.Enabled = false;
                }
                reader.Close();
                this.Visible = false;
                user.Visible = true;
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new User().Visible = true;
        }
    }
}
