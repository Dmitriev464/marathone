namespace Marathon_skills
{
    partial class registrationnewrunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_bck_spons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.passconf_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.sex_cmb = new System.Windows.Forms.ComboBox();
            this.gendervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr464_DmitrievDataSet1 = new Marathon_skills.gr464_DmitrievDataSet1();
            this.label10 = new System.Windows.Forms.Label();
            this.photo_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countryvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr464_DmitrievDataSet2 = new Marathon_skills.gr464_DmitrievDataSet2();
            this.photo_pctb = new System.Windows.Forms.PictureBox();
            this.gr464_DmitrievDataSet = new Marathon_skills.gr464_DmitrievDataSet();
            this.gr464DmitrievDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendervTableAdapter = new Marathon_skills.gr464_DmitrievDataSet1TableAdapters.gendervTableAdapter();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.countryvTableAdapter = new Marathon_skills.gr464_DmitrievDataSet2TableAdapters.countryvTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.calendar_newr = new System.Windows.Forms.MonthCalendar();
            this.selectionimg_btn = new System.Windows.Forms.Button();
            this.registr_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gendervBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pctb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464DmitrievDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bck_spons
            // 
            this.btn_bck_spons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_spons.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_spons.Location = new System.Drawing.Point(10, 8);
            this.btn_bck_spons.Name = "btn_bck_spons";
            this.btn_bck_spons.Size = new System.Drawing.Size(75, 23);
            this.btn_bck_spons.TabIndex = 12;
            this.btn_bck_spons.Text = "Назад";
            this.btn_bck_spons.UseVisualStyleBackColor = true;
            this.btn_bck_spons.Click += new System.EventHandler(this.btn_bck_spons_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(684, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(264, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Регистрация бегуна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(116, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться\r\n в качестве бегуна" +
    "";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Повторите пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Пол:";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(119, 145);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(121, 20);
            this.email_txt.TabIndex = 21;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(119, 172);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(121, 20);
            this.pass_txt.TabIndex = 22;
            // 
            // passconf_txt
            // 
            this.passconf_txt.Location = new System.Drawing.Point(119, 198);
            this.passconf_txt.Name = "passconf_txt";
            this.passconf_txt.Size = new System.Drawing.Size(121, 20);
            this.passconf_txt.TabIndex = 23;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(119, 225);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(121, 20);
            this.fname_txt.TabIndex = 24;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(119, 254);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(121, 20);
            this.lname_txt.TabIndex = 25;
            // 
            // sex_cmb
            // 
            this.sex_cmb.DataSource = this.gendervBindingSource;
            this.sex_cmb.DisplayMember = "Pol";
            this.sex_cmb.FormattingEnabled = true;
            this.sex_cmb.Location = new System.Drawing.Point(119, 282);
            this.sex_cmb.Name = "sex_cmb";
            this.sex_cmb.Size = new System.Drawing.Size(121, 21);
            this.sex_cmb.TabIndex = 26;
            this.sex_cmb.ValueMember = "Pol";
            // 
            // gendervBindingSource
            // 
            this.gendervBindingSource.DataMember = "genderv";
            this.gendervBindingSource.DataSource = this.gr464_DmitrievDataSet1;
            // 
            // gr464_DmitrievDataSet1
            // 
            this.gr464_DmitrievDataSet1.DataSetName = "gr464_DmitrievDataSet1";
            this.gr464_DmitrievDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Фото файл:";
            // 
            // photo_txt
            // 
            this.photo_txt.Location = new System.Drawing.Point(320, 275);
            this.photo_txt.Name = "photo_txt";
            this.photo_txt.Size = new System.Drawing.Size(100, 20);
            this.photo_txt.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Дата рождения:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Страна:";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(320, 318);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(121, 20);
            this.birthday.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.countryvBindingSource;
            this.comboBox1.DisplayMember = "Country";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "Country";
            // 
            // countryvBindingSource
            // 
            this.countryvBindingSource.DataMember = "countryv";
            this.countryvBindingSource.DataSource = this.gr464_DmitrievDataSet2;
            // 
            // gr464_DmitrievDataSet2
            // 
            this.gr464_DmitrievDataSet2.DataSetName = "gr464_DmitrievDataSet2";
            this.gr464_DmitrievDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photo_pctb
            // 
            this.photo_pctb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo_pctb.Location = new System.Drawing.Point(426, 133);
            this.photo_pctb.Name = "photo_pctb";
            this.photo_pctb.Size = new System.Drawing.Size(100, 112);
            this.photo_pctb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_pctb.TabIndex = 27;
            this.photo_pctb.TabStop = false;
            // 
            // gr464_DmitrievDataSet
            // 
            this.gr464_DmitrievDataSet.DataSetName = "gr464_DmitrievDataSet";
            this.gr464_DmitrievDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr464DmitrievDataSetBindingSource
            // 
            this.gr464DmitrievDataSetBindingSource.DataSource = this.gr464_DmitrievDataSet;
            this.gr464DmitrievDataSetBindingSource.Position = 0;
            // 
            // gendervTableAdapter
            // 
            this.gendervTableAdapter.ClearBeforeFill = true;
            // 
            // countryvTableAdapter
            // 
            this.countryvTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Marathon_skills.Properties.Resources.Custom_Icon_Design_Mono_Business_2_Calendar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(447, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar_newr
            // 
            this.calendar_newr.Location = new System.Drawing.Point(475, 318);
            this.calendar_newr.Name = "calendar_newr";
            this.calendar_newr.TabIndex = 35;
            this.calendar_newr.Visible = false;
            this.calendar_newr.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_newr_DateSelected);
            // 
            // selectionimg_btn
            // 
            this.selectionimg_btn.Location = new System.Drawing.Point(426, 272);
            this.selectionimg_btn.Name = "selectionimg_btn";
            this.selectionimg_btn.Size = new System.Drawing.Size(75, 23);
            this.selectionimg_btn.TabIndex = 36;
            this.selectionimg_btn.Text = "Просмотр...";
            this.selectionimg_btn.UseVisualStyleBackColor = true;
            this.selectionimg_btn.Click += new System.EventHandler(this.selectionimg_btn_Click);
            // 
            // registr_btn
            // 
            this.registr_btn.Location = new System.Drawing.Point(294, 436);
            this.registr_btn.Name = "registr_btn";
            this.registr_btn.Size = new System.Drawing.Size(91, 23);
            this.registr_btn.TabIndex = 37;
            this.registr_btn.Text = "Регистрация";
            this.registr_btn.UseVisualStyleBackColor = true;
            this.registr_btn.Click += new System.EventHandler(this.registr_btn_Click);
            // 
            // registrationnewrunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 490);
            this.ControlBox = false;
            this.Controls.Add(this.registr_btn);
            this.Controls.Add(this.selectionimg_btn);
            this.Controls.Add(this.calendar_newr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.photo_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.photo_pctb);
            this.Controls.Add(this.sex_cmb);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.passconf_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bck_spons);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "registrationnewrunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationnewrunner";
            this.Load += new System.EventHandler(this.registrationnewrunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gendervBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pctb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464DmitrievDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bck_spons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox passconf_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.ComboBox sex_cmb;
        private System.Windows.Forms.PictureBox photo_pctb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox photo_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.ComboBox comboBox1;
        private gr464_DmitrievDataSet gr464_DmitrievDataSet;
        private System.Windows.Forms.BindingSource gr464DmitrievDataSetBindingSource;
        private gr464_DmitrievDataSet1 gr464_DmitrievDataSet1;
        private System.Windows.Forms.BindingSource gendervBindingSource;
        private gr464_DmitrievDataSet1TableAdapters.gendervTableAdapter gendervTableAdapter;
        private System.IO.Ports.SerialPort serialPort1;
        private gr464_DmitrievDataSet2 gr464_DmitrievDataSet2;
        private System.Windows.Forms.BindingSource countryvBindingSource;
        private gr464_DmitrievDataSet2TableAdapters.countryvTableAdapter countryvTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar calendar_newr;
        private System.Windows.Forms.Button selectionimg_btn;
        private System.Windows.Forms.Button registr_btn;
    }
}