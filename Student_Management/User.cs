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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Sage_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {


            ChangeFormSize();//设置变化窗体大小
        }

        private void User_Resize(object sender, EventArgs e)
        {
            float WidthChangeProportion = (this.Width) / CurrentWidth;//宽度变化比例
            float HeightChangeProportion = (this.Height) / CurrentHeight;//高度变化比例
            UpdateControlsSize(WidthChangeProportion, HeightChangeProportion, this);
        }


        /// <summary>
        /// 当前窗体宽度
        /// </summary>
        private float CurrentWidth { get; set; }
        /// <summary>
        /// 当前窗体高度
        /// </summary>
        private float CurrentHeight { get; set; }
        /// <summary>
        /// 改变窗体大小
        /// </summary>
        private void ChangeFormSize()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲DoubleBuffer
            CurrentWidth = this.Width;
            CurrentHeight = this.Height;
            SetControTag(this);
        }

        /// <summary>
        /// 设置控件 Tag 数据
        /// </summary>
        /// <param name="cons"></param>
        private void SetControTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    SetControTag(con);
                }
            }
        }
        /// <summary>
        /// 设置控件双缓冲区
        /// </summary>
        /// <param name="cc"></param>
        public static void SetControlDoubleBuffer(Control cc)
        {

            cc.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
                         System.Reflection.BindingFlags.NonPublic).SetValue(cc, true, null);

        }
        /// <summary>
        /// 更新控件的大小
        /// </summary>
        /// <param name="WidthChangeProportion"></param>
        /// <param name="HeightChangeProportion"></param>
        /// <param name="cons"></param>
        private void UpdateControlsSize(float WidthChangeProportion, float HeightChangeProportion, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                SetControlDoubleBuffer(this);
                SetControlDoubleBuffer(con);
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * WidthChangeProportion);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * HeightChangeProportion);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * WidthChangeProportion);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * HeightChangeProportion);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * HeightChangeProportion;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        UpdateControlsSize(HeightChangeProportion, HeightChangeProportion, con);
                    }
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

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



        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            GetData();
            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                //打开数据库连接
                connection.Open();


                string sql = "select * from add_stu_inf;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                while (reader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();

                    this.dataGridView1.Rows[index].Cells[0].Value = reader.GetString("Sno");
                    this.dataGridView1.Rows[index].Cells[1].Value = reader.GetString("Sname");
                    this.dataGridView1.Rows[index].Cells[2].Value = reader.GetString("Gender");
                    this.dataGridView1.Rows[index].Cells[3].Value = reader.GetInt32("Age");
                    this.dataGridView1.Rows[index].Cells[4].Value = reader.GetString("Nation");
                    this.dataGridView1.Rows[index].Cells[5].Value = reader.GetString("Birth");
                    this.dataGridView1.Rows[index].Cells[6].Value = reader.GetString("Polic_Face");
                    this.dataGridView1.Rows[index].Cells[7].Value = reader.GetString("Contance");
                    this.dataGridView1.Rows[index].Cells[8].Value = reader.GetString("Native");
                    this.dataGridView1.Rows[index].Cells[9].Value = reader.GetString("Now_Adress");
                    this.dataGridView1.Rows[index].Cells[10].Value = reader.GetString("Origin");
                    this.dataGridView1.Rows[index].Cells[11].Value = reader.GetString("Luqu_Orifin");
                    this.dataGridView1.Rows[index].Cells[12].Value = reader.GetString("MotherHighSchool");
                    this.dataGridView1.Rows[index].Cells[13].Value = reader.GetString("EntryDate");
                    this.dataGridView1.Rows[index].Cells[14].Value = reader.GetString("XuejiStatus");
                    this.dataGridView1.Rows[index].Cells[15].Value = reader.GetString("NowGrade");
                    this.dataGridView1.Rows[index].Cells[16].Value = reader.GetString("Professyuan");
                    this.dataGridView1.Rows[index].Cells[17].Value = reader.GetString("ProfessClass");
                    this.dataGridView1.Rows[index].Cells[18].Value = reader.GetString("Work_Experiments");
                    this.dataGridView1.Rows[index].Cells[19].Value = reader.GetString("Honor_Experiments");
                    this.dataGridView1.Rows[index].Cells[20].Value = reader.GetString("Punishments");
                    this.dataGridView1.Rows[index].Cells[21].Value = reader.GetString("Social_Experiments");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string Sname = textBox_Sname.Text;
            string Sno = textBox_Sno.Text;
            string Gender = Convert.ToString(comboBox_Gender.SelectedItem);
            int Age = int.Parse(textBox_Sage.Text);
            string Nation = Convert.ToString(comboBox_Nation.SelectedItem);
            string Birth = textBox_Sbirth.Text;
            string Polic_Face = Convert.ToString(comboBox_PolticsStatues.SelectedItem);
            string Contance = textBox_SphoneNum.Text;
            string Native = textBox_Native.Text;
            string Now_Adress = textBox_NowAdress.Text;
            string Origin = Convert.ToString(comboBox_Origin.SelectedItem);
            string Luqu_Orifin = Convert.ToString(comboBox_LuquOrifin.SelectedItem);
            string MotherHighSchool = textBox_motherschool.Text;
            string EntryDate = textBox_entrydate.Text;
            string XuejiStatus = Convert.ToString(comboBox_XuejiStatus.SelectedItem);
            string NowGrade = Convert.ToString(comboBox_NowGrade.SelectedItem);
            string Professyuan = Convert.ToString(comboBox_Professyuan.SelectedItem);
            string ProfessClass = textBox_academy.Text;
            string Work_Experiments = richTextBox_WorkExperiment.Text;
            string Honor_Expeiments = richTextBox_HonorExperiment.Text;
            string Punishments = richTextBox_PunishExperiment.Text;
            string Social_Experiments = richTextBox_SocialExperiments.Text;

            GetData();
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            string sql = "insert into add_stu_inf (Sno, Sname, Gender, Age, Nation, Birth,Polic_Face, Contance, Native, Now_Adress, Origin, Luqu_Orifin," +
                " MotherHighSchool, EntryDate, XuejiStatus, NowGrade, Professyuan, ProfessClass,Work_Experiments,Honor_Experiments,Punishments,Social_Experiments) " +
                " values('" + Sno + "','" + Sname + "','" + Gender + "'," + Age + ",'" + Nation + "','" + Birth + "','" + Polic_Face + "','" + Contance + "','" + Native + "','"
                + Now_Adress + "','" + Origin + "','" + Luqu_Orifin + "','" + MotherHighSchool + "','" + EntryDate
                + "','" + XuejiStatus + "','" + NowGrade + "','" + Professyuan + "','" + ProfessClass + "','" + Work_Experiments
                + "','" + Honor_Expeiments + "','" + Punishments + "','" + Social_Experiments + "');";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功！");
            connection.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SearchInf().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Delete().Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search search = new Search();
            search.ShowDialog();

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Visible = true;
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Daoru.PerformClick();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Back.PerformClick();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            button_Daoru.PerformClick();
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Content1().ShowDialog();
        }

        private void 帮助LToolStripButton_Click(object sender, EventArgs e)
        {
            AssiHToolStripMenuItem.Visible = true;
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
