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
    public partial class frm_MusteriNoOgren : Form
    {
        public frm_MusteriNoOgren()
        {
            InitializeComponent();
        }

        private void txt_TcNo_TextChanged(object sender, EventArgs e)
        {
            lbl_Enter.Visible = string.IsNullOrEmpty(txt_TcNo.Text) ? false : true;

            if(txt_TcNo.Text.Length != 11 && !string.IsNullOrEmpty(txt_Ad.Text))
                AlanlariTemizle();
        }

        private void txt_TcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13) && txt_TcNo.Text.Length != 11)
            {
                MessageBox.Show("Geçersiz kimlik numarası girdiniz.",
                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.KeyChar == Convert.ToChar(13))
            {
                BankDbEntities vt = new BankDbEntities();
                if(!MusteriIslemleri.KisiVeritabanındaVarMi(vt, out Musteriler musteri, txt_TcNo.Text))
                {
                    AlanlariTemizle();

                    MessageBox.Show("Bu kimlik numarasına sahip bir müşteri bulunamadı.",
                        "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txt_Ad.Text = musteri.m_Ad;
                    txt_Soyad.Text = musteri.m_Soyad;
                    txt_MusteriNo.Text = musteri.MusteriNo;
                }
            }
        }

        void AlanlariTemizle()
        {
            txt_Ad.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            txt_MusteriNo.Text = string.Empty;
        }
    }
}
