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
    public partial class frm_CalisanlariGoruntule : Form
    {
        public frm_CalisanlariGoruntule()
        {
            InitializeComponent();
        }

        private void frm_CalisanlariGoruntule_Load(object sender, EventArgs e)
        {
            TumCalisanlariGoruntule();
            dtv_Calisanlar.AutoGenerateColumns = false;
        }

        private void çalışanıGüncelleToolStripMenuItem_Click(object sender, EventArgs e) => GuncellemeformunuAc();
        private void btn_CalisanEkle_Click(object sender, EventArgs e) => FormYonetimi.TekliFormOlustur(typeof(frm_CalisanEkle));

        private class DataHolder
        {
            public string c_SicilNo { get; set; }
            public string c_Ad { get; set; }
            public string c_Soyad { get; set; }
            public string c_DogumYeri { get; set; }
            public string c_DogumTarihi { get; set; }
            public string RolAd { get; set; }
            public string c_Maas { get; set; }
            public string c_Prim { get; set; }
        }

        public void TumCalisanlariGoruntule()
        {
            BankDbEntities vt = new BankDbEntities();
            List<DataHolder> veriListesi = VeriListesiniAl_TumCalisanlar(vt);

            GridiBosaltVeKolonlariOlustur();
            dtv_Calisanlar.DataSource = veriListesi;
        }

        private static List<DataHolder> VeriListesiniAl_TumCalisanlar(BankDbEntities vt)
        {
            var sorgu =
                from c in vt.Calisanlar
                join r in vt.Roller on c.c_Rolid equals r.RolID
                select new
                {
                    c_SicilNo = c.c_SicilNo,
                    c_Ad = c.c_Ad,
                    c_Soyad = c.c_Soyad,
                    c_DogumYeri = c.c_DogumYeri,
                    c_DogumTarihi = c.c_DogumTarihi,
                    RolAd = r.RolAd,
                    c_Maas = c.c_Maas,
                    c_Prim = c.c_Prim
                };

            List<DataHolder> veriListesi = new List<DataHolder>();
            foreach (var item in sorgu.ToList())
            {
                DataHolder dh = new DataHolder();
                dh.c_SicilNo = item.c_SicilNo;
                dh.c_Ad = item.c_Ad;
                dh.c_Soyad = item.c_Soyad;
                dh.c_DogumYeri = item.c_DogumYeri;
                dh.c_DogumTarihi = item.c_DogumTarihi.ToShortDateString();
                dh.RolAd = item.RolAd;
                dh.c_Maas = item.c_Maas.ToString();
                dh.c_Prim = item.c_Prim == null ? "0" : item.c_Prim.ToString();

                veriListesi.Add(dh);
            }

            return veriListesi;
        }
        private static List<DataHolder> VeriListesiniAl_TekCalisan(BankDbEntities vt, string sicilNo)
        {
            var sorgu =
                from c in vt.Calisanlar
                join r in vt.Roller on c.c_Rolid equals r.RolID
                where c.c_SicilNo == sicilNo
                select new
                {
                    c_SicilNo = c.c_SicilNo,
                    c_Ad = c.c_Ad,
                    c_Soyad = c.c_Soyad,
                    c_DogumYeri = c.c_DogumYeri,
                    c_DogumTarihi = c.c_DogumTarihi,
                    RolAd = r.RolAd,
                    c_Maas = c.c_Maas,
                    c_Prim = c.c_Prim
                };

            List<DataHolder> veriListesi = new List<DataHolder>();
            foreach (var item in sorgu.ToList())
            {
                DataHolder dh = new DataHolder();
                dh.c_SicilNo = item.c_SicilNo;
                dh.c_Ad = item.c_Ad;
                dh.c_Soyad = item.c_Soyad;
                dh.c_DogumYeri = item.c_DogumYeri;
                dh.c_DogumTarihi = item.c_DogumTarihi.ToShortDateString();
                dh.RolAd = item.RolAd;
                dh.c_Maas = item.c_Maas.ToString();
                dh.c_Prim = item.c_Prim == null ? "0" : item.c_Prim.ToString();
                veriListesi.Add(dh);
            }

            return veriListesi;
        }

        private void GridiBosaltVeKolonlariOlustur()
        {
            dtv_Calisanlar.Columns.Clear();
            dtv_Calisanlar.DataSource = null;
            DataGridViewColumn SicilNo = FormYonetimi.ColumnOlustur("c_SicilNo", "Sicil Numarası");
            DataGridViewColumn Ad = FormYonetimi.ColumnOlustur("c_Ad", "Ad");
            DataGridViewColumn Soyad = FormYonetimi.ColumnOlustur("c_Soyad", "Soyad");
            DataGridViewColumn DogumYeri = FormYonetimi.ColumnOlustur("c_DogumYeri", "Doğum Yeri");
            DataGridViewColumn DogumTarihi = FormYonetimi.ColumnOlustur("c_DogumTarihi", "Doğum Tarihi");
            DataGridViewColumn RolAdi = FormYonetimi.ColumnOlustur("RolAd", "Mevkisi");
            DataGridViewColumn Maas = FormYonetimi.ColumnOlustur("c_Maas", "Maaş");
            DataGridViewColumn Prim = FormYonetimi.ColumnOlustur("c_Prim", "Prim");

            dtv_Calisanlar.Columns.Add(SicilNo);
            dtv_Calisanlar.Columns.Add(Ad);
            dtv_Calisanlar.Columns.Add(Soyad);
            dtv_Calisanlar.Columns.Add(DogumYeri);
            dtv_Calisanlar.Columns.Add(DogumTarihi);
            dtv_Calisanlar.Columns.Add(RolAdi);
            dtv_Calisanlar.Columns.Add(Maas);
            dtv_Calisanlar.Columns.Add(Prim);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_SicilNo.Text = string.Empty;
            TumCalisanlariGoruntule();
        }

        private void çalışanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisanlar calisan = null;
            BankDbEntities vt = new BankDbEntities();
            foreach (DataGridViewCell item in dtv_Calisanlar.CurrentRow.Cells)
            {
                if (item.ColumnIndex == 0)
                {
                    calisan = vt.Calisanlar.FirstOrDefault(p => p.c_SicilNo == item.Value.ToString());
                    break;
                }
            }
            if (calisan != null)
            {
                DialogResult result = MessageBox.Show($"{calisan.c_Ad} {calisan.c_Soyad} isimli {Environment.NewLine}" +
                    $"{calisan.c_SicilNo} sayılı sicil numarasına sahip çalışanı " + Environment.NewLine +
                    $"silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    vt.Calisanlar.Remove(calisan);
                    if (vt.SaveChanges() > 0)
                    {
                        TumCalisanlariGoruntule();
                        MessageBox.Show("Kayıt başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txt_SicilNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_SicilNo.Text))
            {
                lbl_Enter.Visible = false;
                return;
            }
            else
                lbl_Enter.Visible = true;

            if (e.KeyCode == Keys.Enter)
            {
                BankDbEntities vt = new BankDbEntities();
                var veriListesi = VeriListesiniAl_TekCalisan(vt, txt_SicilNo.Text);
                if (veriListesi.Count > 0)
                {
                    GridiBosaltVeKolonlariOlustur();
                    dtv_Calisanlar.DataSource = veriListesi;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sicil numarasına sahip bir çalışan bulunamadı.");
                    TumCalisanlariGoruntule();
                }

            }

        }
        
        private void GuncellemeformunuAc()
        {
            Calisanlar calisan = null;
            BankDbEntities vt = new BankDbEntities();
            foreach (DataGridViewCell item in dtv_Calisanlar.CurrentRow.Cells)
            {
                if (item.ColumnIndex == 0)
                {
                    calisan = vt.Calisanlar.FirstOrDefault(p => p.c_SicilNo == item.Value.ToString());
                    break;
                }
            }
            if (calisan != null)
            {
                frm_CalisanGuncelle frm = new frm_CalisanGuncelle(calisan);
                FormYonetimi.FormlariBul("frm_AnaSayfa", out List<Form> anaSayfa);
                frm.MdiParent = anaSayfa[0];
                frm.Show();
            }
            else MessageBox.Show("Bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
