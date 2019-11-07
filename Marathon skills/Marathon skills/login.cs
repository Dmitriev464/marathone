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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            string mail, pass, role;
            string connetionString = null;
            SqlCommand cmd;
            SqlConnection con;
            connetionString = ("Data Source=127.0.0.1;Initial Catalog=gr464_Dmitriev;User ID=student;Password=student");
            con = new SqlConnection(connetionString);
            con.Open();
            cmd = new SqlCommand("SELECT [Email], [Password], [RoleId] FROM [User] where [Email]='"+emailtxt.Text+"'AND [Password]= '"+passwordtxt.Text+"'", con);
            SqlDataReader rdr=cmd.ExecuteReader();

            while (rdr.Read())
            {
                mail = rdr.GetString(0);
                pass= rdr.GetString(1);
                role = rdr.GetString(2);
                switch (role)
                {
                    case "A": Admin adm = new Admin();
                        adm.Show();
                        this.Close();
                        break;
                    case "C": Coordinator coor = new Coordinator();
                        coor.Show();
                        this.Close();
                        break;
                    case "R": Runner runn = new Runner();
                        runn.Show();
                        this.Close();
                        break;
                } 
            }
        }

        private void btn_bck_inform_Click(object sender, EventArgs e)
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
