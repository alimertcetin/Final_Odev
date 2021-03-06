﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_HesapGoruntule : Form
    {
        Musteriler musteri;
        public Musteriler Musteri { get => musteri; private set => musteri = value; }
        Calisanlar calisan;
        public Calisanlar Calisan { get => calisan; private set => calisan = value; }

        public frm_HesapGoruntule(Calisanlar calisan)
        {
            InitializeComponent();
            cmb_HesapListesi.SelectedIndex = 0;
            dtg_HesapGoruntule.AutoGenerateColumns = false;
            menu_Musteri.Hide();
            menu_Calisan.Show();
        }
        public frm_HesapGoruntule(Musteriler musteri)
        {
            InitializeComponent();

            cmb_HesapListesi.SelectedIndex = 0;
            dtg_HesapGoruntule.AutoGenerateColumns = false;

            menu_Calisan.Hide();
            menu_Musteri.Show();

            Musteri = musteri;
            txt_MusteriNo.Text = Musteri.MusteriNo;
            txt_MusteriNo.ReadOnly = true;
        }

        private void frm_HesapGoruntule_Load(object sender, EventArgs e)
        {
            if (Musteri != null && !string.IsNullOrEmpty(txt_MusteriNo.Text) && !HesaplariGoruntule())
                MessageBox.Show("Hesaplar görüntülenirken bir sorunla karşılaşıldı. " +
                    "Lütfen müşteri numaranızın doğru olduğundan emin olun. " +
                    "Detaylı yardım almak için banka personelleriyle iletişime geçin.", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public void GridYenile() => HesaplariGoruntule();
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => HesaplariGoruntule();
        private void cmb_HesapListesi_SelectedIndexChanged(object sender, EventArgs e) => HesaplariGoruntule();
        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e) => FormuAc(true);
        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e) => FormuAc(false);

        private void txt_MusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13) && !HesaplariGoruntule())
                MessageBox.Show("Geçerli bir Müşteri Numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        /// <summary>
        /// Görüntüleme işlemi başarılıysa true döndürür.
        /// </summary>
        private bool HesaplariGoruntule()
        {
            BankDbEntities vt = new BankDbEntities();
            musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == txt_MusteriNo.Text);
            if (musteri != null)
            {
                switch (cmb_HesapListesi.SelectedIndex)
                {
                    case (0):
                        HesapIslemleri.Hesap_BankaHesaplariniBul(vt, musteri, out List<Banka_Hesaplari> bankAccounts);

                        dtg_HesapGoruntule.DataSource = null;
                        dtg_HesapGoruntule.Columns.Clear();

                        DataGridViewColumn clm_BankHesapNo = FormYonetimi.ColumnOlustur("BankaHesapNo", "Hesap Numarası");
                        DataGridViewColumn clm_Iban = FormYonetimi.ColumnOlustur("BankIban", "Iban");
                        DataGridViewColumn clm_Bakiye = FormYonetimi.ColumnOlustur("Hesap_Bakiye", "Bakiye");

                        dtg_HesapGoruntule.Columns.Add(clm_BankHesapNo);
                        dtg_HesapGoruntule.Columns.Add(clm_Iban);
                        dtg_HesapGoruntule.Columns.Add(clm_Bakiye);

                        dtg_HesapGoruntule.DataSource = bankAccounts;
                        break;

                    case (1):
                        HesapIslemleri.Hesap_KrediHesaplariniBul(vt, musteri, out List<Kkart_Hesaplari> CreditAccounts);

                        dtg_HesapGoruntule.DataSource = null;
                        dtg_HesapGoruntule.Columns.Clear();

                        DataGridViewColumn clm_KkartHesapNo = FormYonetimi.ColumnOlustur("KkartHesapNo", "Hesap Numarası");
                        DataGridViewColumn clm_KkartIban = FormYonetimi.ColumnOlustur("KkartIban", "Iban");
                        DataGridViewColumn clm_KkartLimit = FormYonetimi.ColumnOlustur("Kkart_Limit", "Hesap Limiti");
                        DataGridViewColumn clm_KkartBorc = FormYonetimi.ColumnOlustur("Kkart_Borc", "Borç");
                        DataGridViewColumn clm_KkartKesimGunu = FormYonetimi.ColumnOlustur("HesapKesimGunu", "Hesap Kesim Günü");
                        DataGridViewColumn clm_KkartSonOdemeGunu = FormYonetimi.ColumnOlustur("SonOdemeGunu", "Son Ödeme Günü");

                        dtg_HesapGoruntule.Columns.Add(clm_KkartHesapNo);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartIban);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartLimit);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartBorc);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartKesimGunu);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartSonOdemeGunu);

                        dtg_HesapGoruntule.DataSource = CreditAccounts;
                        break;

                    default:
                        break;
                }

                txt_Ad.Text = musteri.m_Ad;
                txt_Soyad.Text = musteri.m_Soyad;
                txt_TcNo.Text = musteri.m_TcNo;
                return true;
            }
            else return false;
        }

        private void FormuAc(bool ParaCekilecekMi)
        {
            if (musteri == null)
                MessageBox.Show("Geçerli bir Müşteri Numarası girin ve Giriş(Enter) tuşuna basın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtg_HesapGoruntule.CurrentCell == null || dtg_HesapGoruntule.CurrentCell.ColumnIndex != 0)
                MessageBox.Show("Lütfen para çekmek istediğiniz hesap numarasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                frm_ParaCekYatir paraCek = new frm_ParaCekYatir(dtg_HesapGoruntule.CurrentCell.Value.ToString(), ParaCekilecekMi);
                paraCek.MdiParent = this.MdiParent;
                paraCek.Show();
            }
        }

        private void hesapHareketleriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteri == null)
                MessageBox.Show("Bir sorun oluştu. Tekrar giriş yapmayı deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtg_HesapGoruntule.CurrentCell == null || dtg_HesapGoruntule.CurrentCell.ColumnIndex != 0)
                MessageBox.Show("Lütfen rapor almak istediğiniz hesap numarasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                frm_HesapRaporuAl form = new frm_HesapRaporuAl(dtg_HesapGoruntule.CurrentCell.Value.ToString());
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void hesapRaporuAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (musteri == null)
                MessageBox.Show("Geçerli bir Müşteri Numarası girin ve Giriş(Enter) tuşuna basın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtg_HesapGoruntule.CurrentCell == null || dtg_HesapGoruntule.CurrentCell.ColumnIndex != 0)
                MessageBox.Show("Lütfen rapor almak istediğiniz hesap numarasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(FormYonetimi.FormlariBul(nameof(frm_HesapRaporuAl), out List<Form> hesapRaporFormlari))
            {
                // Açık olan formlar arasında aynı hesabı görüntüleyen form yoksa
                // seçilen hesap numarasının hesap hareketlerini görüntüle
                bool formAc = false;
                foreach (frm_HesapRaporuAl item in hesapRaporFormlari)
                {
                    if (item.HesapNumarasi != dtg_HesapGoruntule.CurrentCell.Value.ToString())
                        formAc = true;
                    else
                    {
                        formAc = false;
                        item.Activate();
                        break;
                    }
                }
                if (formAc)
                {
                    frm_HesapRaporuAl form = new frm_HesapRaporuAl (dtg_HesapGoruntule.CurrentCell.Value.ToString());
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
            }
            else //Verilen isimde açık hiç bir form yoksa
            {
                frm_HesapRaporuAl form = new frm_HesapRaporuAl(dtg_HesapGoruntule.CurrentCell.Value.ToString());
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void kategorilereGöreHarcamayıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteri == null)
                MessageBox.Show("Geçerli bir Müşteri Numarası girin ve Giriş(Enter) tuşuna basın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtg_HesapGoruntule.CurrentCell == null || dtg_HesapGoruntule.CurrentCell.ColumnIndex != 0)
                MessageBox.Show("Lütfen rapor almak istediğiniz hesap numarasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (FormYonetimi.FormlariBul(nameof(frm_KategorilereGoreRapor), out List<Form> KategorilerRaporFormlari))
            {
                // Açık olan formlar arasında aynı hesabı görüntüleyen form yoksa
                // seçilen hesap numarasının hesap hareketlerini görüntüle
                bool formAc = false;
                foreach (frm_KategorilereGoreRapor item in KategorilerRaporFormlari)
                {
                    if (item.HesapNumarasi != dtg_HesapGoruntule.CurrentCell.Value.ToString())
                    {
                        formAc = true;
                    }
                    else
                    {
                        formAc = false;
                        item.Activate();
                        break;
                    }
                }
                if (formAc)
                {
                    frm_KategorilereGoreRapor form = new frm_KategorilereGoreRapor
                        (dtg_HesapGoruntule.CurrentCell.Value.ToString(), cmb_HesapListesi.SelectedIndex);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
            }
            else //Verilen isimde açık hiç bir form yoksa
            {
                frm_KategorilereGoreRapor form = new frm_KategorilereGoreRapor
                    (dtg_HesapGoruntule.CurrentCell.Value.ToString(), cmb_HesapListesi.SelectedIndex);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void krediEkstreRaporuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteri == null)
                MessageBox.Show("Geçerli bir Müşteri Numarası girin ve Giriş(Enter) tuşuna basın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtg_HesapGoruntule.CurrentCell == null || dtg_HesapGoruntule.CurrentCell.ColumnIndex != 0)
                MessageBox.Show("Lütfen rapor almak istediğiniz hesap numarasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cmb_HesapListesi.SelectedIndex != 1)
                MessageBox.Show("Bir Kredi hesabı seçmeniz gerek.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (FormYonetimi.FormlariBul(nameof(frm_KrediEkstre), out List<Form> krediEkstreFormlari))
            {
                // Açık olan formlar arasında aynı hesabı görüntüleyen form yoksa
                // seçilen hesap numarasının hesap hareketlerini görüntüle
                bool formAc = false;
                foreach (frm_KrediEkstre item in krediEkstreFormlari)
                {
                    if (item.HesapNumarasi != dtg_HesapGoruntule.CurrentCell.Value.ToString())
                    {
                        formAc = true;
                    }
                    else
                    {
                        formAc = false;
                        item.Activate();
                        break;
                    }
                }
                if (formAc)
                {
                    frm_KrediEkstre form = new frm_KrediEkstre
                        (dtg_HesapGoruntule.CurrentCell.Value.ToString(), cmb_HesapListesi.SelectedIndex);
                    form.MdiParent = this.MdiParent;
                    form.Show();
                }
            }
            else //Verilen isimde açık hiç bir form yoksa
            {
                frm_KrediEkstre form = new frm_KrediEkstre
                    (dtg_HesapGoruntule.CurrentCell.Value.ToString(), cmb_HesapListesi.SelectedIndex);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        private void txt_MusteriNo_TextChanged(object sender, EventArgs e)
        {
            lbl_Enter.Visible = string.IsNullOrEmpty(txt_MusteriNo.Text) ? false : true;
            dtg_HesapGoruntule.DataSource = null;
            txt_Ad.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            txt_TcNo.Text = string.Empty;
        }

        private void işlemleriGrafikteGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategorilereGöreHarcamayıGörToolStripMenuItem_Click(sender, e);
        }

        private void krediEkstreRaporuAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            krediEkstreRaporuAlToolStripMenuItem_Click(sender, e);
        }
    }
}
