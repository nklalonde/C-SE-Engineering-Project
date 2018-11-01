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
            tabControl1.TabPages.Remove(tabControl1.SelectedTab); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
               // Revmove all tab pages
            tabControl1.TabPages.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tpage = new TabPage();
            tabControl1.TabPages.Add(tpage);
            // can assign name of tab pages here
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
