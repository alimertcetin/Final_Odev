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
    public partial class frm_CalisanEkle : Form
    {
        public frm_CalisanEkle()
        {
            InitializeComponent();
        }

        private void frm_CalisanEkle_Load(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();
            var RolListesi = FormYonetimi.MevkiListesi(vt, out string valueMember, out string displayMember);
            cmb_Mevki.ValueMember = valueMember;
            cmb_Mevki.DisplayMember = displayMember;
            cmb_Mevki.DataSource = RolListesi;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_Maas.Text, out decimal maas))
            {
                if (string.IsNullOrEmpty(txt_Maas.Text))
                    MessageBox.Show("Geçerisz maaş alanı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Geçerisz maaş girişi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (!decimal.TryParse(txt_Prim.Text, out decimal prim))
            {
                if (string.IsNullOrEmpty(txt_Prim.Text))
                    MessageBox.Show("Geçerisz prim alanı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Geçerisz prim girişi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string tcNo = txt_TcNo.Text;
            string ad = txt_Ad.Text;
            string soyad = txt_Soyad.Text;
            DateTime dogumTarihi = dtp_DogumTarihi.Value;
            string dogumYeri = txt_DogumYeri.Text;
            int RolId = Convert.ToInt32(cmb_Mevki.SelectedValue);
            string sifre = txt_Sifre.Text;
            string sifreTekrar = txt_SifreTekrar.Text;
            int dogumYili = dogumTarihi.Year;

            BankDbEntities vt = new BankDbEntities();

            if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) ||
               string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(sifre) ||
               string.IsNullOrEmpty(sifreTekrar) || string.IsNullOrEmpty(dogumYeri))
                MessageBox.Show("Alanlar boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if(KisiIslemleri.CalisanVeritabanindaVarMi(vt, out Calisanlar calisan,tcNo))
                MessageBox.Show("Böyle bir çalışan daha önce kayıt edilmiş! " +
                    "Çalışan Sicil No : " + calisan.c_SicilNo, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (sifre != sifreTekrar)
                MessageBox.Show("Girdiğiniz şifreler aynı değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(tcNo, out long ltcNo) || tcNo.Length != 11)
                MessageBox.Show("Tc No geçerli değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    KimlikSorgulama.KPSPublicSoapClient sorgu = new KimlikSorgulama.KPSPublicSoapClient();
                    if (!sorgu.TCKimlikNoDogrula(Convert.ToInt64(tcNo), ad, soyad, dogumYili))
                        MessageBox.Show("Kimlik Bilgileri geçersiz. Lütfen bilgileri tekrar kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var yeniCalisan = KisiIslemleri.CalisanOlustur(vt, tcNo, ad, soyad, dogumTarihi, dogumYeri, RolId, maas, prim, sifre);
                        vt.Calisanlar.Add(yeniCalisan);
                        if (vt.SaveChanges() > 0)
                            MessageBox.Show("Kayıt Başarılı.", "Tebrikler", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Kayıt Başarısız! " +
                                "Veritabanına kayıt edilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu : " + hata);
                }
            }
        }

    }
}
