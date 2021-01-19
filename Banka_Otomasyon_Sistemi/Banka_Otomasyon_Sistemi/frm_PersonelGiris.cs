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
    public partial class frm_PersonelGiris : Form
    {
        public frm_PersonelGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calisanSicilNo = txt_SicilNo.Text;
            string calisanSifre = txt_Sifre.Text;

            if (string.IsNullOrEmpty(calisanSicilNo) || string.IsNullOrEmpty(calisanSifre))
                MessageBox.Show("Sicil No veya şifre boş olamaz. Lütfen bilgileri tam girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                BankDbEntities vt = new BankDbEntities();
                Calisanlar calisan = vt.Calisanlar.FirstOrDefault(p => p.c_SicilNo == calisanSicilNo && p.c_Sifre == calisanSifre);
                if (calisan != null)
                {
                    frm_AnaSayfa anaSayfa = new frm_AnaSayfa(calisan);
                    anaSayfa.Show();
                    this.Hide();
                    anaSayfa.FormClosed += anaSayfa_FormClosed;
                }
                else
                    MessageBox.Show("Sicil No veya şifre hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void anaSayfa_FormClosed(object sender, FormClosedEventArgs e) => this.Close();

        private void btn_Geri_Click(object sender, EventArgs e) => FormYonetimi.GirisEkraninaDon();
    }
}