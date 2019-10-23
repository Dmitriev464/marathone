namespace Marathon_skills
{
    partial class Sponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sponsor));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bck_spons = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.spons_name = new System.Windows.Forms.TextBox();
            this.runner = new System.Windows.Forms.ComboBox();
            this.forsponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr464_DmitrievDataSet = new Marathon_skills.gr464_DmitrievDataSet();
            this.forsponsTableAdapter = new Marathon_skills.gr464_DmitrievDataSetTableAdapters.forsponsTableAdapter();
            this.msk_card = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.summ_poz = new System.Windows.Forms.TextBox();
            this.mns_poz = new System.Windows.Forms.Button();
            this.pls_poz = new System.Windows.Forms.Button();
            this.lb_poz = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vladcard = new System.Windows.Forms.TextBox();
            this.msk_month = new System.Windows.Forms.MaskedTextBox();
            this.msk_year = new System.Windows.Forms.MaskedTextBox();
            this.msk_cvc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_redcross = new System.Windows.Forms.Label();
            this.info_redcross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.forsponsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_redcross)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(670, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_bck_spons
            // 
            this.btn_bck_spons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_spons.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_spons.Location = new System.Drawing.Point(12, 7);
            this.btn_bck_spons.Name = "btn_bck_spons";
            this.btn_bck_spons.Size = new System.Drawing.Size(75, 23);
            this.btn_bck_spons.TabIndex = 10;
            this.btn_bck_spons.Text = "Назад";
            this.btn_bck_spons.UseVisualStyleBackColor = true;
            this.btn_bck_spons.Click += new System.EventHandler(this.btn_bck_spons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(234, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Спонсор бегуна";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 86);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму, которую в" +
    "ы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их благотворительн" +
    "ых учреждений";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Информация о Спонсоре";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(426, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Благотворительность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ваше имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(91, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Бегун:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Владелец карты:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Номер карты#:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Срок действия:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(105, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "CVC:";
            // 
            // spons_name
            // 
            this.spons_name.Location = new System.Drawing.Point(153, 233);
            this.spons_name.Name = "spons_name";
            this.spons_name.Size = new System.Drawing.Size(100, 20);
            this.spons_name.TabIndex = 1;
            this.spons_name.TextChanged += new System.EventHandler(this.spons_name_TextChanged);
            this.spons_name.Enter += new System.EventHandler(this.spons_name_Enter);
            this.spons_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spons_name_KeyPress);
            this.spons_name.Leave += new System.EventHandler(this.spons_name_Leave);
            // 
            // runner
            // 
            this.runner.DataSource = this.forsponsBindingSource;
            this.runner.DisplayMember = "DisplayName";
            this.runner.FormattingEnabled = true;
            this.runner.Location = new System.Drawing.Point(153, 263);
            this.runner.Name = "runner";
            this.runner.Size = new System.Drawing.Size(160, 21);
            this.runner.TabIndex = 2;
            this.runner.ValueMember = "RunnerId";
            this.runner.SelectedIndexChanged += new System.EventHandler(this.runner_SelectedIndexChanged);
            // 
            // forsponsBindingSource
            // 
            this.forsponsBindingSource.DataMember = "forspons";
            this.forsponsBindingSource.DataSource = this.gr464_DmitrievDataSet;
            // 
            // gr464_DmitrievDataSet
            // 
            this.gr464_DmitrievDataSet.DataSetName = "gr464_DmitrievDataSet";
            this.gr464_DmitrievDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forsponsTableAdapter
            // 
            this.forsponsTableAdapter.ClearBeforeFill = true;
            // 
            // msk_card
            // 
            this.msk_card.Location = new System.Drawing.Point(153, 323);
            this.msk_card.Mask = "0000 0000 0000 0000";
            this.msk_card.Name = "msk_card";
            this.msk_card.Size = new System.Drawing.Size(117, 20);
            this.msk_card.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr2
            // 
            this.tmr2.AutoSize = true;
            this.tmr2.ForeColor = System.Drawing.Color.Black;
            this.tmr2.Location = new System.Drawing.Point(283, 423);
            this.tmr2.Name = "tmr2";
            this.tmr2.Size = new System.Drawing.Size(0, 13);
            this.tmr2.TabIndex = 15;
            // 
            // btn_send
            // 
            this.btn_send.ForeColor = System.Drawing.Color.Black;
            this.btn_send.Location = new System.Drawing.Point(457, 370);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "Оплатить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // summ_poz
            // 
            this.summ_poz.Location = new System.Drawing.Point(457, 324);
            this.summ_poz.Name = "summ_poz";
            this.summ_poz.Size = new System.Drawing.Size(75, 20);
            this.summ_poz.TabIndex = 8;
            this.summ_poz.Text = "0";
            this.summ_poz.Click += new System.EventHandler(this.summ_poz_Click);
            this.summ_poz.TextChanged += new System.EventHandler(this.summ_poz_TextChanged);
            this.summ_poz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.summ_poz_KeyPress);
            // 
            // mns_poz
            // 
            this.mns_poz.Location = new System.Drawing.Point(376, 321);
            this.mns_poz.Name = "mns_poz";
            this.mns_poz.Size = new System.Drawing.Size(75, 23);
            this.mns_poz.TabIndex = 19;
            this.mns_poz.Text = "-";
            this.mns_poz.UseVisualStyleBackColor = true;
            this.mns_poz.Click += new System.EventHandler(this.mns_poz_Click);
            // 
            // pls_poz
            // 
            this.pls_poz.Location = new System.Drawing.Point(538, 321);
            this.pls_poz.Name = "pls_poz";
            this.pls_poz.Size = new System.Drawing.Size(75, 23);
            this.pls_poz.TabIndex = 20;
            this.pls_poz.Text = "+";
            this.pls_poz.UseVisualStyleBackColor = true;
            this.pls_poz.Click += new System.EventHandler(this.pls_poz_Click);
            // 
            // lb_poz
            // 
            this.lb_poz.AutoSize = true;
            this.lb_poz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_poz.ForeColor = System.Drawing.Color.Gray;
            this.lb_poz.Location = new System.Drawing.Point(451, 297);
            this.lb_poz.Name = "lb_poz";
            this.lb_poz.Size = new System.Drawing.Size(0, 16);
            this.lb_poz.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(411, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Сумма пожертвования";
            // 
            // vladcard
            // 
            this.vladcard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.vladcard.Location = new System.Drawing.Point(153, 297);
            this.vladcard.Name = "vladcard";
            this.vladcard.Size = new System.Drawing.Size(160, 20);
            this.vladcard.TabIndex = 3;
            this.vladcard.Enter += new System.EventHandler(this.vladcard_Enter);
            this.vladcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vladcard_KeyPress);
            this.vladcard.Leave += new System.EventHandler(this.vladcard_Leave);
            // 
            // msk_month
            // 
            this.msk_month.Location = new System.Drawing.Point(153, 350);
            this.msk_month.Mask = "00";
            this.msk_month.Name = "msk_month";
            this.msk_month.Size = new System.Drawing.Size(25, 20);
            this.msk_month.TabIndex = 5;
            this.msk_month.Click += new System.EventHandler(this.msk_month_Click);
            // 
            // msk_year
            // 
            this.msk_year.Location = new System.Drawing.Point(184, 350);
            this.msk_year.Mask = "0000";
            this.msk_year.Name = "msk_year";
            this.msk_year.Size = new System.Drawing.Size(39, 20);
            this.msk_year.TabIndex = 6;
            this.msk_year.Click += new System.EventHandler(this.msk_year_Click);
            // 
            // msk_cvc
            // 
            this.msk_cvc.Location = new System.Drawing.Point(153, 376);
            this.msk_cvc.Mask = "000";
            this.msk_cvc.Name = "msk_cvc";
            this.msk_cvc.Size = new System.Drawing.Size(25, 20);
            this.msk_cvc.TabIndex = 7;
            this.msk_cvc.Click += new System.EventHandler(this.msk_cvc_Click);
            // 
            // lbl_redcross
            // 
            this.lbl_redcross.AutoSize = true;
            this.lbl_redcross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_redcross.ForeColor = System.Drawing.Color.Black;
            this.lbl_redcross.Location = new System.Drawing.Point(421, 221);
            this.lbl_redcross.Name = "lbl_redcross";
            this.lbl_redcross.Size = new System.Drawing.Size(134, 20);
            this.lbl_redcross.TabIndex = 27;
            this.lbl_redcross.Text = "Красный крест";
            // 
            // info_redcross
            // 
            this.info_redcross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_redcross.Image = ((System.Drawing.Image)(resources.GetObject("info_redcross.Image")));
            this.info_redcross.Location = new System.Drawing.Point(561, 218);
            this.info_redcross.Name = "info_redcross";
            this.info_redcross.Size = new System.Drawing.Size(25, 23);
            this.info_redcross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info_redcross.TabIndex = 12;
            this.info_redcross.TabStop = false;
            this.info_redcross.Click += new System.EventHandler(this.info_redcross_Click);
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.ControlBox = false;
            this.Controls.Add(this.info_redcross);
            this.Controls.Add(this.lbl_redcross);
            this.Controls.Add(this.msk_cvc);
            this.Controls.Add(this.msk_year);
            this.Controls.Add(this.msk_month);
            this.Controls.Add(this.vladcard);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_poz);
            this.Controls.Add(this.pls_poz);
            this.Controls.Add(this.mns_poz);
            this.Controls.Add(this.summ_poz);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tmr2);
            this.Controls.Add(this.msk_card);
            this.Controls.Add(this.runner);
            this.Controls.Add(this.spons_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bck_spons);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sponsor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2019 - Sponsor a runner";
            this.Load += new System.EventHandler(this.Sponsor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forsponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_redcross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bck_spons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox spons_name;
        private gr464_DmitrievDataSet gr464_DmitrievDataSet;
        private System.Windows.Forms.BindingSource forsponsBindingSource;
        private gr464_DmitrievDataSetTableAdapters.forsponsTableAdapter forsponsTableAdapter;
        private System.Windows.Forms.MaskedTextBox msk_card;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tmr2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox summ_poz;
        private System.Windows.Forms.Button mns_poz;
        private System.Windows.Forms.Button pls_poz;
        private System.Windows.Forms.Label lb_poz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox vladcard;
        private System.Windows.Forms.MaskedTextBox msk_month;
        private System.Windows.Forms.MaskedTextBox msk_year;
        private System.Windows.Forms.MaskedTextBox msk_cvc;
        private System.Windows.Forms.Label lbl_redcross;
        private System.Windows.Forms.PictureBox info_redcross;
        public System.Windows.Forms.ComboBox runner;
    }
}