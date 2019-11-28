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
            if (fulmar_chk.Checked == true)
            {
                label8.Text = "$" + 145;
            }
            else { label8.Text=}

        }

       
       
    }
}
