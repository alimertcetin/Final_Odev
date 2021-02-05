using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_GirisSecimi : Form
    {
        public frm_GirisSecimi()
        {
            InitializeComponent();
        }

        public void btn_pGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_PersonelGiris personelGiris = new frm_PersonelGiris();
            personelGiris.Show();
        }

        private void btn_kGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_MusteriGiris musteriGiris = new frm_MusteriGiris();
            musteriGiris.Show();
        }
    }
}
