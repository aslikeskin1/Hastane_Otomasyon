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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Doktora ait randevuları getirecegiz
            DataTable randevular = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + lbl_AdSoyad.Text + "'", bgl.baglanti());
            da.Fill(randevular);
            datagrid_Randevular.DataSource = randevular;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.TC = lbl_TC.Text;
            frm.Show();

        }

        private void btn_Duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datagrid_Randevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Randevu Detaya şikayeti aktarma:
            int secilen = datagrid_Randevular.SelectedCells[0].RowIndex;
            richtxt_RandevuDetay.Text = datagrid_Randevular.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
