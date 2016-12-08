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
    public partial class frmKullaniciTanimlama : Form
    {
        public frmKullaniciTanimlama()
        {
            InitializeComponent();
        }

        private void frmKullaniciTanimlama_Load(object sender, EventArgs e)

        {
            this.Top =0;
            this.Left = 0;
            cKullanici k = new cKullanici();
            k.KullanicilariGetir(lvKullanicilar);
            Models.cKullaniciTipleri kt = new Models.cKullaniciTipleri();
            kt.KullaniciTurleriGetir(cbKullaniciTurleri);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            temizle();
        }
        private void temizle()
        {
            txtAd.Clear();
            txtSifre.Clear();
            txtSoyad.Clear();
            txtKullaniciID.Clear();
            txtTurID.Clear();
            txtTurAd.Clear();
            txtSifre.Clear();
            txtTurAd.Clear();
            txtSifreTekrar.Clear();
            txtAd.Focus();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtTurAd.Text.Trim() != "")
            {

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    cKullanici k = new cKullanici();
                    bool Sonuc = k.KullaniciKontrol(txtAd.Text, txtSoyad.Text);
                    if (Sonuc)
                    {
                        MessageBox.Show("Bu Kullanıcıi önceden kayıtlı!!");
                    }
                    else
                    {
                        k.KullaniciID = Convert.ToInt32(txtTurID.Text);
                        k.KullaniciTipi = Convert.ToInt32(txtTurID.Text);
                        k.Adi = txtAd.Text;
                        k.Soyadi = txtSoyad.Text;
                        k.Sifre = txtSifre.Text;
                        Sonuc = k.KullaniciEkle(k);

                        if (Sonuc)
                        {
                            MessageBox.Show("Kullanıcı Bilgileri Kayıt Edildi");
                            k.KullanicilariGetir(lvKullanicilar);
                            temizle();
                        }
                    }
                }
                else MessageBox.Show("Şifreler Birbiri İle Uyuşmuyor.");
            }
            else MessageBox.Show("Alanlar Boş Bırakılamaz.");
        }

        private void cbKullaniciTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.cKullaniciTipleri kt = (Models.cKullaniciTipleri)cbKullaniciTurleri.SelectedItem;
            txtTurAd.Text = kt.TurAd;
            txtTurID.Text = Convert.ToString(kt.KtipNo);
        }

        private void txtAdaGoreAra_TextChanged(object sender, EventArgs e)
        {
            cKullanici k = new cKullanici();
            k.KullanicilariGetirByAdaGore(lvKullanicilar, txtAdaGoreAra.Text);
        }

        private void lvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            txtKullaniciID.Text = lvKullanicilar.SelectedItems[0].SubItems[0].Text;
            cbKullaniciTurleri.Text = lvKullanicilar.SelectedItems[0].SubItems[1].Text;
            txtAd.Text = lvKullanicilar.SelectedItems[0].SubItems[3].Text;
            txtSoyad.Text = lvKullanicilar.SelectedItems[0].SubItems[4].Text;
            txtSifre.Text = lvKullanicilar.SelectedItems[0].SubItems[5].Text;
            txtSifreTekrar.Text = lvKullanicilar.SelectedItems[0].SubItems[5].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAd.Focus();
        }

        private void lvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtTurAd.Text.Trim() != "")
            {

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    cKullanici k = new cKullanici();
                    bool Sonuc = k.KullaniciKontrol(Convert.ToInt32(txtKullaniciID.Text), txtAd.Text, txtSoyad.Text);
                    if (Sonuc)
                    {
                        MessageBox.Show("Bu Kullanıcı önceden kayıtlı!!");
                    }
                    else
                    {
                        k.KullaniciID = Convert.ToInt32(txtKullaniciID.Text);
                        k.KullaniciTipi = Convert.ToInt32(txtTurID.Text);
                        k.Adi = txtAd.Text;
                        k.Soyadi = txtSoyad.Text;
                        k.Sifre = txtSifre.Text;
                        Sonuc = k.KullaniciGuncelle(k);
                        if (Sonuc)
                        {
                            MessageBox.Show("Kullanıcı Bilgileri Güncellendi");
                            k.KullanicilariGetir(lvKullanicilar);
                            btnSil.Enabled = false;
                            btnDegistir.Enabled = false;
                            btnKaydet.Enabled = true;
                            temizle();
                            txtAd.Focus();
                        }
                        else MessageBox.Show("Kulanıcı bilgileri Güncellenemedi", "Dikkat");
                    }
                }
                else MessageBox.Show("Şifreler Birbiri İle Uyuşmuyor.");
            }
            else MessageBox.Show("Alanlar Boş Bırakılamaz.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıdı Silmek İstediğinize Emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cKullanici k = new cKullanici();
                bool Sonuc = k.KullaniciSil(Convert.ToInt32(txtKullaniciID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Kullanıcı Bilgileri Silindi.");
                    k.KullanicilariGetir(lvKullanicilar);
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    btnKaydet.Enabled = true;
                    temizle();
                    txtAd.Focus();

                }
                else MessageBox.Show("Kulanıcı bilgileri Silinemedi.", "Dikkat");
            }

        }
    }
}
