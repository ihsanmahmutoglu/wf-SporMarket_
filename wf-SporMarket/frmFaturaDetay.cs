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
    public partial class frmFaturaDetay : Form
    {
        public frmFaturaDetay()
        {
            InitializeComponent();
        }

        private void frmFaturaDetay_Load(object sender, EventArgs e)
        {
            cFatura f = new cFatura();
            cUrunHareket_Satis uh = new cUrunHareket_Satis();
            DataTable dt = new DataTable();
            dt = f.FaturaBilgileriniGetir(cGenel.FaturaID);
            foreach (DataRow dr in dt.Rows)
            {
                txtFaturaKodu.Text = Convert.ToString(dr["FaturaKodu"]);
                txtFaturaTipi.Text = Convert.ToString(dr["FaturaTipi"]);
                txtMusteriadi.Text = Convert.ToString(dr["Ad"]);
                txtMusteriSoyadi.Text = Convert.ToString(dr["Soyad"]);
            }
            dt.Clear();
            dt = uh.KasaHareketleriniGetir(cGenel.FaturaID);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
               lvFaturaDetay.Items.Add( Convert.ToString(dr[0]));
                lvFaturaDetay.Items[i].SubItems.Add(dr[1].ToString());
                lvFaturaDetay.Items[i].SubItems.Add(dr[2].ToString());
                lvFaturaDetay.Items[i].SubItems.Add(dr[3].ToString());
                lvFaturaDetay.Items[i].SubItems.Add(dr[4].ToString());
                lvFaturaDetay.Items[i].SubItems.Add(dr[5].ToString());
                lvFaturaDetay.Items[i].SubItems.Add(dr[6].ToString());
                i++;
            }

        }
        private void Yazdır()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select FaturaKodu,FaturaTipi,IslemTipi,KdvliTopTutar,Ad,Soyad,Adet,KdvliTutar,BirimFiyat,UrunKodu,UrunAdi,Tarih,KdvsizTutar from vw_GunlukKasaSatis where FaturaKodu =@Kod", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = txtFaturaKodu.Text;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Yazdır();
        }

        private void reportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer1.Width = 10;
            reportViewer1.Height = 10;
        }
    }
}
