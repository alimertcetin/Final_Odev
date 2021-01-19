using System;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_MusteriGiris : Form
    {
        public frm_MusteriGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_mNo.Text) || string.IsNullOrEmpty(txt_mSifre.Text))
                MessageBox.Show("Alanlar boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                BankDbEntities vt = new BankDbEntities();
                var mNo = txt_mNo.Text;
                var mSifre = txt_mSifre.Text;
                var musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == mNo && p.m_Sifre == mSifre);
                if (musteri != null)
                {
                    frm_AnaSayfa anaSayfa = new frm_AnaSayfa(musteri);
                    anaSayfa.Show();
                    this.Hide();
                    anaSayfa.FormClosed += anaSayfa_FormClosed;
                }
                else
                    MessageBox.Show("Müşteri Numarası veya şifre hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anaSayfa_FormClosed(object sender, FormClosedEventArgs e) => this.Close();

        private void btn_Geri_Click(object sender, EventArgs e) => FormYonetimi.GirisEkraninaDon();
    }
}
