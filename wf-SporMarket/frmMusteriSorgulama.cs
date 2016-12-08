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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }
        string cinsiyet="";
        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cbMcinsiyet.SelectedIndex = 2;
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(lvMusteriler);
        }
        private void txtMadi_TextChanged(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet , txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }

        private void txtMsoyadi_TextChanged(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet , txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }

        private void txtMtelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet, txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }

        private void txtMil_TextChanged(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet, txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }

        private void txtMilce_TextChanged(object sender, EventArgs e)
        {
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet, txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }



        private void cbMcinsiyet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            if (cbMcinsiyet.SelectedIndex == 2)
                cinsiyet = "";
            else
            {
                cinsiyet = cbMcinsiyet.SelectedItem.ToString();
            }
            cMusteri cm = new cMusteri();
            cm.MusterileriGetir(cinsiyet, txtMadi.Text, txtMsoyadi.Text, txtMtelefon.Text, txtMil.Text, txtMilce.Text, lvMusteriler);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.Musteri = lvMusteriler.SelectedItems[0].SubItems[1].Text + " " + lvMusteriler.SelectedItems[0].SubItems[2].Text;
            cGenel.MusteriID = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[7].Text);
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
