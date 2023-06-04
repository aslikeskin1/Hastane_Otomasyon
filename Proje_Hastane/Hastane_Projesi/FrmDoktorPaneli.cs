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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void txt_Soyad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
         
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(table);
            datagrid_Doktorlar.DataSource = table;
            bgl.baglanti().Close();
            //branşları comboboxa çekme:
            SqlCommand komut3 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                combo_Brans.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", combo_Brans.Text);
            komut.Parameters.AddWithValue("@p4", masked_DoktorTC.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            combo_Brans.Text = "";
            masked_DoktorTC.Text = "";
            txt_Sifre.Text = "";
        }

        private void datagrid_Doktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = datagrid_Doktorlar.SelectedCells[0].RowIndex;
            txt_Ad.Text = datagrid_Doktorlar.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = datagrid_Doktorlar.Rows[secilen].Cells[2].Value.ToString();
            combo_Brans.Text = datagrid_Doktorlar.Rows[secilen].Cells[3].Value.ToString();
            masked_DoktorTC.Text = datagrid_Doktorlar.Rows[secilen].Cells[4].Value.ToString();
            txt_Sifre.Text = datagrid_Doktorlar.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_DoktorTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silinsin mi?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorTC=@P4,DoktorSifre=@p5 where DoktorTC=@P4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", combo_Brans.Text);
            komut.Parameters.AddWithValue("@p4", masked_DoktorTC.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
   
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
