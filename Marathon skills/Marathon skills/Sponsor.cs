using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marathon_skills
{

    public partial class Sponsor : Form
    { 
       
        public Sponsor()
        {
            InitializeComponent();
          

        }
        
        private void btn_bck_spons_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            if (Program.start > DateTime.Now) tmr2.Text = t.Days.ToString() + " days, " + t.Hours.ToString() + " hours, " + t.Minutes.ToString() + " minutes";
        }

        private void Sponsor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gr464_DmitrievDataSet.forspons' table. You can move, or remove it, as needed.
            this.forsponsTableAdapter.Fill(this.gr464_DmitrievDataSet.forspons);
            spons_name.Text = "Имя спонсора";
            spons_name.ForeColor = Color.Gray;
            vladcard.Text = "NAME LASTNAME";
            vladcard.ForeColor = Color.Gray;
        }

        private void mns_poz_Click(object sender, EventArgs e)
        {

            int a = int.Parse(summ_poz.Text);
            if(a!=0)
            summ_poz.Text = (a - 10).ToString();
        }
        
        private void pls_poz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(summ_poz.Text))
            {
                summ_poz.Text = 10.ToString();
            }
            int a = int.Parse(summ_poz.Text);
            summ_poz.Text = (a + 10).ToString();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
     
            if (string.IsNullOrEmpty(spons_name.Text) || string.IsNullOrEmpty(vladcard.Text))
            {
                MessageBox.Show("Не введены имя спонсора или владелец карты");
            }
            else
                
            {
                int n = 0;
                for (int i = 0; i < msk_card.Text.Length; i++)
                    if (msk_card.Text[i] == ' ') n++;
                MessageBox.Show("Длина введенных данных карты " + msk_card.Text.Length.ToString() + ", количество пробелов " + n.ToString());
                string str = msk_card.Text;
                str = str.Replace(" ", "");
                str = str.Replace(" ", "");
                str = str.Replace(" ", "");
                MessageBox.Show(str);
            }

            DateTime tm = DateTime.Now;
            if (string.IsNullOrEmpty(msk_cvc.Text)|| msk_cvc.TextLength ==3  || string.IsNullOrEmpty(msk_card.Text))
            {
                MessageBox.Show("Введите CVC и номер карты");
            }
            else
            if (string.IsNullOrEmpty(msk_year.Text)||string.IsNullOrEmpty(msk_month.Text))
                MessageBox.Show("Введите месяц и год");
            else
            {
                int yr = int.Parse(msk_year.Text);

                int m = int.Parse(msk_month.Text);


                bool invd = false;
                if (tm.Year <= yr)
                {
                    if (tm.Year == yr)
                    {
                        if (tm.Month < m)
                            invd = true;
                    }
                    else
                        invd = true;
                }


                MessageBox.Show(invd.ToString());
                if (invd == false)
                {
                    MessageBox.Show("Карта не действительна, используйте действительную карту");
                }
                else
                {
                    string connetionString = null;
                    SqlCommand cmd;
                    SqlConnection con;
                    connetionString = ("Data Source=127.0.0.1;Initial Catalog=gr464_Dmitriev;User ID=student;Password=student");
                    con = new SqlConnection(connetionString);
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount)  VALUES (@SponsorName, @RegistrationId, @Amount)", con);
                    cmd.Parameters.AddWithValue("@SponsorName", spons_name.Text);
                    cmd.Parameters.AddWithValue("@RegistrationId", runner.SelectedValue);
                    cmd.Parameters.AddWithValue("@Amount", summ_poz.Text);
                    cmd.ExecuteNonQuery();
                   
                    
                    thxdonate donate = new thxdonate();
                   
                    donate.Show();
                    donate.lbl_namerun.Text = runner.Text;
                    donate.lbl_fond.Text = lbl_redcross.Text;
                    donate.lbl_money.Text = lb_poz.Text;
                    this.Close();
                }
            }
           

        }

        private void summ_poz_TextChanged(object sender, EventArgs e)
        {
            lb_poz.Text = "$" + summ_poz.Text;
        }

        private void msk_cvc_Click(object sender, EventArgs e)
        {
            msk_cvc.SelectionStart = msk_cvc.Text.Length;
            msk_cvc.Focus();
        }

        private void msk_month_Click(object sender, EventArgs e)
        {
            msk_month.SelectionStart = msk_month.Text.Length;
            msk_month.Focus();
        }

        private void msk_year_Click(object sender, EventArgs e)
        {
            msk_year.SelectionStart = msk_year.Text.Length;
            msk_year.Focus();
        }

        private void info_redcross_Click(object sender, EventArgs e)
        {
            Information_redcross inform = new Information_redcross();
            inform.Show();
        }

        private void runner_SelectedIndexChanged(object sender, EventArgs e)
        {
            thxdonate don = new thxdonate();
            don.lbl_namerun.Text = runner.Text;
        }

        private void summ_poz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void summ_poz_Click(object sender, EventArgs e)
        {
            summ_poz.SelectionStart = 0;
            summ_poz.SelectionLength = summ_poz.Text.Length;
        }

        private void spons_name_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void vladcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void spons_name_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void spons_name_Enter(object sender, EventArgs e)
        {
            if (spons_name.Text == "Имя спонсора")
            {
                spons_name.Clear();
                spons_name.ForeColor = Color.Black;
            }

        }

        private void spons_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(spons_name.Text))
            {
                spons_name.Text = "Имя спонсора";
                spons_name.ForeColor = Color.Gray;
            }
        }

        private void vladcard_Enter(object sender, EventArgs e)
        {
            if (vladcard.Text == "NAME LASTNAME")
            {
                vladcard.Clear();
                vladcard.ForeColor = Color.Black;
            }
        }

        private void vladcard_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(vladcard.Text))
            {
                vladcard.Text = "NAME LASTNAME";
                vladcard.ForeColor = Color.Gray;
            }
        }





 



        ////private void runner_SelectedValueChanged(object sender, EventArgs e)
        ////{
        ////    thxdonate don = new thxdonate();
        ////    don.lbl_namerun.Text = runner.SelectedValue.ToString();
        ////}

      
    }
}
