namespace Marathon_skills
{
    partial class Form1
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
            this.wantberun_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_inform = new System.Windows.Forms.Button();
            this.btn_sponsor = new System.Windows.Forms.Button();
            this.log_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wantberun_btn
            // 
            this.wantberun_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wantberun_btn.Location = new System.Drawing.Point(35, 105);
            this.wantberun_btn.Name = "wantberun_btn";
            this.wantberun_btn.Size = new System.Drawing.Size(201, 72);
            this.wantberun_btn.TabIndex = 0;
            this.wantberun_btn.Text = "Я хочу стать бегуном";
            this.wantberun_btn.UseVisualStyleBackColor = true;
            this.wantberun_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(297, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Я хочу стать зрителем";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_inform
            // 
            this.btn_inform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inform.Location = new System.Drawing.Point(297, 230);
            this.btn_inform.Name = "btn_inform";
            this.btn_inform.Size = new System.Drawing.Size(197, 72);
            this.btn_inform.TabIndex = 2;
            this.btn_inform.Text = "Я хочу узнать больше о событии";
            this.btn_inform.UseVisualStyleBackColor = true;
            this.btn_inform.Click += new System.EventHandler(this.btn_inform_Click);
            // 
            // btn_sponsor
            // 
            this.btn_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sponsor.Location = new System.Drawing.Point(35, 230);
            this.btn_sponsor.Name = "btn_sponsor";
            this.btn_sponsor.Size = new System.Drawing.Size(201, 72);
            this.btn_sponsor.TabIndex = 3;
            this.btn_sponsor.Text = "Я хочу стать спонсором бегуна";
            this.btn_sponsor.UseVisualStyleBackColor = true;
            this.btn_sponsor.Click += new System.EventHandler(this.btn_sponsor_Click);
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(419, 334);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(75, 23);
            this.log_btn.TabIndex = 4;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(210, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Москва, Россия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(192, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "среда\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr1
            // 
            this.tmr1.AutoSize = true;
            this.tmr1.Location = new System.Drawing.Point(143, 350);
            this.tmr1.Name = "tmr1";
            this.tmr1.Size = new System.Drawing.Size(0, 13);
            this.tmr1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 381);
            this.Controls.Add(this.tmr1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.btn_sponsor);
            this.Controls.Add(this.btn_inform);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wantberun_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2019 - Dmitriev ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wantberun_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_inform;
        private System.Windows.Forms.Button btn_sponsor;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tmr1;
    }
}

