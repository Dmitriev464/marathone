﻿using System;
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

        private void fulmar_chk_CheckedChanged(object sender, EventArgs e)
        {
            int f= 145;
            int h=75;
            int m = 20;
            int va=0;
            int vb=20;
            int vc=45;


            label8.Text = "$" + (f + h + m + va + vb + vc);

        }

       
       
    }
}