using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket
{
    public partial class frmKasaGunlukSatis : Form
    {
        public frmKasaGunlukSatis()
        {
            InitializeComponent();
        }

        private void frmKasaGunlukSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SporMarketDataSet2.vw_GunlukKasaSatis' table. You can move, or remove it, as needed.

            this.Top = 0;
            this.Left = 0;    
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Temizle();
            btnEkle.Enabled = true;
            cbFaturaTipi.SelectedIndex = 0;
            cbIslemTipi.SelectedIndex = 0;
     
        }
        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            txtUrunAdi.Focus();
        }

        private void dtpIlkTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpIlkTarih.Value.ToShortDateString();
        }
        private void cbFaturaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFaturaTipi.Text = cbFaturaTipi.SelectedItem.ToString();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteri.Text = cGenel.Musteri;
            txtMusteriNo.Text = cGenel.MusteriID.ToString();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text.Trim() != "")
            {
                double toplam = 0;
                bool varmi = false;
                int i;
                for (i = 0; i < lvKasaHareketleri.Items.Count; i++)
                {
                    if (lvKasaHareketleri.Items[i].SubItems[1].Text == txtUrunKodu.Text)
                    {
                        varmi = true;
                        break;
                    }
                }
                if (varmi == false)
                {
                    lvKasaHareketleri.Items.Add(txtUrunID.Text);
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add(txtUrunKodu.Text);
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add(txtUrunAdi.Text);
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add(txtFiyat.Text);
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add(txtAdet.Text);
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add((Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[4].Text) * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)).ToString());
                    lvKasaHareketleri.Items[lvKasaHareketleri.Items.Count - 1].SubItems.Add(((Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[4].Text) * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)) * 0.18 + Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[4].Text) * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)).ToString());
                    for (i = 0; i < lvKasaHareketleri.Items.Count; i++)
                    {
                        toplam += Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[6].Text);
                    }
                    txtToplamGiris.Text = toplam.ToString();
                    Temizle();
                }
                else
                {
                    int adet = Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[4].Text) + Convert.ToInt32(txtAdet.Text);
                    lvKasaHareketleri.Items[i].SubItems[4].Text = adet.ToString();
                    lvKasaHareketleri.Items[i].SubItems[5].Text = (adet * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)).ToString();
                    lvKasaHareketleri.Items[i].SubItems[6].Text = ((adet * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)) * 0.18 + adet * Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text)).ToString();
                    for (i = 0; i < lvKasaHareketleri.Items.Count; i++)
                    {
                        toplam += Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[6].Text);
                    }
                    txtToplamGiris.Text = toplam.ToString();
                }
            }
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            if (txtFaturaKodu.Text.Trim() != "")
            {
                if (lvKasaHareketleri.Items.Count != 0)
                {
                    cFatura f = new cFatura();
                    f.FaturaKodu = txtFaturaKodu.Text;
                    f.FaturaTipi = txtFaturaTipi.Text;
                    f.IslemTipi = txtIslemTipi.Text;
                    f.Tarih = Convert.ToDateTime(txtTarih.Text);
                    f.KullaniciNo = cGenel.aktifkullaniciID;
                    f.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    f.KdvliTopTutar = Convert.ToDouble(txtToplamGiris.Text);
                    int FaturaID = f.FaturaEkle(f);
                    if (FaturaID > 0)
                    {
                        bool sonuc = false;
                        cUrunHareket_Satis uhs = new cUrunHareket_Satis();
                        cUrun u = new cUrun();
                        for (int i = 0; i < lvKasaHareketleri.Items.Count; i++)
                        {
                            uhs.UrunNo = Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[0].Text);
                            uhs.FaturaNo = FaturaID;
                            uhs.BirimFiyat = Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[3].Text);
                            uhs.Adet = Convert.ToInt32(lvKasaHareketleri.Items[i].SubItems[4].Text);
                            sonuc = uhs.KasaHareketEkle(uhs);
                            if (sonuc)
                            {
                                if (txtFaturaTipi.Text == "Satış")
                                {
                                    uhs.Adet = -1 * uhs.Adet;
                                }
                                sonuc = u.StokGuncelleFromStoku(uhs.UrunNo, uhs.Adet);
                                Yazdır();
                                Temizle();
                                lvKasaHareketleri.Items.Clear();
                            }
                        }
                        if (sonuc)
                            MessageBox.Show("Fatura Başarı ile Kayıt edildi");
                        else
                            MessageBox.Show("Fatura kaydı durduruldu!!");
                    }
                    else MessageBox.Show("Fatura Kayıt Edilemedi!!");
                }
                else
                {
                    MessageBox.Show("Fatura en az 1 ürün oluşturmak zorundadır.");
                    txtAdet.Focus();
                }

            }
            else
            {
                MessageBox.Show("Fatura Kodu veya urun Kodu boş bırakılamaz.");
                txtFaturaKodu.Focus();
            }
        }

        private void Yazdır()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select FaturaKodu,FaturaTipi,IslemTipi,KdvliTopTutar,Ad,Soyad,Adet,KdvliTutar,BirimFiyat,UrunKodu,UrunAdi,Tarih,KdvsizTutar from vw_GunlukKasaSatis where FaturaKodu =@Kod", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = txtFaturaKodu .Text;
            try
            {
                this.SporMarketDataSet2.vw_GunlukKasaSatis.Clear();
                da.Fill(this.SporMarketDataSet2.vw_GunlukKasaSatis);
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            reportViewer1.Visible = true;
            reportViewer1.Width = 768;
            reportViewer1.Height = 613;
            this.reportViewer1.RefreshReport();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            frmStokGoruntule f = new frmStokGoruntule();
            f.ShowDialog();
            cUrun u = new cUrun();
            u = u.UrunleriGetirFromSatis(cGenel.urunID);
            txtUrunID.Text = u.UrunID.ToString();
            txtUrunKodu.Text = u.UrunKodu;
            txtUrunAdi.Text = u.UrunAdi;
            txtFiyat.Text = u.Birimfiyat.ToString();

        }

        private void btnÇıkar_Click(object sender, EventArgs e)
        {
            if (lvKasaHareketleri.SelectedIndices.Count == 1)
            {
                lvKasaHareketleri.Items.RemoveAt(lvKasaHareketleri.SelectedIndices[0]);
                double sonuc = 0;
                for (int i = 0; i < lvKasaHareketleri.Items.Count; i++)
                {
                    sonuc += Convert.ToDouble(lvKasaHareketleri.Items[i].SubItems[6].Text);
                }
                txtToplamGiris.Text = sonuc.ToString();
   
            }
        }

        private void cbFaturaTipi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFaturaTipi.Text = cbFaturaTipi.SelectedItem.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void cbIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTipi.Text = cbIslemTipi.SelectedItem.ToString();
        }



        private void reportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer1.Width = 10;
            reportViewer1.Height = 10;
        }
    }
}
