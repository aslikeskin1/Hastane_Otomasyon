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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            masked_TC.Text = TC;

            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                masked_TC.Text = dr[4].ToString();
                cmb_Brans.Text = dr[3].ToString();
                txt_Sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
            //cmboboxa branşalrı getirelim:

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2",txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3",cmb_Brans.Text);
            komut.Parameters.AddWithValue("@p4",txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p5",masked_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}
