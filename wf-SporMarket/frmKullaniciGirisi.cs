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
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cKullanici k = new cKullanici();
            bool Onay;
            Onay = k.KullanıcıGirisOnay(txtKAdi.Text, txtSifre.Text);
            if (Onay)
            {
             k=   k.aktifkullaniciGetir(txtKAdi.Text );
                cGenel.aktifkullaniciID = k.KullaniciID;
                cGenel.aktifkullaniciadi = k.KullaniciAdi;
                cGenel.aktifkullanicitipi = k.KullaniciTipi;
                frmAnasayfa f = new frmAnasayfa();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Girişi Başarılısız");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
