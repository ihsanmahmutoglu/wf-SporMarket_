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
    public partial class frmStokGoruntule : Form
    {
        public frmStokGoruntule()
        {
            InitializeComponent();
        }

        cUrun u = new cUrun();
        cKategori k = new cKategori();
        cMarka m = new cMarka();

        string kategori = "";
        string marka = "";
        private void txtKodaGore_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, marka, kategori, txtNumara.Text);
        }

        private void frmStokGoruntule_Load(object sender, EventArgs e)
        {

            ArrayList alist = new ArrayList();
            alist = k.KategorileriGetir();
            foreach (cKategori kategori in alist)
            {
                cbKategoriler.Items.Add(kategori.KategoriAd.ToString());
            }
            alist = m.MarkalariGetir();
            foreach (cMarka marka in alist)
            {
                cbMarkalar.Items.Add(marka.MarkaAd.ToString());
            }
            cbMarkalar.SelectedIndex = 0;
            cbKategoriler.SelectedIndex = 0;
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, marka, kategori, txtNumara.Text);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, marka, kategori, txtNumara.Text);
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarkalar.SelectedIndex == 0)
            {
                marka = "";
            }
            else
            {
                marka = cbMarkalar.SelectedItem.ToString();
            }
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, marka, kategori, txtNumara.Text);
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategoriler.SelectedIndex == 0)
            {
                kategori = "";
            }
            else
            {
                kategori = cbKategoriler.SelectedItem.ToString();
            }
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, marka, kategori, txtNumara.Text);
        }

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = u.UrunleriGetirBySorgulama(txtKodaGore.Text, txtAdaGore.Text, "", "", txtNumara.Text);
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cGenel.urunKodu = dgvUrunler.SelectedRows[0].Cells[1].Value.ToString();
            cGenel.urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells[0].Value);
            this.Close();
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
