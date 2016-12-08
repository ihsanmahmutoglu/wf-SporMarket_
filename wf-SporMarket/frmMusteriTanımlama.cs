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
    public partial class frmMusteriTanımlama : Form
    {
        public frmMusteriTanımlama()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        BindingSource bs1;
        private void frmMusteriTanımlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(lvMusteriler);
            ds = cm.MusterileriGetir();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Musteriler"];

            DataBagla();
            Konum();

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

        }
        private void DataBagla()
        {
            cMusteri cm = new cMusteri();
            ds = cm.MusterileriGetir();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Musteriler"];

            txtMusteriID.DataBindings.Clear();
            txtAdi.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            txtTelefon.DataBindings.Clear();
            txtAdres.DataBindings.Clear();
            txtil.DataBindings.Clear();
            txtilce.DataBindings.Clear();
            cbCinsiyet.DataBindings.Clear();

            txtMusteriID.DataBindings.Add("Text", bs1, "MusteriID");
            txtAdi.DataBindings.Add("Text", bs1, "Ad");
            txtSoyadi.DataBindings.Add("Text", bs1, "Soyad");
            txtTelefon.DataBindings.Add("Text", bs1, "Telefon");
            txtAdres.DataBindings.Add("Text", bs1, "Adres");
            txtil.DataBindings.Add("Text", bs1, "il");
            txtilce.DataBindings.Add("Text", bs1, "ilce");
            cbCinsiyet.DataBindings.Add("Text", bs1, "Cinsiyet");
        }
        private void Konum()
       {
        ////    bn1.Enabled = true;
        ////    bPosition.Text = (bs1.Position + 1).ToString();
        ////    bCount.Text = bs1.Count.ToString();
        }
        private void bnPrev_Click(object sender, EventArgs e)
        {
            bs1.Position -= 1;
            Konum();
        }

        private void bnFirst_Click(object sender, EventArgs e)
        {
            bs1.Position = 0;
            Konum();
        }

        private void bnNext_Click(object sender, EventArgs e)
        {
            bs1.Position += 1;
            Konum();
        }

        private void bnLast_Click(object sender, EventArgs e)
        {
            bs1.Position = bs1.Count - 1;
            Konum();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
        
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }
        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            cbCinsiyet.SelectedItem = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;
            txtil.Text = lvMusteriler.SelectedItems[0].SubItems[5].Text;
            txtilce.Text = lvMusteriler.SelectedItems[0].SubItems[6].Text;
            txtMusteriID.Text = lvMusteriler.SelectedItems[0].SubItems[7].Text;

            cMusteri u = new cMusteri();
            int kacinci = u.KacinciMusteri(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[7].Text));
            bs1.Position = kacinci;
            Konum();
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdi.Focus();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtAdi.Text +" isimli müşteriyi silmek istiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cMusteri cm = new cMusteri();
                if (cm.MusteriSil(Convert.ToInt32(txtMusteriID.Text)))
                {
                    MessageBox.Show("Müşteri Silindi silindi!");
                    cm.MusterileriGetir(lvMusteriler);
                    DataBagla();
                    Konum();
                }
                else MessageBox.Show("Müşteri silme işlemi tamamlanamadı!!!", "DİKKAT");
            }
        }

        private void btnDegistir_Click_1(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            if (cm.MusteriKontrol(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(txtMusteriID.Text)))
            {
                MessageBox.Show("Müşteri Kaydı bulunmaktadır!");
                txtAdi.Focus();
            }
            else
            {
                bs1.EndEdit();
                cm.MusteriID = Convert.ToInt32(txtMusteriID.Text);
                cm.Ad = txtAdi.Text;
                cm.Soyad = txtSoyadi.Text;
                cm.Telefon = txtTelefon.Text;
                cm.Adres = txtAdres.Text;
                cm.Il = txtil.Text;
                cm.Ilce = txtilce.Text;
                cm.Cinsiyet = cbCinsiyet.SelectedItem.ToString();

                if (cm.MusteriGuncelle(cm))
                {
                    MessageBox.Show("Müsteri güncellemesi başarılı!");
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;
                    cm.MusterileriGetir(lvMusteriler);
                    DataBagla();
                    Konum();
                }
                else { MessageBox.Show("Müşteri güncelleme işlemi gerçekleşemedi!!!", "HATA"); }
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text))
            {
                MessageBox.Show("Müşteri adı ve soyadı girilmelidir.");
                txtAdi.Focus();
            }
            else
            {
                cMusteri cm = new cMusteri();
                if (cm.MusteriKontrol(txtAdi.Text, txtSoyadi.Text))
                {
                    MessageBox.Show("Müşteri Kaydı bulunmaktadır!");
                    txtAdi.Focus();
                }
                else
                {
                    bs1.EndEdit();
                    cm.Ad = txtAdi.Text;
                    cm.Soyad = txtSoyadi.Text;
                    cm.Telefon = txtTelefon.Text;
                    cm.Adres = txtAdres.Text;
                    cm.Il = txtil.Text;
                    cm.Ilce = txtilce.Text;
                    cm.Cinsiyet = cbCinsiyet.SelectedItem.ToString();

                    if (cm.MusteriTanimla(cm))
                    {
                        MessageBox.Show("Müsteri Tanımlama başarılı!");
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;
                        cm.MusterileriGetir(lvMusteriler);
                        DataBagla();
                        Konum();
                    }
                    else { MessageBox.Show("Müşteri Tanımlama işlemi gerçekleşemedi!!!", "HATA"); }
                }
            }
        }

        private void btnYeni_Click_1(object sender, EventArgs e)
        {

            bs1.AddNew();
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtAdi.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
