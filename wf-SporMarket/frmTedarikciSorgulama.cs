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
    public partial class frmTedarikciSorgulama : Form
    {
        public frmTedarikciSorgulama()
        {
            InitializeComponent();
        }

        private void frmTedarikciSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(lvTedarikciler);
        }
        private void txtUnvan_TextChanged(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }

        private void txtYetkili_TextChanged(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }

        private void txtTtelefon_TextChanged(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }


        private void txtTilce_TextChanged(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }

        private void txtTvergiNo_TextChanged(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }



        private void txtTilce_TextChanged_1(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(txtUnvan.Text, txtYetkili.Text, txtTtelefon.Text, txtTil.Text, txtTilce.Text, txtTvergiNo.Text, lvTedarikciler);
        }

        private void lvTedarikciler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.tedarikciID = Convert.ToInt32(lvTedarikciler.SelectedItems[0].SubItems[0].Text);
            cGenel.tedarikciUnvan = lvTedarikciler.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lvTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
