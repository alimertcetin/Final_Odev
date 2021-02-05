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
            FormYonetimi.TekliFormOlustur(typeof(frm_YeniHesapOlustur));
            this.Close();
        }

        private void btn_pGiris_Click(object sender, EventArgs e)
        {
            FormYonetimi.TekliFormOlustur(typeof(frm_HesapOlustur));
            this.Close();
        }
    }
}
