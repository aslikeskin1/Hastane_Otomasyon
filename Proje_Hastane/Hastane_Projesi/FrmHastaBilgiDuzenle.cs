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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            masked_TC.Text = TC;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC= "+TC,bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[1].ToString();
                masked_Telefonü.Text = dr[4].ToString();
                txt_Sifre.Text = dr[5].ToString();
                combo_Cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut.Parameters.Add("@p1", txt_Ad.Text);
            komut.Parameters.Add("@p2", txt_Soyad.Text);
            komut.Parameters.Add("@p3", masked_Telefonü.Text);
            komut.Parameters.Add("@p4", txt_Sifre.Text);
            komut.Parameters.Add("@p5", combo_Cinsiyet.Text);
            komut.Parameters.Add("@p6", TC);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
