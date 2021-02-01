using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Bulunduysa true döndürür.
        /// </summary>
        public static bool FormlariBul(string formAd, out List<Form> bulunanFormListesi)
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

        /// <summary>
        /// Eğer formun birden fazla örneği varsa bir tanesini aktif yapar ve diğerlerini kapatıp true döndürür.
        /// Açık bir örnek yoksa false döndürür.
        /// </summary>
        public static bool CloseAllInstance(string FormAdi)
        {
            FormYonetimi.FormlariBul(FormAdi, out List<Form> form);
            if (form.Count >= 1)
            {
                for (int i = 0; i < form.Count - 1; i++)
                {
                    form[i].Close();
                    form.Remove(form[i]);
                }
                form.ElementAt(0).Activate();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Eğer verilen türde açık form yoksa formu oluşturur. Açık form varsa aktif hale getirir.
        /// </summary>
        public static void TekliFormOlustur(Type t)
        {
            if (!CloseAllInstance(t.Name))
            {
                Form frm = (Form)Activator.CreateInstance(t);
                FormlariBul("frm_AnaSayfa", out List<Form> anaSayfa);
                frm.MdiParent = anaSayfa[0];
                frm.Show();
            }
        }

        public static DataGridViewColumn ColumnOlustur(string DataPropertyName, string Header)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = DataPropertyName;
            column.DataPropertyName = DataPropertyName;
            column.HeaderText = Header;
            return column;
        }

        public static List<Roller> MevkiListesi(BankDbEntities vt, out string ValueMember, out string DisplayMember)
        {
            ValueMember = "RolID";
            DisplayMember = "RolAd";
            var RolListesi = vt.Roller.ToList();
            for (int i = 0; i < RolListesi.Count; i++)
            {
                if (RolListesi[i].RolAd == "Müşteri")
                    RolListesi.Remove(RolListesi[i]);
            }
            return RolListesi;
        }

    }
}
