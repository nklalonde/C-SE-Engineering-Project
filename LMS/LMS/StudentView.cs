using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_A_Log_Out_Click(object sender, EventArgs e)
        {
            // Return to Login Screen
            this.Hide();
            Login_Window lw = new Login_Window();
            lw.Show();
        }

        private void Txt_C4_SName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_C4_Grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_C3_SName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_C3_Grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
