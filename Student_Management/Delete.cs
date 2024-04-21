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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReDelete re = new ReDelete();
            re.No = textBox_Sno.Text;
            re.ShowDialog();
            this.Visible = false;
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new User().Visible = true;
        }

        private void textBox_Sno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
