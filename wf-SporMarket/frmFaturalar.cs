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
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }
   
        cFatura cf = new cFatura();
        string FaturaTipineGore = "";
        string IslemTipineGore = "";
        
        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SporMarketDataSet1.vw_Faturalar' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'SporMarketDataSet.vw_StokGiriscikis' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'SporMarketDataSet1.vw_Faturalar' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'SporMarketDataSet.vw_StokGiriscikis' table. You can move, or remove it, as needed.

            this.Top = 0;
            this.Left = 0;
            txtIlkTarih.Text = dtpFaturaIlkTarih.Value.ToShortDateString();
            txtSonTarih.Text = DateTime.Now.ToShortDateString();
            cf.FaturalariGetir(lvFaturalar);
            cbIslem.SelectedIndex = 0;
            cbFatura.SelectedIndex = 0;

        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void txtFaturaKodu_TextChanged(object sender, EventArgs e)
        {
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void cbFatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFatura.SelectedIndex == 0)
            {

                FaturaTipineGore = "";
            }
            else
            {
                FaturaTipineGore = cbFatura.SelectedItem.ToString();
            }
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void cbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIslem.SelectedIndex == 0)
            {
                IslemTipineGore = "";
            }
            else
            {
                IslemTipineGore = cbIslem.SelectedItem.ToString();
            }
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void lvFaturalar_DoubleClick(object sender, EventArgs e)
        {
            cGenel.FaturaID = Convert.ToInt32(lvFaturalar.SelectedItems[0].SubItems[5].Text);
            //cGenel.FaturaKodu = lvFaturalar.SelectedItems[0].SubItems[1].Text;
            //cGenel.MusteriID = Convert.ToInt32(lvFaturalar.SelectedItems[0].SubItems[6].Text);
            frmFaturaDetay f = new frmFaturaDetay();
            f.Show();
           
        }



 

        private void dtpFaturaIlkTarih_ValueChanged(object sender, EventArgs e)
        {
            txtIlkTarih.Text = dtpFaturaIlkTarih.Value.ToShortDateString();
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void dtpFaturaSonTarih_ValueChanged(object sender, EventArgs e)
        {
            txtSonTarih.Text = dtpFaturaSonTarih.Value.ToShortDateString();
            cFatura cf = new cFatura();
            cf.FaturalariGetirBySorgulama(txtMusteriAd.Text, txtFaturaKodu.Text, FaturaTipineGore, IslemTipineGore, lvFaturalar, txtIlkTarih.Text, txtSonTarih.Text);
        }

        private void btnDokuman_Click(object sender, EventArgs e)
        {
     
            SqlDataAdapter da = new SqlDataAdapter("Select FaturaKodu, FaturaTipi,IslemTipi,Tarih, Ad,Soyad from vw_Faturalar where FaturaKodu like @Kod and Ad like @Ad and FaturaTipi like @Tip and IslemTipi  like  @Itip and tarih between @tarih1 and @tarih2 ", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = txtFaturaKodu.Text + "%";
            da.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar).Value = txtMusteriAd .Text + "%";
            da.SelectCommand.Parameters.Add("@Tip", SqlDbType.VarChar).Value = FaturaTipineGore+"%";
            da.SelectCommand.Parameters.Add("@ITip", SqlDbType.VarChar).Value = IslemTipineGore+"%";
            da.SelectCommand.Parameters.Add("@tarih1", SqlDbType.Date).Value = txtIlkTarih.Text;
            da.SelectCommand.Parameters.Add("@tarih2", SqlDbType.Date).Value = txtSonTarih.Text;
            try
            {
                this.SporMarketDataSet1.vw_Faturalar.Clear();
                da.Fill((this.SporMarketDataSet1.vw_Faturalar));
                this.rvFatura.RefreshReport();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            rvFatura.Width= 760;
            this.Width = 760;
            rvFatura.Height = 560;
            rvFatura.Visible = true;
      

        }

        private void rvFatura_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            rvFatura.Width = 10;
            rvFatura.Height = 10;
            this.Width = 561;
            rvFatura.Visible = false ;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double top=0;
            for (int i = 0; i < lvFaturalar.Items.Count ; i++)
            {
                if (lvFaturalar.Items[i].SubItems[7].Text!="")
                {
                    top+= Convert.ToDouble(lvFaturalar.Items[i].SubItems[7].Text);
                }
            }
            txtToplamTutar.Text = top.ToString();
        }
    }
}
