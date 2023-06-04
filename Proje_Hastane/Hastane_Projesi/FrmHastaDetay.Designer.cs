namespace Hastane_Projesi
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.link_BilgileriDuzenle = new System.Windows.Forms.LinkLabel();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btn_RandevuAl = new System.Windows.Forms.Button();
            this.richtxt_Sikayet = new System.Windows.Forms.RichTextBox();
            this.cmb_Doktor = new System.Windows.Forms.ComboBox();
            this.cmb_Brans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagrid_AktifRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_AktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.link_BilgileriDuzenle);
            this.groupBox1.Controls.Add(this.lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(251, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // link_BilgileriDuzenle
            // 
            this.link_BilgileriDuzenle.AutoSize = true;
            this.link_BilgileriDuzenle.Location = new System.Drawing.Point(23, 154);
            this.link_BilgileriDuzenle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_BilgileriDuzenle.Name = "link_BilgileriDuzenle";
            this.link_BilgileriDuzenle.Size = new System.Drawing.Size(104, 17);
            this.link_BilgileriDuzenle.TabIndex = 4;
            this.link_BilgileriDuzenle.TabStop = true;
            this.link_BilgileriDuzenle.Text = "Bilgileri Düzenle";
            this.link_BilgileriDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_BilgileriDuzenle_LinkClicked);
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(108, 88);
            this.lbl_AdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(91, 17);
            this.lbl_AdSoyad.TabIndex = 0;
            this.lbl_AdSoyad.Text = "NULL NULL";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(113, 54);
            this.lbl_TC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(85, 17);
            this.lbl_TC.TabIndex = 0;
            this.lbl_TC.Text = "00000000000";
            this.lbl_TC.Click += new System.EventHandler(this.lbl_TC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.btn_RandevuAl);
            this.groupBox2.Controls.Add(this.richtxt_Sikayet);
            this.groupBox2.Controls.Add(this.cmb_Doktor);
            this.groupBox2.Controls.Add(this.cmb_Brans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(251, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Alma Paneli";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(63, 32);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 25);
            this.txtid.TabIndex = 5;
            // 
            // btn_RandevuAl
            // 
            this.btn_RandevuAl.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_RandevuAl.Location = new System.Drawing.Point(63, 231);
            this.btn_RandevuAl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RandevuAl.Name = "btn_RandevuAl";
            this.btn_RandevuAl.Size = new System.Drawing.Size(143, 30);
            this.btn_RandevuAl.TabIndex = 3;
            this.btn_RandevuAl.Text = "RANDEVU AL";
            this.btn_RandevuAl.UseVisualStyleBackColor = false;
            this.btn_RandevuAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // richtxt_Sikayet
            // 
            this.richtxt_Sikayet.Location = new System.Drawing.Point(63, 117);
            this.richtxt_Sikayet.Margin = new System.Windows.Forms.Padding(2);
            this.richtxt_Sikayet.Name = "richtxt_Sikayet";
            this.richtxt_Sikayet.Size = new System.Drawing.Size(164, 87);
            this.richtxt_Sikayet.TabIndex = 2;
            this.richtxt_Sikayet.Text = "";
            // 
            // cmb_Doktor
            // 
            this.cmb_Doktor.FormattingEnabled = true;
            this.cmb_Doktor.Location = new System.Drawing.Point(63, 88);
            this.cmb_Doktor.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Doktor.Name = "cmb_Doktor";
            this.cmb_Doktor.Size = new System.Drawing.Size(166, 25);
            this.cmb_Doktor.TabIndex = 1;
            this.cmb_Doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_Doktor_SelectedIndexChanged);
            // 
            // cmb_Brans
            // 
            this.cmb_Brans.FormattingEnabled = true;
            this.cmb_Brans.Location = new System.Drawing.Point(63, 60);
            this.cmb_Brans.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Brans.Name = "cmb_Brans";
            this.cmb_Brans.Size = new System.Drawing.Size(166, 25);
            this.cmb_Brans.TabIndex = 1;
            this.cmb_Brans.SelectedIndexChanged += new System.EventHandler(this.cmb_Brans_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şikayet:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doktor:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branş:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ID);
            this.groupBox3.Location = new System.Drawing.Point(283, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(529, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txt_ID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(2, 20);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(525, 178);
            this.txt_ID.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagrid_AktifRandevular);
            this.groupBox4.Location = new System.Drawing.Point(283, 214);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(531, 278);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // datagrid_AktifRandevular
            // 
            this.datagrid_AktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_AktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_AktifRandevular.Location = new System.Drawing.Point(2, 20);
            this.datagrid_AktifRandevular.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_AktifRandevular.Name = "datagrid_AktifRandevular";
            this.datagrid_AktifRandevular.Size = new System.Drawing.Size(527, 256);
            this.datagrid_AktifRandevular.TabIndex = 0;
            this.datagrid_AktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_AktifRandevular_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(834, 503);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "HASTA DETAYLARI";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_AktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richtxt_Sikayet;
        private System.Windows.Forms.ComboBox cmb_Doktor;
        private System.Windows.Forms.ComboBox cmb_Brans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_RandevuAl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView txt_ID;
        private System.Windows.Forms.DataGridView datagrid_AktifRandevular;
        private System.Windows.Forms.LinkLabel link_BilgileriDuzenle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
    }
}