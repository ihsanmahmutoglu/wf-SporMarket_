using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }
        cKategori ck = new cKategori();
        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            ck.KategorileriGetir(lvKategoriler);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtKatogoriID.Clear();
            txtKategoriAdi.Clear();
            txtAciklama.Clear();
            txtKategoriAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() == " ")
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz!", "DİKKAT");
            }
            else
            {
                cKategori ck = new cKategori();
                if (ck.KategoriKontrol(txtKategoriAdi.Text))
                {
                    MessageBox.Show("Bu Kategori Daha Önceden Kayıtlı!");
                    txtKategoriAdi.Focus();
                }
                else
                {
                    ck.KategoriAd = txtKategoriAdi.Text;
                    ck.Aciklama = txtAciklama.Text;
                    if (ck.KategoriEkle(ck))
                    {
                        MessageBox.Show("Kategori Bilgileri Kayıt Edildi.");
                        ck.KategorileriGetir(lvKategoriler);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemleri Yapılamdı!", "DİKKAT");
                    }
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() == " ")
            {
                MessageBox.Show("Kategori Adı boş bırakılamaz.", "DİKKAT!");
                txtKategoriAdi.Focus();
            }
            else
            {
                cKategori ck = new cKategori();
                if (ck.KategoriKontrolByGuncelle(txtKategoriAdi.Text, Convert.ToInt32(txtKatogoriID.Text)))
                {
                    MessageBox.Show("Bu kategori daha önceden kayıt edilmiştir!", "DİKKAT");
                    txtKategoriAdi.Focus();
                }
                else
                {
                    ck.KategorileriGuncelle(txtKategoriAdi.Text, txtAciklama.Text, Convert.ToInt32(txtKatogoriID.Text));
                    MessageBox.Show("Değiştirme işleminiz tamamlanmıştır.", "BİLGİLENDİRME");
                    ck.KategorileriGetir(lvKategoriler);
                    Temizle();
                    txtKategoriAdi.Focus();
                    btnKaydet.Enabled = false;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silinsin mi?", "DIKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cKategori ck = new cKategori();
                if (ck.KategoriSil(Convert.ToInt32(txtKatogoriID.Text)))
                {
                    MessageBox.Show("Kategori Bilgileri Silindi", "BILGILENDIRME");
                    Temizle();
                    ck.KategorileriGetir(lvKategoriler);
                    btnDegistir.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                }
            }
        }

        private void lvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            txtKatogoriID.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
            txtKategoriAdi.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
            txtAciklama.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
            btnYeni.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtKategoriAdi.Focus();
        }
    }
}
