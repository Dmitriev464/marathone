using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_skills
{
    public partial class registrationnewrunner : Form
    {
        public registrationnewrunner()
        {
            InitializeComponent();
        }

        private void btn_bck_spons_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void registrationnewrunner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gr464_DmitrievDataSet2.countryv' table. You can move, or remove it, as needed.
            this.countryvTableAdapter.Fill(this.gr464_DmitrievDataSet2.countryv);
            // TODO: This line of code loads data into the 'gr464_DmitrievDataSet1.genderv' table. You can move, or remove it, as needed.
            this.gendervTableAdapter.Fill(this.gr464_DmitrievDataSet1.genderv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calendar_newr.Visible == true)
            {
                calendar_newr.Visible = false;
            }
            else calendar_newr.Visible = true;
        }

        private void calendar_newr_DateSelected(object sender, DateRangeEventArgs e)
        {
            birthday.Text = calendar_newr.SelectionStart.ToShortDateString();
        }

        private void selectionimg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    photo_pctb.Image = new Bitmap(ofd.FileName);
      
                    photo_txt.Text = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл");
                }
            }

        }
        
        private void registr_btn_Click(object sender, EventArgs e)
        {

            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            bool matched = r.Match(email_txt.Text).Success;
          
            if (matched != true)
            {
                MessageBox.Show("Неверно введена почта");
            }

            else if (pass_txt.TextLength <= 5)
            {
                MessageBox.Show("Пароль меньше нужной длинны");
                
            }
            
            
            


            else if (string.IsNullOrEmpty(email_txt.Text) || string.IsNullOrEmpty(pass_txt.Text) || string.IsNullOrEmpty(passconf_txt.Text) || string.IsNullOrEmpty(fname_txt.Text) || string.IsNullOrEmpty(lname_txt.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }

            else
            {
                registration reg = new registration();
                reg.Show();
            }
        }
    }
}
