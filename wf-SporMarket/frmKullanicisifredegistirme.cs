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
    public partial class frmKullanicisifredegistirme : Form
    {
        public frmKullanicisifredegistirme()
        {
            InitializeComponent();
        }

        cKullanici k = new cKullanici();
        private void frmKullaniciİslemleri_Load(object sender, EventArgs e)
        {

            k = k.KullaniciGetirByAdaGore(cGenel.aktifkullaniciadi);
            txtAdı.Text = k.Adi;
            txtSoyadı.Text = k.Soyadi;
            txtEskiSifre.Focus();
        }

        private void tpKullaniciTanimla_Click(object sender, EventArgs e)
        {

        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            string eskisifre = k.Sifre;
            int ID = k.KullaniciID;
            if (eskisifre == txtEskiSifre.Text)
            {
                if (k.KullaniciSifreDegistir(ID, txtYeniSifre.Text))
                {
                    MessageBox.Show("Şifre Başarı ile Değiştirildi", "Bilgi");
                }
                else MessageBox.Show("Şifre Değiştirme Başarısız", "Bilgi");
            }
            else
            {
                MessageBox.Show("Eski Şifre Yanlış! Eski şifrenizi kotrol Ediniz!");
            }
        }
    }
}
