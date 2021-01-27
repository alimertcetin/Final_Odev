using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public static class MusteriIslemleri
    {
        /// <summary>
        /// Eğer müşteri daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool KisiVeritabanındaVarMi(BankDbEntities vt, string tcNo)
        {
            var kisiKontrol = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == tcNo);
            if (kisiKontrol != null) return true;
            else return false;
        }
        /// <summary>
        /// Eğer müşteri daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool KisiVeritabanındaVarMi(BankDbEntities vt, out Musteriler musteri, string tcNo)
        {
            musteri = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == tcNo);
            if (musteri != null) return true;
            else return false;
        }

        /// <summary>
        /// Eğer müşteri veritabanında varsa true döndürür.
        /// </summary>
        public static bool KisiVeritabanındaVarMi(BankDbEntities vt, string MusteriNo, out Musteriler musteri)
        {
            var _musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == MusteriNo);
            if (_musteri != null)
            {
                musteri = _musteri;
                return true;
            }
            else
            {
                musteri = null;
                return false;
            }
        }


    }
}
