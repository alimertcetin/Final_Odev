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
    public partial class frm_GecisHesapOlustur : Form
    {
        public frm_GecisHesapOlustur()
        {
            InitializeComponent();
        }

        private void btn_kGiris_Click(object sender, EventArgs e)
        {
            frm_YeniHesapOlustur yeniHesapOlustur = new frm_YeniHesapOlustur();
            yeniHesapOlustur.MdiParent = this.MdiParent;
            yeniHesapOlustur.Show();
            this.Close();
        }

        private void btn_pGiris_Click(object sender, EventArgs e)
        {
            frm_HesapOlustur HesapOlustur = new frm_HesapOlustur();
            HesapOlustur.MdiParent = this.MdiParent;
            HesapOlustur.Show();
            this.Close();
        }
    }
}
