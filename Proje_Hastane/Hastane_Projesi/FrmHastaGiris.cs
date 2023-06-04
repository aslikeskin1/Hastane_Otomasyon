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
    public partial class FrmHastaGiris : Form
    {
        sqlbaglantisi bgl=new sqlbaglantisi();
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void linkLlb_HastaKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm=new FrmHastaKayit();
            frm.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_HastaTc.Text);
            komut.Parameters.AddWithValue("@p2", txt_HastaSifre.Text);
    

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.TC = masked_HastaTc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
             MessageBox.Show("Hatalı TC ve/veya Şifre! Tekrar Deneyiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
