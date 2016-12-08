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
    public partial class frmStokGirisCikis : Form
    {
        public frmStokGirisCikis()
        {
            InitializeComponent();
        }

        private void frmStokGirisCikis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SporMarketDataSet.vw_StokGiriscikis' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'SporMarketDataSet1.vw_StokGiriscikis' table. You can move, or remove it, as needed.

            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cbIrsaliyeTurleri.SelectedIndex = 0;


        }

        private void dtPTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtPTarih.Value.ToShortDateString();
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            frmTedarikciSorgulama f = new frmTedarikciSorgulama();
            f.ShowDialog();
            txtFırmaID.Text = cGenel.tedarikciID.ToString();
            txtFirma.Text = cGenel.tedarikciUnvan;
        }

        private void cbIrsaliyeTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIrsaliyeTuru.Text = cbIrsaliyeTurleri.SelectedItem.ToString();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            frmStokGoruntule f = new frmStokGoruntule();
            f.ShowDialog();
            txtUrunKodu.Text = cGenel.urunKodu;

        }
        cUrun u = new cUrun();
        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text.Length > 2)
            {

                u.UrunKoduGetir(lbUrunkodlari, txtUrunKodu.Text);
                if (lbUrunkodlari.Items.Count > 0)
                {
                    lbUrunkodlari.Visible = true;
                    lbUrunkodlari.SelectedIndex = 0;
                    if (lbUrunkodlari.SelectedItems[0].ToString() == txtUrunKodu.Text)
                    {
                        cUrun u = (cUrun)lbUrunkodlari.SelectedItem;
                        txtUrunKodu.Text = u.UrunKodu;
                        txtUrunID.Text = Convert.ToString(u.UrunID);
                        txtUrunAdi.Text = u.UrunAdi;
                        lbUrunkodlari.Visible = false;
                        txtUrunKodu.ReadOnly = true;
                        txtUrunAdi.ReadOnly = true;
                        txtAdet.Focus();
                    }
                }
                else
                {
                    lbUrunkodlari.Visible = false;
                    lbUrunkodlari.SelectedIndex = -1;
                }

            }

        }

        private void lbUrunkodlari_DoubleClick(object sender, EventArgs e)
        {
            cUrun u = (cUrun)lbUrunkodlari.SelectedItem; // lisxboxta seçiliolan obje türündenur nesnesini oluşturdu.
            txtUrunKodu.Text = u.UrunKodu;
            txtUrunID.Text = Convert.ToString(u.UrunID);
            txtUrunAdi.Text = u.UrunAdi;
            lbUrunkodlari.Visible = false;
            txtUrunKodu.ReadOnly = true;
            txtUrunAdi.ReadOnly = true;
            txtAdet.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void temizle()
        {
            txtUrunID.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            txtAdet.Clear();

            txtUrunKodu.ReadOnly = false;
            txtUrunAdi.ReadOnly = false;
            txtUrunKodu.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text.Trim() != "" && txtUrunKodu.Text.Trim() != "")
            {
                bool varmi = false;
                int i;
                for (i = 0; i < lvHareketler.Items.Count; i++)
                {
                    if (lvHareketler.Items[i].SubItems[0].Text == txtUrunID.Text)
                    {
                        varmi = true;
                        break;
                    }
                }
                if (varmi == false)
                {
                    lvHareketler.Items.Add(txtUrunID.Text);
                    lvHareketler.Items[lvHareketler.Items.Count - 1].SubItems.Add(txtUrunKodu.Text);
                    lvHareketler.Items[lvHareketler.Items.Count - 1].SubItems.Add(txtUrunAdi.Text);
                    lvHareketler.Items[lvHareketler.Items.Count - 1].SubItems.Add(txtAdet.Text);
                    temizle();
                }
                else
                {
                    int adet = Convert.ToInt32(lvHareketler.Items[i].SubItems[3].Text) + Convert.ToInt32(txtAdet.Text);
                    lvHareketler.Items[i].SubItems[3].Text = adet.ToString();
                    temizle();
                }

            }
            else MessageBox.Show("Ürün adeti/kodu Giriniz", "Dikkat");

        }

        private void btnÇıkar_Click(object sender, EventArgs e)
        {
            if (lvHareketler.SelectedIndices.Count == 1)
            {

                lvHareketler.Items.RemoveAt(lvHareketler.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Çıkartmak istediğini Ürünü Seçiniz");
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIrsaliye.Text.Trim() != "" || txtFirma.Text != "")
            {
                if (lvHareketler.Items.Count != 0)
                {
                    cIrsaliye irsaliye = new cIrsaliye();
                    irsaliye.IrsaliyeKodu = txtIrsaliye.Text;
                    irsaliye.FirmaID = Convert.ToInt32(txtFırmaID.Text);
                    irsaliye.KullaniciNo = cGenel.aktifkullaniciID;
                    irsaliye.IrsaliyeTarihi = Convert.ToDateTime(txtTarih.Text);
                    irsaliye.IrsaliyeTuru = txtIrsaliyeTuru.Text;
                    int irsaliyeID = irsaliye.irsaliyeEkle(irsaliye);
                    if (irsaliyeID > 0)
                    {
                        bool sonuc = false;
                        cUrunHareket_Stok uh = new cUrunHareket_Stok();
                        cUrun u = new cUrun();
                        for (int i = 0; i < lvHareketler.Items.Count; i++)
                        {
                            uh.UrunId = Convert.ToInt32(lvHareketler.Items[i].SubItems[0].Text);
                            uh.IrsaliyeNo = irsaliyeID;
                            uh.Miktar = Convert.ToInt32(lvHareketler.Items[i].SubItems[3].Text);
                            sonuc = uh.HareketEkle(uh);
                            if (sonuc)
                            {
                                if (txtIrsaliyeTuru.Text == "Çıkış")
                                {
                                    uh.Miktar = -1 * uh.Miktar;//stoktan çıkışsa eksi ile çarpılacak
                                }
                                sonuc = u.StokGuncelleFromStoku(uh.UrunId, uh.Miktar);
                            }
                        }
                        if (sonuc)
                        {
                            MessageBox.Show("Irsaliye Başarı ile Kayıt edildi");
                            Yazdır();
                           

                            temizle();

                        }
                        else
                            MessageBox.Show("Irsaliye kayıt sırasında sıkıntı yaşandı ");
                    }
                    else MessageBox.Show("IRsaliye Kayıt Edilemedi");
                }
                else
                {
                    MessageBox.Show("İrsaliye en az 1 ürün oluşturmak zorundadur.");
                }

            }
            else
            {
                MessageBox.Show("İrsaliye adı ve/veya Firma adı boş bırakılamaz.");
            }
        }

        private void Yazdır()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IRsaliyeNo,UrunKodu,UrunAdi,Miktar,IrsaliyeKodu,Unvan,IrsaliyeTuru from vw_StokGirisCikis where IrsaliyeKodu =@Kod", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = txtIrsaliye.Text;
            try
            {
                this.SporMarketDataSet.vw_StokGiriscikis.Clear();
                da.Fill(this.SporMarketDataSet.vw_StokGiriscikis);
                this.rvStokGirisCikis.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            rvStokGirisCikis.Visible = true;
            this.Width = 800;
            rvStokGirisCikis.Width = 800;
            rvStokGirisCikis.Height = 565;
        }

        private void rvStokGirisCikis_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            rvStokGirisCikis.Width = 25;
            rvStokGirisCikis.Height = 25;
            this.Width = 461;
            rvStokGirisCikis.Visible = false;
            txtIrsaliye.Clear();
            lvHareketler.Items.Clear();
        }
    }
}
