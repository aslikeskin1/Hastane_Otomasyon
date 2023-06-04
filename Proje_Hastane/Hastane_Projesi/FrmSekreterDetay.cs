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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string sekreterTC;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbl_SekreterTC.Text=sekreterTC;

            //Ad soyad çekiyoruz:
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=" + sekreterTC, bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbl_AdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branşları datagride aktarma
            DataTable table1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from tbl_Branslar", bgl.baglanti());
            da.Fill(table1);
            btn_Duyurular.DataSource = table1;
            bgl.baglanti().Close();
            //doktorları datagride aktarma:
            DataTable table2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as Doktorlar,DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(table2);
            datagrid_doktorlar.DataSource = table2;
            bgl.baglanti().Close();
            //branşları comboboxa çekme:
            SqlCommand komut3 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                combo_Brans.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", masked_Tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", masked_Saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", combo_Brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", combo_Doktor.Text);
            komutkaydet.ExecuteNonQuery();
            masked_Tarih.Text = "";
            masked_Saat.Text = "";
            combo_Brans.Text = "";
            combo_Doktor.Text = "";
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void combo_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Doktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",combo_Brans.Text);
              SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read()) 
            {
                combo_Doktor.Items.Add(dr[0]+" " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular(duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rch_Duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
            rch_Duyuru.Clear();


        }

        private void btn_DoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void btn_BransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
        }

        private void btn_RandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
