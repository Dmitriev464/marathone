namespace Marathon_skills
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_bck_inform = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма авторизации";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пожалуйста авторизуйтесь в систему, используя вашу электронную почту и пароль.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_bck_inform
            // 
            this.btn_bck_inform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_inform.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_inform.Location = new System.Drawing.Point(11, 4);
            this.btn_bck_inform.Name = "btn_bck_inform";
            this.btn_bck_inform.Size = new System.Drawing.Size(69, 23);
            this.btn_bck_inform.TabIndex = 14;
            this.btn_bck_inform.Text = "Назад";
            this.btn_bck_inform.UseVisualStyleBackColor = true;
            this.btn_bck_inform.Click += new System.EventHandler(this.btn_bck_inform_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, -6);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(415, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "MARATHON SKILLS 2019";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(133, 129);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(124, 20);
            this.emailtxt.TabIndex = 17;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(133, 155);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(124, 20);
            this.passwordtxt.TabIndex = 18;
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(145, 181);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(75, 23);
            this.log_btn.TabIndex = 19;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr4
            // 
            this.tmr4.AutoSize = true;
            this.tmr4.ForeColor = System.Drawing.Color.Black;
            this.tmr4.Location = new System.Drawing.Point(109, 238);
            this.tmr4.Name = "tmr4";
            this.tmr4.Size = new System.Drawing.Size(0, 13);
            this.tmr4.TabIndex = 20;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 273);
            this.ControlBox = false;
            this.Controls.Add(this.tmr4);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_bck_inform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_bck_inform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tmr4;
        private System.Windows.Forms.Button log_btn;
    }
}