using System.Collections.Generic;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public static class FormYonetimi
    {
        /// <summary>
        /// Açık olan bütün formları kapatır ve Seçim ekranını aktif hale getirir.
        /// </summary>
        public static void GirisEkraninaDon()
        {
            List<Form> Acikformlar = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                Acikformlar.Add(form);
            }
            foreach (Form form in Acikformlar)
            {
                if (form.Name != "frm_GirisSecimi")
                    form.Close();
                else
                {
                    form.Show();
                    form.Activate();
                }
            }
        }

        /// <summary>
        /// Verilen isme göre açık olan formlarda formu arar.
        /// Bulunduysa true döner.
        /// </summary>
        public static bool FormBul(string formAd, out List<Form> bulunanFormListesi)
        {
            bulunanFormListesi = new List<Form>();
            bool found = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formAd)
                {
                    found = true;
                    bulunanFormListesi.Add(form);
                }
            }
            return found;
        }

    }
}
