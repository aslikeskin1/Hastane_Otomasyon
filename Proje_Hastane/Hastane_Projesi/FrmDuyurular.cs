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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter ad=new SqlDataAdapter("Select *from Tbl_Duyurular",bgl.baglanti());
            ad.Fill(table);
            datagrid_Duyurular.DataSource = table;

        }
    }
}
