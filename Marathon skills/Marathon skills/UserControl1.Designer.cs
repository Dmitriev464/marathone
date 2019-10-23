namespace Marathon_skills
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_chr = new System.Windows.Forms.Label();
            this.descr_chr = new System.Windows.Forms.Label();
            this.pict_chr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict_chr)).BeginInit();
            this.SuspendLayout();
            // 
            // name_chr
            // 
            this.name_chr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_chr.Location = new System.Drawing.Point(169, 62);
            this.name_chr.Name = "name_chr";
            this.name_chr.Size = new System.Drawing.Size(150, 53);
            this.name_chr.TabIndex = 0;
            this.name_chr.Text = "label1";
            // 
            // descr_chr
            // 
            this.descr_chr.Location = new System.Drawing.Point(283, 24);
            this.descr_chr.Name = "descr_chr";
            this.descr_chr.Size = new System.Drawing.Size(381, 104);
            this.descr_chr.TabIndex = 1;
            this.descr_chr.Text = "label2";
            // 
            // pict_chr
            // 
            this.pict_chr.Location = new System.Drawing.Point(3, 16);
            this.pict_chr.Name = "pict_chr";
            this.pict_chr.Size = new System.Drawing.Size(160, 130);
            this.pict_chr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_chr.TabIndex = 2;
            this.pict_chr.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pict_chr);
            this.Controls.Add(this.descr_chr);
            this.Controls.Add(this.name_chr);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(716, 217);
            ((System.ComponentModel.ISupportInitialize)(this.pict_chr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label name_chr;
        public System.Windows.Forms.Label descr_chr;
        public System.Windows.Forms.PictureBox pict_chr;
    }
}
