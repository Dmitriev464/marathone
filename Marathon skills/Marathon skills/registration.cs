using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_skills
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gr464_DmitrievDataSet3.charv' table. You can move, or remove it, as needed.
            this.charvTableAdapter.Fill(this.gr464_DmitrievDataSet3.charv);

           

        }
        int f = 145;
        int h = 75;
        int m = 20;
        int va = 0;
        int vb = 20;
        int vc = 45;
        int rez = 0;
        public string charname = "";


        private void fulmar_chk_CheckedChanged(object sender, EventArgs e)
        {


            if (fulmar_chk.Checked == true)
            {
                

               
                rez += f;
                label8.Text = rez.ToString();
            }
            else {
              
                rez -= f;
                label8.Text = rez.ToString();
            }
        }

        private void halfmar_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (halfmar_chk.Checked == true)
            {
              
                rez += h;
                label8.Text = rez.ToString();
            }
            else
            {
               
                rez -= h;
                label8.Text = rez.ToString();
            }
        }

        private void minmar_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (minmar_chk.Checked == true)
            {

                rez += m;
                label8.Text = rez.ToString();
            }
            else
            {

                rez -= m;
                label8.Text = rez.ToString();
            }
        }

        private void vara_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (vara_rad.Checked == true)
            {

                rez += va;
                label8.Text = rez.ToString();
            }
            else
            {

                rez -= va;
                label8.Text = rez.ToString();
            }
        }

        private void varb_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (varb_rad.Checked == true)
            {

                rez += vb;
                label8.Text = rez.ToString();
            }
            else
            {

                rez -= vb;
                label8.Text = rez.ToString();
            }
        }

        private void varc_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (varc_rad.Checked == true)
            {

                rez += vc;
                label8.Text = rez.ToString();
            }
            else
            {

                rez -= vc;
                label8.Text = rez.ToString();
            }
        }

        private void info_redcross_Click(object sender, EventArgs e)
        {
            charities2 ch = new charities2();
            ch.Show();
        }

        private void chr_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            charities2 ch = new charities2();
            charname = chr_cmb.Text;
        }

       
       
    }
}
