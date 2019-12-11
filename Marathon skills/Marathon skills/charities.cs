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
    public partial class charities : Form
    {
        public charities()
        {
            InitializeComponent();
        }

        private void charities_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlCommand cmd;
            SqlConnection con;
            connetionString = ("Data Source=127.0.0.1;Initial Catalog=gr464_Dmitriev;User ID=student;Password=student");
            con = new SqlConnection(connetionString);
            con.Open();
            cmd = new SqlCommand("Select [CharityName],[CharityDescription],[CharityLogo] from Charity", con);
            SqlDataReader rdr=cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                UserControl1 ctl = new UserControl1();
                string img = "C:\\Users\\user05\\Desktop\\464 dmitriev\\programma\\marathon-skills-2016-charity-data\\" + rdr["CharityLogo"].ToString();
                ctl.pict_chr.Image = Image.FromFile(img);
                ctl.name_chr.Text = rdr["CharityName"].ToString();
                ctl.descr_chr.Text = rdr["CharityDescription"].ToString();
                flowLayoutPanel1.Controls.Add(ctl.pict_chr);
                flowLayoutPanel1.Controls.Add(ctl.name_chr);
                flowLayoutPanel1.Controls.Add(ctl.descr_chr);
            }

        }

        private void btn_bck_charity_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }



    }
}
