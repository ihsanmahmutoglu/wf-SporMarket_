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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }

        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            tslblKullanici.Text = cGenel.aktifkullaniciadi;
            if (cGenel.aktifkullanicitipi == 1)
            {
                mitmKullaniciTanimlama.Enabled = true;
                mitmMusteriIslemleri.Enabled = true;
                mitmTedarikciIslemleri.Enabled = true;
                mitmDepoIslemleri.Enabled = true;
                mitmKasa.Enabled = true;
                mitmIRsaliyeSorgulama.Enabled = true;
                faturaSorgulamaToolStripMenuItem.Enabled = true;
            }
            else if(cGenel.aktifkullanicitipi == 2)
            {
                mitmKullaniciTanimlama.Enabled = false;
                mitmMusteriIslemleri.Enabled = true;
                mitmTedarikciIslemleri.Enabled = false;
                mitmDepoIslemleri.Enabled = false ;
                mitmKasa.Enabled = true;
                mitmIRsaliyeSorgulama.Enabled = false;
                faturaSorgulamaToolStripMenuItem.Enabled = true;

            }
            else if (cGenel.aktifkullanicitipi == 3)
            {
                mitmKullaniciTanimlama.Enabled = false;
                mitmMusteriIslemleri.Enabled = false;
                mitmTedarikciIslemleri.Enabled = true;
                mitmDepoIslemleri.Enabled = true ;
                mitmKasa.Enabled = false;
                mitmIRsaliyeSorgulama.Enabled = true ;
                faturaSorgulamaToolStripMenuItem.Enabled = false;
            }
            else
            {

            }
        

        }


        private void mitmSifreDegistirme_Click(object sender, EventArgs e)
        {
            frmKullanicisifredegistirme f = new frmKullanicisifredegistirme();
            f.ShowDialog();//Kulllanıci işlemleri Formu açıldı.
        }

        private void mitmKullaniciTanimlama_Click(object sender, EventArgs e)
        {
            frmKullaniciTanimlama f = new frmKullaniciTanimlama();
            FormAcikmi(f);
            f.Show();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitmMusteriTanimlama_Click(object sender, EventArgs e)
        {
            frmMusteriTanımlama f = new frmMusteriTanımlama();
            FormAcikmi(f);
        }

        private void mitmMusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama f = new frmMusteriSorgulama();
            FormAcikmi(f);
        }

        private void MitmTedarikciTanimlama_Click(object sender, EventArgs e)
        {
            frmTedarikciTanimlama f = new frmTedarikciTanimlama();
            FormAcikmi(f);
        }

        private void mitmTedarikciSorgulama_Click(object sender, EventArgs e)
        {
            frmTedarikciSorgulama f = new frmTedarikciSorgulama();
            FormAcikmi(f);
        }

        private void mitmOturumuKapat_Click(object sender, EventArgs e)
        {

        }



        private void mitmGunlukSatis_Click(object sender, EventArgs e)
        {
            frmKasaGunlukSatis f = new frmKasaGunlukSatis();
            FormAcikmi(f);
        }



        private void mitmUrunGirisi_Click(object sender, EventArgs e)
        {
            frmStokGirisCikis f = new frmStokGirisCikis();
            FormAcikmi(f);
        }

        private void frmUrunTanimlama_Click(object sender, EventArgs e)
        {
            frmUrunTanimlama f = new frmUrunTanimlama();
            FormAcikmi(f);
        }

        private void mitmUrunSorgulama_Click(object sender, EventArgs e)
        {
            frmStokGoruntule f = new frmStokGoruntule();
            FormAcikmi(f);
        }

        private void mitmKategoriTanimlama_Click(object sender, EventArgs e)
        {
            frmKategoriler f = new frmKategoriler();
            FormAcikmi(f);
        }

        private void mitmMarkaTanimlama_Click(object sender, EventArgs e)
        {
            frmMarkalar f = new frmMarkalar();
            FormAcikmi(f);
        }

        private void mitmIRsaliyeSorgulama_Click_1(object sender, EventArgs e)
        {
            frmIrsaliyeler f = new frmIrsaliyeler();
            FormAcikmi(f);
        }


        private void mitmFaturaSorgulama_Click(object sender, EventArgs e)
        {
            frmFaturalar f = new frmFaturalar();
            FormAcikmi(f);
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detaylıStokSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
