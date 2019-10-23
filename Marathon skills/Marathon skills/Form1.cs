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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        
        private void btn_sponsor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sponsor spons = new Sponsor();
            spons.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t1 = Program.start - DateTime.Now;
            tmr1.Text = t1.Days.ToString() + " days, " + t1.Hours.ToString() + " hours, " + t1.Minutes.ToString() + " minutes";
        }

        private void btn_inform_Click(object sender, EventArgs e)
        {
            this.Hide();
            informwin inf = new informwin();
            inf.Show();
        }


    }
}
