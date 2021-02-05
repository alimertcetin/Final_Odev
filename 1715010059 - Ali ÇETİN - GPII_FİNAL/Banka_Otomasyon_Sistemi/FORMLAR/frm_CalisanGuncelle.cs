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
    public partial class frm_CalisanGuncelle : Form
    {
        public frm_CalisanGuncelle(Calisanlar calisan)
        {
            InitializeComponent();

            lbl_SicilNo.Text = calisan.c_SicilNo;
            txt_Ad.Text = calisan.c_Ad;
            txt_Soyad.Text = calisan.c_Soyad;
            txt_Maas.Text = calisan.c_Maas.ToString();
            txt_Prim.Text = calisan.c_Prim.ToString();

            BankDbEntities vt = new BankDbEntities();
            var RolListesi = FormYonetimi.MevkiListesi(vt, out string valueMember, out string displayMember);
            cmb_Mevki.ValueMember = valueMember;
            cmb_Mevki.DisplayMember = displayMember;
            cmb_Mevki.DataSource = RolListesi;
            cmb_Mevki.SelectedValue = calisan.c_Rolid;
        }

        private void frm_CalisanGuncelle_Load(object sender, EventArgs e)
        {
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_Maas.Text, out decimal maas))
                MessageBox.Show("Geçersiz maaş girişi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!decimal.TryParse(txt_Prim.Text, out decimal prim))
                MessageBox.Show("Geçersiz prim girişi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                BankDbEntities vt = new BankDbEntities();
                var calisan = vt.Calisanlar.FirstOrDefault(p => p.c_SicilNo == lbl_SicilNo.Text);
                calisan.c_Ad = txt_Ad.Text;
                calisan.c_Soyad = txt_Soyad.Text;
                calisan.c_Rolid = Convert.ToInt32(cmb_Mevki.SelectedValue);
                calisan.c_Maas = maas;
                calisan.c_Prim = prim;
                try
                {
                    if(vt.SaveChanges() > 0)
                    {
                        MessageBox.Show("Kayıt Güncellendi.", "Tebrikler", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FormYonetimi.FormlariBul(nameof(frm_CalisanlariGoruntule), out List<Form> frm_calisanlariGoruntuleListesi);
                        foreach (frm_CalisanlariGoruntule item in frm_calisanlariGoruntuleListesi)
                        {
                            item.TumCalisanlariGoruntule();
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu : " + hata);
                }

            }
        }

        private void btn_Geri_Click(object sender, EventArgs e) => Close();

    }
}
