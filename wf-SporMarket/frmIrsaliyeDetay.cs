using System;
using System.Collections;
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
    public partial class frmIrsaliyeDetay : Form
    {
        public frmIrsaliyeDetay()
        {
            InitializeComponent();
        }

        private void frmIrsaliyeDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SporMarketDataSet.vw_StokGiriscikis' table. You can move, or remove it, as needed.
          
            cIrsaliye irsaliye = new wf_SporMarket.cIrsaliye();
            cUrunHareket_Stok uh = new wf_SporMarket.cUrunHareket_Stok();
            ArrayList alist = new ArrayList();
            alist = irsaliye.IrsaliyeBilgileriniGetir(cGenel.irsaliyeID);
            cTedarikci t = (cTedarikci)alist[0];
            cIrsaliye ir = (cIrsaliye)alist[1];
            txtIrsaliyeAdi.Text = ir.IrsaliyeKodu;
            txtIrsaliyeKodu.Text = ir.IrsaliyeKodu;
            txtUnvan.Text = t.Unvan;
            txtYetkili.Text = t.Yetkili;

            uh.HareketleriGetir(lvStokHareket, cGenel.irsaliyeID);

        }

        private void button6_Click(object sender, EventArgs e)
        {
           yazdır();

        }

        private void yazdır()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IRsaliyeNo,UrunKodu,UrunAdi,Miktar,IrsaliyeKodu,Unvan,IrsaliyeTuru from vw_StokGirisCikis where IrsaliyeKodu =@Kod", cGenel.connStr);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = txtIrsaliyeKodu.Text;
            try
            {

                this.SporMarketDataSet.vw_StokGiriscikis.Clear();
                da.Fill(this.SporMarketDataSet.vw_StokGiriscikis);
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            reportViewer1.Visible = true;
            this.Width = 800;
            reportViewer1.Width = 800;
            reportViewer1.Height = 565;
        }

        private void reportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            reportViewer1.Width = 25;
            reportViewer1.Height = 25;
            this.Width = 461;
            reportViewer1.Visible = false;

        }
    }
}
