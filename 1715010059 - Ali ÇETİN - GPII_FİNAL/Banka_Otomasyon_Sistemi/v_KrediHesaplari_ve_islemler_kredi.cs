//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banka_Otomasyon_Sistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_KrediHesaplari_ve_islemler_kredi
    {
        public long KkartID { get; set; }
        public string KkartHesapNo { get; set; }
        public string KkartIban { get; set; }
        public decimal Kkart_Limit { get; set; }
        public decimal Kkart_Borc { get; set; }
        public int HesapKesimGunu { get; set; }
        public int SonOdemeGunu { get; set; }
        public string HesapSahipTcno { get; set; }
        public int islemID { get; set; }
        public string HesapNo { get; set; }
        public decimal islemTutari { get; set; }
        public string islemAciklama { get; set; }
        public int islemKategori_id { get; set; }
        public System.DateTime islemTarihi { get; set; }
    }
}
