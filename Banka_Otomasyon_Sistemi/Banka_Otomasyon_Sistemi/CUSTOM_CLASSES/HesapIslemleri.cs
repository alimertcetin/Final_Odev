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

        public static Banka_Hesaplari BankaHesabiOlustur(string tcNo, BankDbEntities vt)
        {
            Banka_Hesaplari bh = new Banka_Hesaplari();
            bh.BankaHesapNo = HesapNoOlustur(vt);
            bh.Hesap_Bakiye = 0;
            bh.HesapSahipTcno = tcNo;
            bh.BankIban = IbanOlustur(vt);
            return bh;
        }
        public static Kkart_Hesaplari KkartHesabiOlustur(string tcNo, BankDbEntities vt, decimal _limit, int _hesapKesimGunu, int _SonOdemeGunu)
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

        /// <summary>
        /// Para Çekme işlemi başarılıysa true döndürür.
        /// </summary>
        public static bool hesaptanParaCek(BankDbEntities vt, int cekilecekMiktar, string HesapNo, string Aciklama, int KategoriID, out string Mesaj)
        {
            bool sonuc = false;
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == HesapNo);
            if (Bh != null)
            {
                if (Bh.Hesap_Bakiye - cekilecekMiktar >= 0)
                {
                    var log = LogIslemleri.BankHesapLogOlustur(Bh.BankaHesapNo, -cekilecekMiktar, Aciklama, KategoriID);
                    vt.islemler_BankaHesaplari.Add(log);
                    Bh.Hesap_Bakiye -= cekilecekMiktar;
                    if (vt.SaveChanges() > 0)
                    {
                        Mesaj = "İşlem başarılı! Şu anki bakiye : " + Bh.Hesap_Bakiye;
                        sonuc = true;
                    }
                    else
                    {
                        Mesaj = "İşlemi gerçekleştirirken bir hata oluştu!";
                        sonuc = false;
                    }
                }
                else
                {
                    Mesaj = "Yetersiz Bakiye!";
                    sonuc = false;
                }
            }
            else
            {
                var Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == HesapNo);
                if (Kkh != null)
                {
                    if (Kkh.Kkart_Borc + cekilecekMiktar <= Kkh.Kkart_Limit)
                    {
                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, -cekilecekMiktar, Aciklama, KategoriID);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc += cekilecekMiktar;
                        if (vt.SaveChanges() > 0)
                        {
                            Mesaj = "İşlem başarılı! Şu anki borç : " + Kkh.Kkart_Borc;
                            sonuc = true;
                        }
                        else
                        {
                            Mesaj = "İşlemi gerçekleştirirken bir hata oluştu!";
                            sonuc = false;
                        }
                    }
                    else
                    {
                        Mesaj = "Yetersiz Bakiye!";
                        sonuc = false;
                    }
                }
                else
                {
                    Mesaj = "Hesap Bulunamadı!";
                    sonuc = false;
                }
            }

            return sonuc;
        }

        /// <summary>
        /// Para Yatırma işlemi başarılıysa true döndürür.
        /// </summary>
        public static bool HesabaParaYatir(BankDbEntities vt, int yatirilacakMiktar, string HesapNo, string Aciklama, int KategoriID, out string Mesaj)
        {
            Mesaj = string.Empty;
            bool sonuc = false;
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == HesapNo);
            if (Bh != null)
            {
                var log = LogIslemleri.BankHesapLogOlustur(Bh.BankaHesapNo, yatirilacakMiktar, Aciklama, KategoriID);
                vt.islemler_BankaHesaplari.Add(log);

                Bh.Hesap_Bakiye += yatirilacakMiktar;
                if (vt.SaveChanges() > 0)
                {
                    Mesaj = "Para Yatırma işlemi Başarılı!";
                    sonuc = true;
                }
                else
                {
                    Mesaj = "İşlemi gerçekleştirirken bir hata oluştu!";
                    sonuc = false;
                }
            }
            else
            {
                var Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == HesapNo);

                if (Kkh != null)
                {
                    if (Kkh.Kkart_Borc - yatirilacakMiktar >= 0)
                    {
                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, yatirilacakMiktar, Aciklama, KategoriID);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc -= yatirilacakMiktar;

                        if (vt.SaveChanges() > 0)
                        {
                            Mesaj = "Para Yatırma işlemi Başarılı!";
                            sonuc = true;
                        }
                        else
                        {
                            Mesaj = "İşlemi gerçekleştirirken bir hata oluştu!";
                            sonuc = false;
                        }
                    }
                    else if (Kkh.Kkart_Borc - yatirilacakMiktar < 0) //Yatırılmak istenen para borçtan fazla ise
                    {
                        decimal borc = Convert.ToDecimal(Kkh.Kkart_Borc);
                        decimal fazlaPara = yatirilacakMiktar - borc;

                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, borc, Aciklama, KategoriID);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc = 0;

                        if (vt.SaveChanges() > 0)
                        {
                            Mesaj = "Para Yatırma işlemi Başarılı!" + Environment.NewLine +
                                "Hesaptaki borçtan fazla para yatırıldığı için " +
                                fazlaPara + "TL geri iade edilecek.";
                            sonuc = true;
                        }
                        else
                        {
                            Mesaj = "İşlemi gerçekleştirirken bir hata oluştu!";
                            sonuc = false;
                        }
                    }
                }
                else
                {
                    Mesaj = "Hesap Bulunamadı!";
                    sonuc = false;
                }
            }

            return sonuc;
        }


    }
}
