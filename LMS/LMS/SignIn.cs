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
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Exit Button, closes the program 
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Whole form 
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 

            /* Log in button, need to check username & password, 
              send to the correct view. Probably a if/ case statement*/
            this.Hide();    // hides sign in sheet
            //if (Username_Textbox == aname && Password_Textbox == 123)
            //{
                AdminView aa = new AdminView(); // link to professor view
                aa.Show();  // show administrator view 
            //}
            /*else if (Username_Label == sname && Password_Textbox == 123)
            {
                StudentView ss = new StudentView(); // link to student view
                ss.Show();  // show professor view
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {
            // User name label
        }

        private void Password_Label_Click(object sender, EventArgs e)
        {
            // Password label
        }

        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {
            // input username here
        }

        private void Password_Textbox_TextChanged(object sender, EventArgs e)
        {
            // input password here
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Red place holder for image
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // "Login" in image
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // This is the gator image
        }
    }
}
