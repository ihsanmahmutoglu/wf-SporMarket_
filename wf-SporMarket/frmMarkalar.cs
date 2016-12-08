using System;
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
    public partial class frmMarkalar : Form
    {
        public frmMarkalar()
        {
            InitializeComponent();
        }

        cMarka cm = new cMarka();
        
        private void frmMarkalar_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            cm.MarkalariGetir (lvMarkalar );
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtMarka.Clear();
            txtMarkaNo.Clear();
            txtMarka.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text.Trim() == " ")
            {
                MessageBox.Show("Marka adı bligisi boş bırakılamaz!", "DIKKAT");
            }
            else
            {
                if (cm.MarkaKontrol(txtMarka.Text))
                {
                    MessageBox.Show("Bu marka adı daha önceden kayıtlıdır.", "Bilgilendirme");
                    txtMarka.Focus();
                }
                else
                {
                    if (cm.MarkaEkle(txtMarka.Text))
                    {
                        MessageBox.Show("Marka adı kayıt etme işlemi başarıyla sonuçlandırılmıştır.");
                        cm.MarkalariGetir(lvMarkalar);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi yapılamadı!", "DIKKAT");
                    }
                }
            }

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text.Trim() == " ")
            {
                MessageBox.Show("Marka adı bilgisi boş bırakılamaz!", "UYARI");
            }
            else
            {
                if (cm.MarkaVarmi(txtMarka.Text, Convert.ToInt32(txtMarkaNo.Text)))
                {
                    MessageBox.Show("Bu kategori daha önceden kayıt edilmiştir!", "DİKKAT");
                    txtMarka.Focus();
                }
                else
                {
                    cm.MarkalariGuncelle(txtMarka.Text, Convert.ToInt32(txtMarkaNo.Text));
                    MessageBox.Show("Değiştirme işleminiz tamamlanmıştır.", "BİLGİLENDİRME");
                    cm.MarkalariGetir(lvMarkalar);
                    Temizle();
                    txtMarka.Focus();
                    btnKaydet.Enabled = false;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cm.MarkaSil(Convert.ToInt32( txtMarkaNo.Text) ))
                {
                    MessageBox.Show("Marka bilgisi başarıyla silindi", "Bilgilendirme");
                
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    cm.MarkalariGetir(lvMarkalar);
                }
            }
        }

        private void lvMarkalar_DoubleClick(object sender, EventArgs e)
        {
            txtMarkaNo.Text = lvMarkalar.SelectedItems[0].SubItems[0].Text;
            txtMarka.Text = lvMarkalar.SelectedItems[0].SubItems[1].Text;
            btnYeni.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtMarka.Focus();
        }
    }
}
