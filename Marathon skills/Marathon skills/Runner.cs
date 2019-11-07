using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_skills
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            if (Program.start > DateTime.Now) tmr4.Text = t.Days.ToString() + " days, " + t.Hours.ToString() + " hours, " + t.Minutes.ToString() + " minutes";

        }
    }
}
