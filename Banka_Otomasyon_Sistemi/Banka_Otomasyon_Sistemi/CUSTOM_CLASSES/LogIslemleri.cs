using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public static class LogIslemleri
    {
        /// <summary>
        /// Verilen değerlere göre bir banka hesabı Log'u oluşturur ve geri döndürür.
        /// </summary>
        /// <param name="KategoriID">1den 7ye kadar olan geçerli bir kategori ID girin (7 dahil).
        /// Not : Banka görevlisi tarafından yapılan işlemler için diğer yani 7 kategorisini kullanın.</param>
        public static islemler_BankaHesaplari BankHesapLogOlustur(string HesapNo, decimal islemTutari, string Aciklama, int KategoriID)
        {
            islemler_BankaHesaplari iBh = new islemler_BankaHesaplari();
            iBh.HesapNo = HesapNo;
            iBh.islemTutari = islemTutari;
            iBh.islemAciklama = Aciklama;
            iBh.islemKategori_id = KategoriID;
            iBh.islemTarihi = DateTime.Now;
            return iBh;
        }

        /// <summary>
        /// Verilen değerlere göre bir kredi hesabı Log'u oluşturur ve geri döndürür.
        /// </summary>
        /// <param name="KategoriID">1den 7ye kadar olan geçerli bir kategori ID girin (7 dahil).
        /// Not : Banka görevlisi tarafından yapılan işlemler için diğer yani 7 kategorisini kullanın.</param>
        public static islemler_KrediHesaplari KrediHesapLogOlustur(string HesapNo, decimal islemTutari, string Aciklama, int KategoriID)
        {
            islemler_KrediHesaplari iKh = new islemler_KrediHesaplari();
            iKh.HesapNo = HesapNo;
            iKh.islemTutari = islemTutari;
            iKh.islemAciklama = Aciklama;
            iKh.islemKategori_id = KategoriID;
            iKh.islemTarihi = DateTime.Now;
            return iKh;
        }

        public static void BankHesap_TumLoglariSil(BankDbEntities vt, Banka_Hesaplari silinecekHesap)
        {
            var LogList = from log in vt.islemler_BankaHesaplari where log.HesapNo == silinecekHesap.BankaHesapNo select log;
            foreach (var item in LogList)
            {
                vt.islemler_BankaHesaplari.Remove(item);
            }
        }

        public static void KkartHesap_TumLoglariSil(BankDbEntities vt, Kkart_Hesaplari silinecekHesap)
        {
            var LogList = from log in vt.islemler_KrediHesaplari where log.HesapNo == silinecekHesap.KkartHesapNo select log;
            foreach (var item in LogList)
            {
                vt.islemler_KrediHesaplari.Remove(item);
            }
        }


    }
}
