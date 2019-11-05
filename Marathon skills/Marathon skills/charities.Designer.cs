namespace Marathon_skills
{
    partial class charities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(charities));
            this.btn_bck_charity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_bck_charity
            // 
            this.btn_bck_charity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bck_charity.ForeColor = System.Drawing.Color.Black;
            this.btn_bck_charity.Location = new System.Drawing.Point(12, 7);
            this.btn_bck_charity.Name = "btn_bck_charity";
            this.btn_bck_charity.Size = new System.Drawing.Size(75, 23);
            this.btn_bck_charity.TabIndex = 14;
            this.btn_bck_charity.Text = "Назад";
            this.btn_bck_charity.UseVisualStyleBackColor = true;
            this.btn_bck_charity.Click += new System.EventHandler(this.btn_bck_charity_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(803, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "MARATHON SKILLS 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Список благотворительных организаций";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(141, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 82);
            this.label3.TabIndex = 16;
            this.label3.Text = "Это - список всех благотворительных учереждений которые поддерживаются в Marathon" +
    " Skills 2019.\r\nСпасибо за то, что поддерживаете их, спонсируя бегунов.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 164);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 404);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arise-logo.png");
            this.imageList1.Images.SetKeyName(1, "aves-do-brazil-logo.png");
            this.imageList1.Images.SetKeyName(2, "clara-santos-oliveira-institute-logo.png");
            this.imageList1.Images.SetKeyName(3, "conquer-cancer-brazil.png");
            this.imageList1.Images.SetKeyName(4, "diabetes-brazil-logo.png");
            this.imageList1.Images.SetKeyName(5, "heart-health-sao-paulo-logo.png");
            this.imageList1.Images.SetKeyName(6, "human-rights-centre-logo.png");
            this.imageList1.Images.SetKeyName(7, "oxfam-international-logo.png");
            this.imageList1.Images.SetKeyName(8, "querstadtein-logo.png");
            this.imageList1.Images.SetKeyName(9, "save-the-children-fund-logo.png");
            this.imageList1.Images.SetKeyName(10, "stay-pumped-logo.png");
            this.imageList1.Images.SetKeyName(11, "the-red-cross-logo.png");
            this.imageList1.Images.SetKeyName(12, "upbeat-logo.png");
            this.imageList1.Images.SetKeyName(13, "wwsm-rescue-logo.png");
            // 
            // charities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 580);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bck_charity);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "charities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2019 - List of charities";
            this.Load += new System.EventHandler(this.charities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bck_charity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}