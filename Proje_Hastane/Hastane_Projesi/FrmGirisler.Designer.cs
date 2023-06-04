namespace Hastane_Projesi
{
    partial class btn_Hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_Hasta));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Doktor = new System.Windows.Forms.Button();
            this.btn_Sekreter = new System.Windows.Forms.Button();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Doktor = new System.Windows.Forms.Label();
            this.lbl_Sekreter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(92, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 149);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Doktor
            // 
            this.btn_Doktor.BackColor = System.Drawing.Color.White;
            this.btn_Doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Doktor.BackgroundImage")));
            this.btn_Doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Doktor.Location = new System.Drawing.Point(292, 190);
            this.btn_Doktor.Name = "btn_Doktor";
            this.btn_Doktor.Size = new System.Drawing.Size(178, 149);
            this.btn_Doktor.TabIndex = 0;
            this.btn_Doktor.UseVisualStyleBackColor = false;
            this.btn_Doktor.Click += new System.EventHandler(this.btn_Doktor_Click);
            // 
            // btn_Sekreter
            // 
            this.btn_Sekreter.BackColor = System.Drawing.Color.White;
            this.btn_Sekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sekreter.BackgroundImage")));
            this.btn_Sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sekreter.Location = new System.Drawing.Point(491, 190);
            this.btn_Sekreter.Name = "btn_Sekreter";
            this.btn_Sekreter.Size = new System.Drawing.Size(178, 149);
            this.btn_Sekreter.TabIndex = 0;
            this.btn_Sekreter.UseVisualStyleBackColor = false;
            this.btn_Sekreter.Click += new System.EventHandler(this.btn_Sekreter_Click);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Location = new System.Drawing.Point(143, 342);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(74, 23);
            this.lbl_Hasta.TabIndex = 1;
            this.lbl_Hasta.Text = "HASTA";
            // 
            // lbl_Doktor
            // 
            this.lbl_Doktor.AutoSize = true;
            this.lbl_Doktor.Location = new System.Drawing.Point(337, 342);
            this.lbl_Doktor.Name = "lbl_Doktor";
            this.lbl_Doktor.Size = new System.Drawing.Size(96, 23);
            this.lbl_Doktor.TabIndex = 1;
            this.lbl_Doktor.Text = "DOKTOR";
            // 
            // lbl_Sekreter
            // 
            this.lbl_Sekreter.AutoSize = true;
            this.lbl_Sekreter.Location = new System.Drawing.Point(525, 342);
            this.lbl_Sekreter.Name = "lbl_Sekreter";
            this.lbl_Sekreter.Size = new System.Drawing.Size(115, 23);
            this.lbl_Sekreter.TabIndex = 1;
            this.lbl_Sekreter.Text = "SEKRETER";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖZEL SAĞLIK HASTANESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(751, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Sekreter);
            this.Controls.Add(this.lbl_Doktor);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.btn_Sekreter);
            this.Controls.Add(this.btn_Doktor);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "btn_Hasta";
            this.Text = "ÖZEL SAĞLIK HASTANESİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Doktor;
        private System.Windows.Forms.Button btn_Sekreter;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Doktor;
        private System.Windows.Forms.Label lbl_Sekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

