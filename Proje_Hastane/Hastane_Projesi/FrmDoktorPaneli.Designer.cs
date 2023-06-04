namespace Hastane_Projesi
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.masked_DoktorTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.combo_Brans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.datagrid_Doktorlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Doktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(76, 148);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(149, 25);
            this.txt_Sifre.TabIndex = 5;
            // 
            // masked_DoktorTC
            // 
            this.masked_DoktorTC.Location = new System.Drawing.Point(76, 120);
            this.masked_DoktorTC.Margin = new System.Windows.Forms.Padding(2);
            this.masked_DoktorTC.Mask = "00000000000";
            this.masked_DoktorTC.Name = "masked_DoktorTC";
            this.masked_DoktorTC.Size = new System.Drawing.Size(149, 25);
            this.masked_DoktorTC.TabIndex = 4;
            this.masked_DoktorTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(76, 25);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(149, 25);
            this.txt_Ad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(76, 55);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(149, 25);
            this.txt_Soyad.TabIndex = 2;
            // 
            // combo_Brans
            // 
            this.combo_Brans.FormattingEnabled = true;
            this.combo_Brans.Location = new System.Drawing.Point(76, 89);
            this.combo_Brans.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Brans.Name = "combo_Brans";
            this.combo_Brans.Size = new System.Drawing.Size(149, 25);
            this.combo_Brans.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Branş:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Yellow;
            this.btn_Ekle.Location = new System.Drawing.Point(76, 177);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(148, 30);
            this.btn_Ekle.TabIndex = 6;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Red;
            this.btn_Sil.Location = new System.Drawing.Point(76, 212);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(148, 30);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Green;
            this.btn_Guncelle.Location = new System.Drawing.Point(76, 246);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(148, 30);
            this.btn_Guncelle.TabIndex = 8;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // datagrid_Doktorlar
            // 
            this.datagrid_Doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Doktorlar.Location = new System.Drawing.Point(250, 12);
            this.datagrid_Doktorlar.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_Doktorlar.Name = "datagrid_Doktorlar";
            this.datagrid_Doktorlar.Size = new System.Drawing.Size(569, 281);
            this.datagrid_Doktorlar.TabIndex = 111;
            this.datagrid_Doktorlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Doktorlar_CellClick);
            this.datagrid_Doktorlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txt_Soyad_CellContentClick);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(830, 304);
            this.Controls.Add(this.datagrid_Doktorlar);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.combo_Brans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.masked_DoktorTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "DOKTOR PANELİ";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Doktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.MaskedTextBox masked_DoktorTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.ComboBox combo_Brans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView datagrid_Doktorlar;
    }
}