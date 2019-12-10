namespace Marathon_skills
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.btn_bck_spons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fulmar_chk = new System.Windows.Forms.CheckBox();
            this.halfmar_chk = new System.Windows.Forms.CheckBox();
            this.minmar_chk = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vara_rad = new System.Windows.Forms.RadioButton();
            this.varb_rad = new System.Windows.Forms.RadioButton();
            this.varc_rad = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chr_cmb = new System.Windows.Forms.ComboBox();
            this.charvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr464_DmitrievDataSet3 = new Marathon_skills.gr464_DmitrievDataSet3();
            this.charvTableAdapter = new Marathon_skills.gr464_DmitrievDataSet3TableAdapters.charvTableAdapter();
            this.info_redcross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_redcross)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bck_spons
            // 
            this.btn_bck_spons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_spons.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_spons.Location = new System.Drawing.Point(10, 8);
            this.btn_bck_spons.Name = "btn_bck_spons";
            this.btn_bck_spons.Size = new System.Drawing.Size(75, 23);
            this.btn_bck_spons.TabIndex = 14;
            this.btn_bck_spons.Text = "Назад";
            this.btn_bck_spons.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(610, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 67);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться на Marathon Skills " +
    "2019 проводимом в Москве. С вами свяжутся после регистрации для уточнения оплаты" +
    " и другой информации.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Регистрация на марафон";
            // 
            // fulmar_chk
            // 
            this.fulmar_chk.AutoSize = true;
            this.fulmar_chk.Location = new System.Drawing.Point(33, 187);
            this.fulmar_chk.Name = "fulmar_chk";
            this.fulmar_chk.Size = new System.Drawing.Size(174, 17);
            this.fulmar_chk.TabIndex = 17;
            this.fulmar_chk.Text = "42km Полный марафон($145)";
            this.fulmar_chk.UseVisualStyleBackColor = true;
            this.fulmar_chk.CheckedChanged += new System.EventHandler(this.fulmar_chk_CheckedChanged);
            // 
            // halfmar_chk
            // 
            this.halfmar_chk.AutoSize = true;
            this.halfmar_chk.Location = new System.Drawing.Point(33, 220);
            this.halfmar_chk.Name = "halfmar_chk";
            this.halfmar_chk.Size = new System.Drawing.Size(153, 17);
            this.halfmar_chk.TabIndex = 18;
            this.halfmar_chk.Text = "21km Полумарафон ($75)";
            this.halfmar_chk.UseVisualStyleBackColor = true;
            this.halfmar_chk.CheckedChanged += new System.EventHandler(this.halfmar_chk_CheckedChanged);
            // 
            // minmar_chk
            // 
            this.minmar_chk.AutoSize = true;
            this.minmar_chk.Location = new System.Drawing.Point(33, 252);
            this.minmar_chk.Name = "minmar_chk";
            this.minmar_chk.Size = new System.Drawing.Size(165, 17);
            this.minmar_chk.TabIndex = 19;
            this.minmar_chk.Text = "5km Малая дистанция ($20)";
            this.minmar_chk.UseVisualStyleBackColor = true;
            this.minmar_chk.CheckedChanged += new System.EventHandler(this.minmar_chk_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вид марафона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Детали спонсорства";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Варианты комплектов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Регистрационный взнос";
            // 
            // vara_rad
            // 
            this.vara_rad.Location = new System.Drawing.Point(349, 187);
            this.vara_rad.Name = "vara_rad";
            this.vara_rad.Size = new System.Drawing.Size(187, 36);
            this.vara_rad.TabIndex = 24;
            this.vara_rad.TabStop = true;
            this.vara_rad.Text = "Вариант А ($0): Номер бегуна + RFID браслет";
            this.vara_rad.UseVisualStyleBackColor = true;
            this.vara_rad.CheckedChanged += new System.EventHandler(this.vara_rad_CheckedChanged);
            // 
            // varb_rad
            // 
            this.varb_rad.Location = new System.Drawing.Point(349, 229);
            this.varb_rad.Name = "varb_rad";
            this.varb_rad.Size = new System.Drawing.Size(183, 40);
            this.varb_rad.TabIndex = 25;
            this.varb_rad.TabStop = true;
            this.varb_rad.Text = "Вариант В ($20): вариант А + бейсболка + бутылка воды";
            this.varb_rad.UseVisualStyleBackColor = true;
            this.varb_rad.CheckedChanged += new System.EventHandler(this.varb_rad_CheckedChanged);
            // 
            // varc_rad
            // 
            this.varc_rad.Location = new System.Drawing.Point(349, 275);
            this.varc_rad.Name = "varc_rad";
            this.varc_rad.Size = new System.Drawing.Size(187, 39);
            this.varc_rad.TabIndex = 26;
            this.varc_rad.TabStop = true;
            this.varc_rad.Text = "Вариант С ($45): вариант В + футболка + сувенирный буклет";
            this.varc_rad.UseVisualStyleBackColor = true;
            this.varc_rad.CheckedChanged += new System.EventHandler(this.varc_rad_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 27;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(41, 399);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(100, 23);
            this.reg_btn.TabIndex = 28;
            this.reg_btn.Text = "Регистрация";
            this.reg_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(157, 399);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 23);
            this.cancel_btn.TabIndex = 29;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Взнос:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Сумма взноса:";
            // 
            // chr_cmb
            // 
            this.chr_cmb.DataSource = this.charvBindingSource;
            this.chr_cmb.DisplayMember = "CharityName";
            this.chr_cmb.FormattingEnabled = true;
            this.chr_cmb.Location = new System.Drawing.Point(96, 342);
            this.chr_cmb.Name = "chr_cmb";
            this.chr_cmb.Size = new System.Drawing.Size(121, 21);
            this.chr_cmb.TabIndex = 32;
            this.chr_cmb.ValueMember = "CharityName";
            this.chr_cmb.SelectedIndexChanged += new System.EventHandler(this.chr_cmb_SelectedIndexChanged);
            // 
            // charvBindingSource
            // 
            this.charvBindingSource.DataMember = "charv";
            this.charvBindingSource.DataSource = this.gr464_DmitrievDataSet3;
            // 
            // gr464_DmitrievDataSet3
            // 
            this.gr464_DmitrievDataSet3.DataSetName = "gr464_DmitrievDataSet3";
            this.gr464_DmitrievDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charvTableAdapter
            // 
            this.charvTableAdapter.ClearBeforeFill = true;
            // 
            // info_redcross
            // 
            this.info_redcross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_redcross.Image = ((System.Drawing.Image)(resources.GetObject("info_redcross.Image")));
            this.info_redcross.Location = new System.Drawing.Point(223, 342);
            this.info_redcross.Name = "info_redcross";
            this.info_redcross.Size = new System.Drawing.Size(25, 23);
            this.info_redcross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info_redcross.TabIndex = 33;
            this.info_redcross.TabStop = false;
            this.info_redcross.Click += new System.EventHandler(this.info_redcross_Click);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 434);
            this.ControlBox = false;
            this.Controls.Add(this.info_redcross);
            this.Controls.Add(this.chr_cmb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.varc_rad);
            this.Controls.Add(this.varb_rad);
            this.Controls.Add(this.vara_rad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minmar_chk);
            this.Controls.Add(this.halfmar_chk);
            this.Controls.Add(this.fulmar_chk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bck_spons);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "registration";
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_redcross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bck_spons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox fulmar_chk;
        private System.Windows.Forms.CheckBox halfmar_chk;
        private System.Windows.Forms.CheckBox minmar_chk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton vara_rad;
        private System.Windows.Forms.RadioButton varb_rad;
        private System.Windows.Forms.RadioButton varc_rad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private gr464_DmitrievDataSet3 gr464_DmitrievDataSet3;
        private System.Windows.Forms.BindingSource charvBindingSource;
        private gr464_DmitrievDataSet3TableAdapters.charvTableAdapter charvTableAdapter;
        private System.Windows.Forms.PictureBox info_redcross;
        public System.Windows.Forms.ComboBox chr_cmb;
    }
}