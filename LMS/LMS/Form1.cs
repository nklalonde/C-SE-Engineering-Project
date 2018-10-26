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
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
        }
        // Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Log in button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void Password_Label_Click(object sender, EventArgs e)
        {

        }

        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
