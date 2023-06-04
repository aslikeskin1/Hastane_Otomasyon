﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class btn_Hasta : Form
    {
        public btn_Hasta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmHastaGiris frm = new FrmHastaGiris();
            frm.Show();
            this.Hide();
        }

        private void btn_Doktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm= new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void btn_Sekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            this.Hide();
        }
    }
}
