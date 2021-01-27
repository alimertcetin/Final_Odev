using System;
using System.Collections.Generic;
using System.Linq;

namespace Banka_Otomasyon_Sistemi
{
    public static class HesapIslemleri
    {
        private static string Generate_HesapNo()
        {
            string hesapNo = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                hesapNo += rnd.Next(0, 10).ToString();
            }
            return hesapNo;
        }
        private static string Generate_IBAN()
        {
            string iban = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 24; i++)
            {
                iban += rnd.Next(0, 10).ToString();
            }
            iban = "TR" + iban;
            return iban;
        }

        /// <summary>
        /// Eğer aynı No'ya sahip başka bir hesap yoksa
        /// true döndürür.
        /// </summary>
        private static bool Kontrol_HesapNo(BankDbEntities vt, string hesapNo)
        {
            var bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == hesapNo);
            var kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == hesapNo);

            if (bh == null || kkh == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Eğer aynı No'ya sahip başka bir iban yoksa
        /// true döndürür.
        /// </summary>
        private static bool Kontrol_Iban(BankDbEntities vt, string _iban)
        {
            var bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankIban == _iban);
            var kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartIban == _iban);

            if (bh == null || kkh == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Veritabanında olmayan bir IBAN numarası oluşturur.
        /// </summary>
        public static string IbanOlustur(BankDbEntities vt)
        {
            var iban = Generate_IBAN();
            while (!Kontrol_Iban(vt, iban))
            {
                iban = Generate_IBAN();
            }

            return iban;
        }
        /// <summary>
        /// Veritabanında olmayan bir hesap numarası oluşturur.
        /// </summary>
        public static string HesapNoOlustur(BankDbEntities vt)
        {
            var hesapNo = Generate_HesapNo();
            while (!Kontrol_HesapNo(vt, hesapNo))
            {
                hesapNo = Generate_HesapNo();
            }

            return hesapNo;
        }

        public static Musteriler MusteriOlustur(string tcNo, string ad, string soyad, string dogumYeri, string sifre, DateTime dogumTarihi)
        {
            Musteriler musteri = new Musteriler();
            var mNo = Generate_HesapNo();
            musteri.MusteriNo = mNo.Substring(7, mNo.Length - 7);
            musteri.m_TcNo = tcNo;
            musteri.m_Ad = ad;
            musteri.m_Soyad = soyad;
            musteri.m_DogumTarihi = dogumTarihi;
            musteri.m_DogumYeri = dogumYeri;
            musteri.m_Rolid = 2;
            musteri.m_Sifre = sifre; //Şifre rastgele olarak da verilebilir.
            return musteri;
        }
        public static Banka_Hesaplari BankaHesabiOlustur(string tcNo, BankDbEntities vt)
        {
            Banka_Hesaplari bh = new Banka_Hesaplari();
            bh.BankaHesapNo = HesapNoOlustur(vt);
            bh.Hesap_Bakiye = 0;
            bh.HesapSahipTcno = tcNo;
            bh.BankIban = IbanOlustur(vt);
            return bh;
        }
        public static Kkart_Hesaplari KkartHesabiOlustur(string tcNo, BankDbEntities vt, decimal _limit,int _hesapKesimGunu, int _SonOdemeGunu)
        {
            Kkart_Hesaplari kh = new Kkart_Hesaplari();
            kh.KkartHesapNo = HesapNoOlustur(vt);
            kh.KkartIban = IbanOlustur(vt);
            kh.Kkart_Limit = _limit;
            kh.Kkart_Borc = 0;
            kh.HesapKesimGunu = _hesapKesimGunu;
            kh.SonOdemeGunu = _SonOdemeGunu;
            kh.HesapSahipTcno = tcNo;
            return kh;
        }

        /// <summary>
        /// Müşterinin sahip olduğu tüm hesapların hesap numaralarını döndürür.
        /// </summary>
        public static void Hesap_HesaplariBul(BankDbEntities vt, Musteriler musteri, out List<string> AllOwnedAccounts)
        {
            AllOwnedAccounts = new List<string>();
            var BHList = from hesap in vt.Banka_Hesaplari where hesap.HesapSahipTcno == musteri.m_TcNo select hesap;
            var KkhList = from hesap in vt.Kkart_Hesaplari where hesap.HesapSahipTcno == musteri.m_TcNo select hesap;
            if (BHList != null)
            {
                foreach (var item in BHList)
                {
                    AllOwnedAccounts.Add(item.BankaHesapNo);
                }
            }
            if (KkhList != null)
            {
                foreach (var item in KkhList)
                {
                    AllOwnedAccounts.Add(item.KkartHesapNo);
                }
            }
        }
        /// <summary>
        /// Müşterinin sahip olduğu banka hesaplarını döndürür.
        /// </summary>
        public static void Hesap_BankaHesaplariniBul(BankDbEntities vt, Musteriler musteri, out List<Banka_Hesaplari> AllBankAccounts)
        {
            AllBankAccounts = new List<Banka_Hesaplari>();
            var BHList = from hesap in vt.Banka_Hesaplari where hesap.HesapSahipTcno == musteri.m_TcNo select hesap;
            if (BHList != null)
            {
                foreach (var item in BHList)
                {
                    AllBankAccounts.Add(item);
                }
            }
        }
        /// <summary>
        /// Müşterinin sahip olduğu kredi hesaplarını döndürür.
        /// </summary>
        public static void Hesap_KrediHesaplariniBul(BankDbEntities vt, Musteriler musteri, out List<Kkart_Hesaplari> AllCreditAccounts)
        {
            AllCreditAccounts = new List<Kkart_Hesaplari>();
            var KkhList = from hesap in vt.Kkart_Hesaplari where hesap.HesapSahipTcno == musteri.m_TcNo select hesap;
            if (KkhList != null)
            {
                foreach (var item in KkhList)
                {
                    AllCreditAccounts.Add(item);
                }
            }
        }

        /// <summary>
        /// Verilen hesap numarasına göre bir Banka Hesabı arar.
        /// Hesap bulunamazsa null döndürür, bulunursa hesabı döndürür.
        /// </summary>
        public static Banka_Hesaplari Hesap_HesapGetirBank(BankDbEntities vt, string hesapNo)
        {
            var bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == hesapNo);

            if (bh != null)
                return bh;
            else
                return null;
        }
        /// <summary>
        /// Verilen hesap numarasına göre bir Kredi Hesabı arar.
        /// Hesap bulunamazsa null döndürür, bulunursa hesabı döndürür.
        /// </summary>
        public static Kkart_Hesaplari Hesap_HesapGetirKkart(BankDbEntities vt, string hesapNo)
        {
            var kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == hesapNo);

            if (kkh != null)
                return kkh;
            else
                return null;
        }

    }
}
