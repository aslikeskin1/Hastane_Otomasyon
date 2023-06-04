namespace Hastane_Projesi
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txt_SekreterSifre = new System.Windows.Forms.TextBox();
            this.masked_SekreterTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Giris.Location = new System.Drawing.Point(185, 159);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(150, 46);
            this.btn_Giris.TabIndex = 10;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_SekreterSifre
            // 
            this.txt_SekreterSifre.Location = new System.Drawing.Point(163, 124);
            this.txt_SekreterSifre.Name = "txt_SekreterSifre";
            this.txt_SekreterSifre.Size = new System.Drawing.Size(185, 29);
            this.txt_SekreterSifre.TabIndex = 9;
            this.txt_SekreterSifre.Text = "4444";
            this.txt_SekreterSifre.UseSystemPasswordChar = true;
            // 
            // masked_SekreterTc
            // 
            this.masked_SekreterTc.Location = new System.Drawing.Point(163, 84);
            this.masked_SekreterTc.Mask = "00000000000";
            this.masked_SekreterTc.Name = "masked_SekreterTc";
            this.masked_SekreterTc.Size = new System.Drawing.Size(185, 29);
            this.masked_SekreterTc.TabIndex = 8;
            this.masked_SekreterTc.Text = "44444444444";
            this.masked_SekreterTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(470, 234);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_SekreterSifre);
            this.Controls.Add(this.masked_SekreterTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "SEKRETER GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txt_SekreterSifre;
        private System.Windows.Forms.MaskedTextBox masked_SekreterTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}