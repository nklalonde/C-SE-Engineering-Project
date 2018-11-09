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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Whole tab object
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // 1st tab
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // Remove tabs
            Admin_Tab_Control.TabPages.Remove(Admin_Tab_Control.SelectedTab); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
               // Revmove all tab pages
            Admin_Tab_Control.TabPages.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tpage = new TabPage();
            Admin_Tab_Control.TabPages.Add(tpage);
            // can assign name of tab pages here
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_A_Log_Out_Click(object sender, EventArgs e)
        {
            // Return to Login Screen
            this.Hide();
            Login_Window lw = new Login_Window(); 
            lw.Show();
        }

        private void Add_Course_Button_Click(object sender, EventArgs e)
        {
            string cname = Txt_Course.Text;
            Cmb_Courses.Items.Add(cname);
        }

        private void txt_Course_TextChanged(object sender, EventArgs e)
        {
            // text box for course name
        }

        private void txt_Course_ID_TextChanged(object sender, EventArgs e)
        {
            // text box for course ID
        }

        private void txt_Course_Num_TextChanged(object sender, EventArgs e)
        {
            // Text box for course number
        }

        private void txt_Professor_TextChanged(object sender, EventArgs e)
        {
            // Text box for professor
        }

        private void cb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For listing currently entered courses and selecting for
           // updaing and deleting
        }

        private void Professors_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Mode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Students_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }
    }
}
