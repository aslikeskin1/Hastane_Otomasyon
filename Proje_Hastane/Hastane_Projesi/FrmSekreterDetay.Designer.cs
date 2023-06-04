namespace Hastane_Projesi
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_SekreterTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Olustur = new System.Windows.Forms.Button();
            this.rch_Duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_RandevuListesi = new System.Windows.Forms.Button();
            this.btn_BransPaneli = new System.Windows.Forms.Button();
            this.btn_DoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.combo_Brans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_Doktor = new System.Windows.Forms.ComboBox();
            this.masked_Saat = new System.Windows.Forms.MaskedTextBox();
            this.masked_TC = new System.Windows.Forms.MaskedTextBox();
            this.masked_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.checkBox_Durum = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datagrid_doktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_Duyurular = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_doktorlar)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Duyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.lbl_SekreterTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(219, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(41, 109);
            this.lbl_AdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(91, 17);
            this.lbl_AdSoyad.TabIndex = 0;
            this.lbl_AdSoyad.Text = "NULL NULL";
            // 
            // lbl_SekreterTC
            // 
            this.lbl_SekreterTC.AutoSize = true;
            this.lbl_SekreterTC.Location = new System.Drawing.Point(38, 56);
            this.lbl_SekreterTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SekreterTC.Name = "lbl_SekreterTC";
            this.lbl_SekreterTC.Size = new System.Drawing.Size(85, 17);
            this.lbl_SekreterTC.TabIndex = 0;
            this.lbl_SekreterTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Olustur);
            this.groupBox2.Controls.Add(this.rch_Duyuru);
            this.groupBox2.Location = new System.Drawing.Point(10, 163);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(219, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_Olustur
            // 
            this.btn_Olustur.Location = new System.Drawing.Point(9, 150);
            this.btn_Olustur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Olustur.Name = "btn_Olustur";
            this.btn_Olustur.Size = new System.Drawing.Size(195, 35);
            this.btn_Olustur.TabIndex = 12;
            this.btn_Olustur.Text = "OLUŞTUR";
            this.btn_Olustur.UseVisualStyleBackColor = true;
            this.btn_Olustur.Click += new System.EventHandler(this.btn_Olustur_Click);
            // 
            // rch_Duyuru
            // 
            this.rch_Duyuru.Location = new System.Drawing.Point(5, 23);
            this.rch_Duyuru.Margin = new System.Windows.Forms.Padding(2);
            this.rch_Duyuru.Name = "rch_Duyuru";
            this.rch_Duyuru.Size = new System.Drawing.Size(199, 123);
            this.rch_Duyuru.TabIndex = 0;
            this.rch_Duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_RandevuListesi);
            this.groupBox3.Controls.Add(this.btn_BransPaneli);
            this.groupBox3.Controls.Add(this.btn_DoktorPaneli);
            this.groupBox3.Location = new System.Drawing.Point(10, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(488, 120);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btn_RandevuListesi
            // 
            this.btn_RandevuListesi.Location = new System.Drawing.Point(237, 45);
            this.btn_RandevuListesi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RandevuListesi.Name = "btn_RandevuListesi";
            this.btn_RandevuListesi.Size = new System.Drawing.Size(110, 43);
            this.btn_RandevuListesi.TabIndex = 11;
            this.btn_RandevuListesi.Text = "Randevu Listesi";
            this.btn_RandevuListesi.UseVisualStyleBackColor = true;
            this.btn_RandevuListesi.Click += new System.EventHandler(this.btn_RandevuListesi_Click);
            // 
            // btn_BransPaneli
            // 
            this.btn_BransPaneli.Location = new System.Drawing.Point(123, 45);
            this.btn_BransPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BransPaneli.Name = "btn_BransPaneli";
            this.btn_BransPaneli.Size = new System.Drawing.Size(110, 43);
            this.btn_BransPaneli.TabIndex = 10;
            this.btn_BransPaneli.Text = "Branş Paneli";
            this.btn_BransPaneli.UseVisualStyleBackColor = true;
            this.btn_BransPaneli.Click += new System.EventHandler(this.btn_BransPaneli_Click);
            // 
            // btn_DoktorPaneli
            // 
            this.btn_DoktorPaneli.Location = new System.Drawing.Point(9, 45);
            this.btn_DoktorPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DoktorPaneli.Name = "btn_DoktorPaneli";
            this.btn_DoktorPaneli.Size = new System.Drawing.Size(110, 43);
            this.btn_DoktorPaneli.TabIndex = 9;
            this.btn_DoktorPaneli.Text = "Doktor Paneli";
            this.btn_DoktorPaneli.UseVisualStyleBackColor = true;
            this.btn_DoktorPaneli.Click += new System.EventHandler(this.btn_DoktorPaneli_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combo_Brans);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.combo_Doktor);
            this.groupBox4.Controls.Add(this.masked_Saat);
            this.groupBox4.Controls.Add(this.masked_TC);
            this.groupBox4.Controls.Add(this.masked_Tarih);
            this.groupBox4.Controls.Add(this.btn_Kaydet);
            this.groupBox4.Controls.Add(this.checkBox_Durum);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(233, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(265, 349);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            // 
            // combo_Brans
            // 
            this.combo_Brans.FormattingEnabled = true;
            this.combo_Brans.Location = new System.Drawing.Point(92, 111);
            this.combo_Brans.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Brans.Name = "combo_Brans";
            this.combo_Brans.Size = new System.Drawing.Size(150, 25);
            this.combo_Brans.TabIndex = 3;
            this.combo_Brans.SelectedIndexChanged += new System.EventHandler(this.combo_Brans_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Branş:";
            // 
            // combo_Doktor
            // 
            this.combo_Doktor.FormattingEnabled = true;
            this.combo_Doktor.Location = new System.Drawing.Point(92, 144);
            this.combo_Doktor.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Doktor.Name = "combo_Doktor";
            this.combo_Doktor.Size = new System.Drawing.Size(150, 25);
            this.combo_Doktor.TabIndex = 4;
            // 
            // masked_Saat
            // 
            this.masked_Saat.Location = new System.Drawing.Point(92, 83);
            this.masked_Saat.Margin = new System.Windows.Forms.Padding(2);
            this.masked_Saat.Mask = "00:00";
            this.masked_Saat.Name = "masked_Saat";
            this.masked_Saat.Size = new System.Drawing.Size(150, 25);
            this.masked_Saat.TabIndex = 2;
            this.masked_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // masked_TC
            // 
            this.masked_TC.Location = new System.Drawing.Point(92, 176);
            this.masked_TC.Margin = new System.Windows.Forms.Padding(2);
            this.masked_TC.Mask = "00000000000";
            this.masked_TC.Name = "masked_TC";
            this.masked_TC.Size = new System.Drawing.Size(150, 25);
            this.masked_TC.TabIndex = 5;
            this.masked_TC.ValidatingType = typeof(int);
            // 
            // masked_Tarih
            // 
            this.masked_Tarih.Location = new System.Drawing.Point(92, 50);
            this.masked_Tarih.Margin = new System.Windows.Forms.Padding(2);
            this.masked_Tarih.Mask = "00/00/0000";
            this.masked_Tarih.Name = "masked_Tarih";
            this.masked_Tarih.Size = new System.Drawing.Size(150, 25);
            this.masked_Tarih.TabIndex = 1;
            this.masked_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(92, 271);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(127, 27);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // checkBox_Durum
            // 
            this.checkBox_Durum.AutoSize = true;
            this.checkBox_Durum.Location = new System.Drawing.Point(92, 212);
            this.checkBox_Durum.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Durum.Name = "checkBox_Durum";
            this.checkBox_Durum.Size = new System.Drawing.Size(68, 21);
            this.checkBox_Durum.TabIndex = 6;
            this.checkBox_Durum.Text = "Durum";
            this.checkBox_Durum.UseVisualStyleBackColor = true;
            this.checkBox_Durum.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Saat:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.datagrid_doktorlar);
            this.groupBox5.Location = new System.Drawing.Point(512, 249);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(272, 235);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // datagrid_doktorlar
            // 
            this.datagrid_doktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_doktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_doktorlar.Location = new System.Drawing.Point(2, 20);
            this.datagrid_doktorlar.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_doktorlar.Name = "datagrid_doktorlar";
            this.datagrid_doktorlar.Size = new System.Drawing.Size(268, 213);
            this.datagrid_doktorlar.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_Duyurular);
            this.groupBox7.Location = new System.Drawing.Point(512, 11);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(272, 234);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Branşlar";
            // 
            // btn_Duyurular
            // 
            this.btn_Duyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btn_Duyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btn_Duyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Duyurular.Location = new System.Drawing.Point(2, 20);
            this.btn_Duyurular.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Duyurular.Name = "btn_Duyurular";
            this.btn_Duyurular.Size = new System.Drawing.Size(268, 212);
            this.btn_Duyurular.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(795, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "SEKRETER DETAY PANELİ";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_doktorlar)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Duyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_SekreterTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Olustur;
        private System.Windows.Forms.RichTextBox rch_Duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_RandevuListesi;
        private System.Windows.Forms.Button btn_BransPaneli;
        private System.Windows.Forms.Button btn_DoktorPaneli;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox combo_Doktor;
        private System.Windows.Forms.MaskedTextBox masked_Saat;
        private System.Windows.Forms.MaskedTextBox masked_TC;
        private System.Windows.Forms.MaskedTextBox masked_Tarih;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.CheckBox checkBox_Durum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView btn_Duyurular;
        private System.Windows.Forms.DataGridView datagrid_doktorlar;
        private System.Windows.Forms.ComboBox combo_Brans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}