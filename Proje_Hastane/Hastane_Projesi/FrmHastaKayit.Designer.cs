namespace Hastane_Projesi
{
    partial class FrmHastaKayit
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
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masked_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.masked_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.combo_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Kayit.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Kayit.Location = new System.Drawing.Point(122, 252);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(130, 38);
            this.btn_Kayit.TabIndex = 7;
            this.btn_Kayit.Text = "KAYIT OL";
            this.btn_Kayit.UseVisualStyleBackColor = false;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(104, 61);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(185, 29);
            this.txt_Soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(104, 168);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(185, 29);
            this.txt_Sifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hasta TC:";
            // 
            // masked_TC
            // 
            this.masked_TC.Location = new System.Drawing.Point(104, 98);
            this.masked_TC.Mask = "00000000000";
            this.masked_TC.Name = "masked_TC";
            this.masked_TC.Size = new System.Drawing.Size(185, 29);
            this.masked_TC.TabIndex = 3;
            this.masked_TC.ValidatingType = typeof(int);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(104, 25);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(185, 29);
            this.txt_Ad.TabIndex = 1;
            // 
            // masked_Telefon
            // 
            this.masked_Telefon.Location = new System.Drawing.Point(104, 133);
            this.masked_Telefon.Mask = "(999) 000-0000";
            this.masked_Telefon.Name = "masked_Telefon";
            this.masked_Telefon.Size = new System.Drawing.Size(185, 29);
            this.masked_Telefon.TabIndex = 4;
            // 
            // combo_Cinsiyet
            // 
            this.combo_Cinsiyet.FormattingEnabled = true;
            this.combo_Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.combo_Cinsiyet.Location = new System.Drawing.Point(104, 203);
            this.combo_Cinsiyet.Name = "combo_Cinsiyet";
            this.combo_Cinsiyet.Size = new System.Drawing.Size(185, 29);
            this.combo_Cinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btn_Kayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(310, 311);
            this.Controls.Add(this.combo_Cinsiyet);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.masked_Telefon);
            this.Controls.Add(this.masked_TC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "HASTA KAYIT";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masked_TC;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.MaskedTextBox masked_Telefon;
        private System.Windows.Forms.ComboBox combo_Cinsiyet;
        private System.Windows.Forms.Label label6;
    }
}