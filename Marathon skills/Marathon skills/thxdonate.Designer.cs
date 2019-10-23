namespace Marathon_skills
{
    partial class thxdonate
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
            this.lbl_namerun = new System.Windows.Forms.Label();
            this.forsponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr464_DmitrievDataSet = new Marathon_skills.gr464_DmitrievDataSet();
            this.forsponsTableAdapter = new Marathon_skills.gr464_DmitrievDataSetTableAdapters.forsponsTableAdapter();
            this.lbl_fond = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forsponsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bck_spons
            // 
            this.btn_bck_spons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_spons.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_spons.Location = new System.Drawing.Point(13, 7);
            this.btn_bck_spons.Name = "btn_bck_spons";
            this.btn_bck_spons.Size = new System.Drawing.Size(75, 23);
            this.btn_bck_spons.TabIndex = 3;
            this.btn_bck_spons.Text = "Назад";
            this.btn_bck_spons.UseVisualStyleBackColor = true;
            this.btn_bck_spons.Click += new System.EventHandler(this.btn_bck_spons_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(675, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Спасибо за вашу спонсорскую поддержку!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Спасибо за поддержку бегуна в Marathon Skills 2019!";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 56);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ваше пожертвование будет передано в его благотворительную организацию";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_namerun
            // 
            this.lbl_namerun.AutoSize = true;
            this.lbl_namerun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_namerun.Location = new System.Drawing.Point(223, 179);
            this.lbl_namerun.Name = "lbl_namerun";
            this.lbl_namerun.Size = new System.Drawing.Size(57, 20);
            this.lbl_namerun.TabIndex = 7;
            this.lbl_namerun.Text = "label5";
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
            // lbl_fond
            // 
            this.lbl_fond.AutoSize = true;
            this.lbl_fond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fond.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fond.Location = new System.Drawing.Point(231, 208);
            this.lbl_fond.Name = "lbl_fond";
            this.lbl_fond.Size = new System.Drawing.Size(70, 25);
            this.lbl_fond.TabIndex = 8;
            this.lbl_fond.Text = "label5";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_money.ForeColor = System.Drawing.Color.Gray;
            this.lbl_money.Location = new System.Drawing.Point(246, 238);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(99, 33);
            this.lbl_money.TabIndex = 9;
            this.lbl_money.Text = "label5";
            // 
            // thxdonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 313);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lbl_fond);
            this.Controls.Add(this.lbl_namerun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bck_spons);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "thxdonate";
            this.Text = "thxdonate";
            ((System.ComponentModel.ISupportInitialize)(this.forsponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr464_DmitrievDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bck_spons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_namerun;
        private System.Windows.Forms.BindingSource forsponsBindingSource;
        private gr464_DmitrievDataSet gr464_DmitrievDataSet;
        private gr464_DmitrievDataSetTableAdapters.forsponsTableAdapter forsponsTableAdapter;
        public System.Windows.Forms.Label lbl_fond;
        public System.Windows.Forms.Label lbl_money;
    }
}