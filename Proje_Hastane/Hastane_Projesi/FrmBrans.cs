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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            ap.Fill(table);
            datagrid_Branslar.DataSource = table;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", text_BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklensin Mi", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            text_BransAd.Text = "";
        }

        private void datagrid_Branslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = datagrid_Branslar.SelectedCells[0].RowIndex;
            text_ID.Text=datagrid_Branslar.Rows[secilen].Cells[0].Value.ToString();
            text_BransAd.Text=datagrid_Branslar.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Branslar where BransAd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", text_BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silinsin Mi?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", text_BransAd.Text);
            guncelle.Parameters.AddWithValue("@p2", text_ID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi.");
        }
    }
}
