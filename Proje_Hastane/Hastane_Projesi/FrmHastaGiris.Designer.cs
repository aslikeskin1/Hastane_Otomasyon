namespace Hastane_Projesi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masked_HastaTc = new System.Windows.Forms.MaskedTextBox();
            this.txt_HastaSifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.linkLlb_HastaKayıt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta Şifre:";
            // 
            // masked_HastaTc
            // 
            this.masked_HastaTc.Location = new System.Drawing.Point(166, 86);
            this.masked_HastaTc.Mask = "00000000000";
            this.masked_HastaTc.Name = "masked_HastaTc";
            this.masked_HastaTc.Size = new System.Drawing.Size(185, 32);
            this.masked_HastaTc.TabIndex = 2;
            this.masked_HastaTc.Text = "11111111111";
            this.masked_HastaTc.ValidatingType = typeof(int);
            // 
            // txt_HastaSifre
            // 
            this.txt_HastaSifre.Location = new System.Drawing.Point(166, 126);
            this.txt_HastaSifre.Name = "txt_HastaSifre";
            this.txt_HastaSifre.Size = new System.Drawing.Size(185, 32);
            this.txt_HastaSifre.TabIndex = 3;
            this.txt_HastaSifre.UseSystemPasswordChar = true;
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Giris.Location = new System.Drawing.Point(201, 181);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(150, 46);
            this.btn_Giris.TabIndex = 4;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // linkLlb_HastaKayıt
            // 
            this.linkLlb_HastaKayıt.AutoSize = true;
            this.linkLlb_HastaKayıt.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLlb_HastaKayıt.LinkColor = System.Drawing.Color.Red;
            this.linkLlb_HastaKayıt.Location = new System.Drawing.Point(345, 246);
            this.linkLlb_HastaKayıt.Name = "linkLlb_HastaKayıt";
            this.linkLlb_HastaKayıt.Size = new System.Drawing.Size(107, 23);
            this.linkLlb_HastaKayıt.TabIndex = 5;
            this.linkLlb_HastaKayıt.TabStop = true;
            this.linkLlb_HastaKayıt.Text = "Hasta Kayıt";
            this.linkLlb_HastaKayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLlb_HastaKayıt_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(464, 278);
            this.Controls.Add(this.linkLlb_HastaKayıt);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_HastaSifre);
            this.Controls.Add(this.masked_HastaTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "HASTA GİRİŞ";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masked_HastaTc;
        private System.Windows.Forms.TextBox txt_HastaSifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel linkLlb_HastaKayıt;
    }
}