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
    public partial class frmIrsaliyeler : Form
    {
        public frmIrsaliyeler()
        {
            InitializeComponent();
        }

        cIrsaliye ci = new cIrsaliye();
        string IrsaliyeTuruneGore = "";

        private void frmIrsaliyeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SporMarketDataSet3.vw_Irsaliyeler' table. You can move, or remove it, as needed.

            this.Top = 0;
            this.Left = 0;

            txtIlkTarih.Text = dtpFaturaIlkTarih.Value.ToShortDateString();
            txtSonTarih.Text = DateTime.Now.ToShortDateString();
            ci.IrsaliyeleriGetir(lvIrsaliyeler);
            cbIrsaliyeTuruneGore.SelectedIndex = 0;

        }

        private void txtUnvanaGore_TextChanged(object sender, EventArgs e)
        {
            cIrsaliye ci = new cIrsaliye();
            ci.IrsaliyeleriGetirBySorgulama(txtUnvanaGore.Text, txtIrsaliyeKodunaGore.Text, IrsaliyeTuruneGore, lvIrsaliyeler, Convert.ToDateTime(txtIlkTarih.Text), Convert.ToDateTime(txtSonTarih.Text));
        }

        private void txtIrsaliyeKodunaGore_TextChanged(object sender, EventArgs e)
        {
            cIrsaliye ci = new cIrsaliye();
            ci.IrsaliyeleriGetirBySorgulama(txtUnvanaGore.Text, txtIrsaliyeKodunaGore.Text, IrsaliyeTuruneGore, lvIrsaliyeler, Convert.ToDateTime(txtIlkTarih.Text), Convert.ToDateTime(txtSonTarih.Text));
        }

        private void cbIrsaliyeTuruneGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIrsaliyeTuruneGore.SelectedIndex == 0)
            {

                IrsaliyeTuruneGore = "";
            }
            else
            {
                IrsaliyeTuruneGore = cbIrsaliyeTuruneGore.SelectedItem.ToString();
            }
            cIrsaliye ci = new cIrsaliye();
            ci.IrsaliyeleriGetirBySorgulama(txtUnvanaGore.Text, txtIrsaliyeKodunaGore.Text, IrsaliyeTuruneGore, lvIrsaliyeler, Convert.ToDateTime(txtIlkTarih.Text), Convert.ToDateTime(txtSonTarih.Text));
        }


        private void lvIrsaliyeler_DoubleClick(object sender, EventArgs e)
        {
            //cGenel.tedarikciUnvan = lvIrsaliyeler.SelectedItems[0].SubItems[0].Text;
            //cGenel.irsaliyeKodu = lvIrsaliyeler.SelectedItems[0].SubItems[1].Text;
            cGenel.irsaliyeID = Convert.ToInt32(lvIrsaliyeler.SelectedItems[0].SubItems[4].Text);
            frmIrsaliyeDetay f = new frmIrsaliyeDetay();
            f.Show();

        }

        private void dtpFaturaIlkTarih_ValueChanged(object sender, EventArgs e)
        {
            txtIlkTarih.Text = dtpFaturaIlkTarih.Value.ToShortDateString();
            cIrsaliye ci = new cIrsaliye();
            ci.IrsaliyeleriGetirBySorgulama(txtUnvanaGore.Text, txtIrsaliyeKodunaGore.Text, IrsaliyeTuruneGore, lvIrsaliyeler, Convert.ToDateTime(txtIlkTarih.Text), Convert.ToDateTime(txtSonTarih.Text));
        }

        private void dtpFaturaSonTarih_ValueChanged(object sender, EventArgs e)
        {
            txtSonTarih.Text = dtpFaturaSonTarih.Value.ToShortDateString();
            cIrsaliye ci = new cIrsaliye();
            ci.IrsaliyeleriGetirBySorgulama(txtUnvanaGore.Text, txtIrsaliyeKodunaGore.Text, IrsaliyeTuruneGore, lvIrsaliyeler, Convert.ToDateTime(txtIlkTarih.Text), Convert.ToDateTime(txtSonTarih.Text));
        }



        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Unvan, IrsaliyeKodu, IrsaliyeTarihi, IrsaliyeTuru from vw_Irsaliyeler where Unvan like @Unvan and IrsaliyeKodu like @IrsaliyeKodu  and IrsaliyeTuru  like @IrsaliyeTuru and  Convert(Date,IrsaliyeTarihi, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by IrsaliyeTarihi desc", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = txtUnvanaGore.Text + "%";
            da.SelectCommand.Parameters.Add("@IrsaliyeKodu", SqlDbType.VarChar).Value = txtIrsaliyeKodunaGore.Text + "%";
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = txtIlkTarih.Text;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = txtSonTarih.Text;
            da.SelectCommand.Parameters.Add("@IrsaliyeTuru", SqlDbType.VarChar).Value = IrsaliyeTuruneGore + "%";
            try
            {
                this.SporMarketDataSet3.vw_Irsaliyeler.Clear();
                da.Fill(this.SporMarketDataSet3.vw_Irsaliyeler);
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            reportViewer1.Width = 760;
            this.Width = 760;
            reportViewer1.Height = 560;
            reportViewer1.Visible = true;


        }

        private void reportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            reportViewer1.Width = 10;

            reportViewer1.Height = 10;
            reportViewer1.Visible = false;
            this.Width = 540;
        }
    }
}
