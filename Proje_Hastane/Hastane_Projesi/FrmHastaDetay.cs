using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            komut.Parameters.AddWithValue("@p2", richtxt_Sikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz alınmıştır.Randevu saatinden en az 15 dakika önce hazır olunuz.", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = TC;
            //TCyi yukarıda çektik,şimdi sıra ad ve soyad kısmını çekmekte.
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read()) 
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişini çekiyoruz:
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC=" + TC, bgl.baglanti());
            da.Fill(table);
            txt_ID.DataSource=table;

            //Branşları çekmek:
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            //aktif randevuları çekelim
            DataTable randevu= new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDurum=0", bgl.baglanti());
            dap.Fill(randevu);
            datagrid_AktifRandevular.DataSource = randevu;

;        }

        private void lbl_TC_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                cmb_Doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+cmb_Brans.Text+"'"+"and RandevuDoktor='"+cmb_Doktor.Text+"'", bgl.baglanti());
            da.Fill(dt);
            datagrid_AktifRandevular.DataSource= dt;
            bgl.baglanti().Close();
        }

        private void link_BilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frm = new FrmHastaBilgiDuzenle();
            frm.TC = lbl_TC.Text;
            frm.Show();
            
        }

        private void datagrid_AktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = datagrid_AktifRandevular.SelectedCells[0].RowIndex;
            txtid.Text = datagrid_AktifRandevular.Rows[secilen].Cells[0].Value.ToString();
            cmb_Brans.Text = datagrid_AktifRandevular.Rows[secilen].Cells[3].Value.ToString();
            cmb_Doktor.Text = datagrid_AktifRandevular.Rows[secilen].Cells[4].Value.ToString();
            
        }
    }
}
