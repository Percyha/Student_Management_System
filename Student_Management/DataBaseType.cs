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
    public partial class DataBaseType : Form
    {
        public DataBaseType()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iPos = comboBox_choseIdenty.SelectedIndex;
            if (iPos == 0)
            {
                this.Visible = false;
                Login login = new Login();
                login.ShowDialog();
            }
            else if (iPos == 1)
            {
                this.Visible = false;
                new StuLogin().Visible = true;
            }
        }
    }
}
