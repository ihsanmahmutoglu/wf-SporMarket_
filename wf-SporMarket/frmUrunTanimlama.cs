using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_SporMarket.Models;

namespace wf_SporMarket
{
    public partial class frmUrunTanimlama : Form
    {
        public frmUrunTanimlama()
        {
            InitializeComponent();
        }
        private void frmUrunTanimlama_Load(object sender, EventArgs e)
        {

            cUrun u = new cUrun();
            this.Left = 0;
            this.Top = 0;
            u.UrunleriGetir(lvUrunler);

            txtMarka.Clear();
            txtKategori.Clear();

            ArrayList klist = new ArrayList();
            cKategori k = new cKategori();
            klist = k.KategorileriGetir();
            foreach (cKategori kategori in klist)
            {
                cbKategoriler.Items.Add(kategori);
            }

            ArrayList mlist = new ArrayList();
            cMarka m = new cMarka();
            mlist = m.MarkalariGetir();
            foreach (cMarka marka in mlist)
            {
                cbMarka.Items.Add(marka);
            }
        }
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cKategori ck = (cKategori)cbKategoriler.SelectedItem;
            txtKategori.Text = ck.KategoriAd;
            txtKategoriNo.Text = Convert.ToString(ck.KategoriNo);
        }
        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cMarka cm = (cMarka)cbMarka.SelectedItem;
            txtMarka.Text = cm.MarkaAd;
            txtMarkaID.Text = cm.MarkaID.ToString();
        }
        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            txtUrunKodu.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtUrunAdi.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtMarka.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;
            txtKategori.Text = lvUrunler.SelectedItems[0].SubItems[3].Text;
            txtNumara.Text = lvUrunler.SelectedItems[0].SubItems[4].Text;
            txtBirimFiyat.Text = lvUrunler.SelectedItems[0].SubItems[5].Text;
            txtStokMiktar.Text = lvUrunler.SelectedItems[0].SubItems[6].Text;
            txtKritikSeviye.Text = lvUrunler.SelectedItems[0].SubItems[7].Text;
            txtUrunID.Text = lvUrunler.SelectedItems[0].SubItems[8].Text;
            txtKategoriNo.Text = lvUrunler.SelectedItems[0].SubItems[9].Text;
            txtMarkaID.Text = lvUrunler.SelectedItems[0].SubItems[10].Text;
           
            btnYeni.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtUrunAdi.Focus();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {Temizle();
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
            txtStokMiktar.Text = "10";
            
        }
        private void Temizle()
        {
            txtUrunKodu.Clear();
            txtUrunAdi.Clear();
            txtKategori.Clear();
            txtMarka.Clear();
            txtNumara.Clear();
            txtBirimFiyat.Clear();
            txtKritikSeviye.Clear();
            txtUrunID.Clear();
            txtKategoriNo.Clear();
            txtMarkaID.Clear();
            txtUrunAdi.Focus();
            txtStokMiktar.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text.Trim() == "" && txtKategori.Text.Trim() == "" && txtMarka.Text.Trim() == "" && txtNumara.Text.Trim() == "" && txtBirimFiyat.Text.Trim() == "" && txtStokMiktar.Text.Trim() == "" && txtKritikSeviye.Text.Trim() == "")
            {
                MessageBox.Show("Bilgileri Eksiksiz Doldurunuz!", "DİKKAT");
            }
            else
            {
                cUrun u = new cUrun();
                if (u.UrunKontrol(txtUrunKodu.Text, txtUrunAdi.Text))
                {
                    MessageBox.Show("Bu Urun Daha Önceden Kayıtlı!");
                    txtUrunKodu.Focus();
                }
                else
                {
                    if (u.UrunEkle(txtUrunKodu.Text, txtUrunAdi.Text, Convert.ToInt32(txtKategoriNo.Text), Convert.ToInt32(txtMarkaID.Text), Convert.ToInt32(txtNumara.Text), Convert.ToDouble(txtBirimFiyat.Text), Convert.ToInt32(txtKritikSeviye.Text)))
                    {
                        MessageBox.Show("Urun Bilgileri Kayıt Edildi.");
                        u.UrunleriGetir(lvUrunler);
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
            if (txtUrunAdi.Text.Trim() == "" && txtKategori.Text.Trim() == "" && txtMarka.Text.Trim() == "" && txtNumara.Text.Trim() == "" && txtBirimFiyat.Text.Trim() == "" && txtStokMiktar.Text.Trim() == "" && txtKritikSeviye.Text.Trim() == "")
            {
                MessageBox.Show("Bilgileri Eksiksiz Doldurunuz!", "DİKKAT");
            }
            else
            {
                cUrun u = new cUrun();
                if (u.Varmi(Convert.ToInt32(txtUrunID.Text), txtUrunKodu.Text))
                {
                    MessageBox.Show("Bu ürün daha önceden kayıt edilmiştir!", "DİKKAT");
                    txtUrunKodu.Focus();
                }
                else
                {
                    u.UrunGuncelle(Convert.ToInt32(txtUrunID.Text),txtUrunKodu.Text, txtUrunAdi.Text, Convert.ToInt32(txtKategoriNo.Text), Convert.ToInt32(txtMarkaID.Text), Convert.ToInt32(txtNumara.Text), Convert.ToDouble(txtBirimFiyat.Text), Convert.ToInt32(txtKritikSeviye.Text));
                    MessageBox.Show("Değiştirme işleminiz tamamlanmıştır.", "BİLGİLENDİRME");
                    u.UrunleriGetir(lvUrunler);
                    Temizle();
                    txtUrunKodu.Focus();
                    btnKaydet.Enabled = false;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cUrun u = new cUrun();
                if (u.UrunSil(Convert.ToInt32(txtUrunID.Text)))
                {
                    MessageBox.Show("Urun bilgisi başarıyla silindi", "Bilgilendirme");
                    u.UrunleriGetir(lvUrunler);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                }
            }
        }
    }
}


