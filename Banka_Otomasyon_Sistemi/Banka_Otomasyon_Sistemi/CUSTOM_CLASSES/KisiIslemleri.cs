using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public static class KisiIslemleri
    {
        /// <summary>
        /// Eğer müşteri daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool MusteriVeritabanindaVarMi(BankDbEntities vt, string tcNo)
        {
            var kisiKontrol = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == tcNo);
            if (kisiKontrol != null) return true;
            else return false;
        }
        /// <summary>
        /// Eğer müşteri daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool MusteriVeritabanindaVarMi(BankDbEntities vt, out Musteriler musteri, string tcNo)
        {
            musteri = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == tcNo);
            if (musteri != null) return true;
            else return false;
        }
        /// <summary>
        /// Eğer müşteri daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool MusteriVeritabanindaVarMi(BankDbEntities vt, string MusteriNo, out Musteriler musteri)
        {
            musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == MusteriNo);
            if (musteri != null) return true;
            else return false;
        }

        private static string Generate_MusteriNo()
        {
            string musteriNo = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                musteriNo += rnd.Next(0, 10).ToString();
            }
            return musteriNo;
        }
        /// <summary>
        /// Eğer aynı Müşteri No'ya sahip başka bir müşteri yoksa
        /// true döndürür.
        /// </summary>
        private static bool Kontrol_MusteriNo(BankDbEntities vt, string mNo)
        {
            var musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == mNo);

            if (musteri == null)
                return true;
            else
                return false;
        }
        public static string MusteriNoOlustur(BankDbEntities vt)
        {
            var musteriNo = Generate_MusteriNo();
            while (!Kontrol_MusteriNo(vt, musteriNo))
            {
                musteriNo = Generate_MusteriNo();
            }
            return musteriNo;
        }

        /// <summary>
        /// Eğer çalışan daha önce veritabanına kayıt edilmiş ise true döndürür.
        /// </summary>
        public static bool CalisanVeritabanindaVarMi(BankDbEntities vt, out Calisanlar calisan, string tcNo)
        {
            calisan = vt.Calisanlar.FirstOrDefault(p => p.c_TcNo == tcNo);
            if (calisan != null) return true;
            else return false;
        }

        private static string Generate_SicilNo()
        {
            string sicilNo = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                sicilNo += rnd.Next(0, 10).ToString();
            }
            return sicilNo;
        }
        /// <summary>
        /// Verilen SicilNo'ya sahip bir çalışan bulunamadıysa true döndürür.
        /// </summary>
        private static bool Kontrol_SicilNo(BankDbEntities vt, string SicilNo)
        {
            var calisan = vt.Calisanlar.FirstOrDefault(p => p.c_SicilNo == SicilNo);

            if (calisan == null)
                return true;
            else
                return false;
        }
        public static string SicilNoOlustur(BankDbEntities vt)
        {
            var sicilNo = Generate_SicilNo();
            while (!Kontrol_SicilNo(vt, sicilNo))
            {
                sicilNo = Generate_MusteriNo();
            }
            return sicilNo;
        }

        public static Musteriler MusteriOlustur(BankDbEntities vt, string tcNo, string ad, string soyad,
            string dogumYeri, string sifre, DateTime dogumTarihi)
        {
            Musteriler musteri = new Musteriler();
            musteri.MusteriNo = MusteriNoOlustur(vt);
            musteri.m_TcNo = tcNo;
            musteri.m_Ad = ad;
            musteri.m_Soyad = soyad;
            musteri.m_DogumTarihi = dogumTarihi;
            musteri.m_DogumYeri = dogumYeri;
            musteri.m_Rolid = 2;
            musteri.m_Sifre = sifre; //Şifre rastgele olarak da verilebilir.
            return musteri;
        }

        public static Calisanlar CalisanOlustur(BankDbEntities vt, string tcNo, string ad, string soyad,
            DateTime dogumTarihi, string dogumYeri, int RolId,decimal Maas, decimal Prim, string sifre)
        {
            Calisanlar calisan = new Calisanlar();
            calisan.c_SicilNo = SicilNoOlustur(vt);
            calisan.c_TcNo = tcNo;
            calisan.c_Ad = ad;
            calisan.c_Soyad = soyad;
            calisan.c_DogumTarihi = dogumTarihi;
            calisan.c_DogumYeri = dogumYeri;
            calisan.c_Rolid = RolId;
            calisan.c_Sifre = sifre; //Şifre rastgele olarak da verilebilir.
            calisan.c_Maas = Maas;
            calisan.c_Prim = Prim;
            return calisan;
        }

    }
}
