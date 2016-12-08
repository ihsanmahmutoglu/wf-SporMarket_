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
    public partial class frmTedarikciTanimlama : Form
    {
        public frmTedarikciTanimlama()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        BindingSource bs1;
        private void frmTedarikciTanimlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cTedarikci td = new cTedarikci();
            td.TedarikcileriGetir(lvTedarikciler);
            ds = td.TedarikcileriGetir();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Tedarikciler"];

            DataBagla();
            Konum();

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
        }
        private void DataBagla()
        {
            cTedarikci td = new cTedarikci();
            ds = td.TedarikcileriGetir();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Tedarikciler"];

            txtFirmaID.DataBindings.Clear();
            txtUnvan.DataBindings.Clear();
            txtYetkili.DataBindings.Clear();
            txtTelefon.DataBindings.Clear();
            txtAdres.DataBindings.Clear();
            txtil.DataBindings.Clear();
            txtilce.DataBindings.Clear();
            txtVergiNo.DataBindings.Clear();
            txtVergiDairesi.DataBindings.Clear();

            //txtFirmaID.DataBindings.Add("Text", bs1, "FirmaID");
            txtUnvan.DataBindings.Add("Text", bs1, "Unvan");
            txtYetkili.DataBindings.Add("Text", bs1, "Yetkili");
            txtTelefon.DataBindings.Add("Text", bs1, "Telefon");
            txtAdres.DataBindings.Add("Text", bs1, "Adres");
            txtil.DataBindings.Add("Text", bs1, "il");
            txtilce.DataBindings.Add("Text", bs1, "ilce");
            txtVergiNo.DataBindings.Add("Text", bs1, "VergiNo");
            txtVergiDairesi.DataBindings.Add("Text", bs1, "VergiDairesi");
        }
        private void Konum()
        {
            bPosition.Text = (bs1.Position + 1).ToString();
            bCount.Text = bs1.Count.ToString();
        }
        private void bnFirst_Click(object sender, EventArgs e)
        {
            bs1.Position = 0;
            Konum();
        }

        private void bnPrev_Click(object sender, EventArgs e)
        {
            bs1.Position -= 1;
            Konum();
        }

        private void bnNext_Click(object sender, EventArgs e)
        {
            bs1.Position += 1;
            Konum();
        }

        private void bnLast_Click(object sender, EventArgs e)
        {
            bs1.Position = bs1.Count - 1;
            Konum();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            bs1.AddNew();
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtUnvan.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnvan.Text) || string.IsNullOrEmpty(txtYetkili.Text))
            {
                MessageBox.Show("Tedarikci ünvan ve ilgili yetkili boş bırakılamaz!!");
                txtUnvan.Focus();
            }
            else
            {
                cTedarikci td = new cTedarikci();
                if (td.TedarikciKontrol(txtUnvan.Text))
                {
                    MessageBox.Show("Firma Kaydı bulunmaktadır!");
                    txtUnvan.Focus();
                }
                else
                {
                    bs1.EndEdit();
                    td.Unvan = txtUnvan.Text;
                    td.Yetkili = txtYetkili.Text;
                    td.Telefon = txtTelefon.Text;
                    td.Adres = txtAdres.Text;
                    td.Il = txtil.Text;
                    td.Ilce = txtilce.Text;
                    td.VergiNo = txtVergiNo.Text;
                    td.Vergidairesi = txtVergiDairesi.Text;

                    if (td.TedarikciTanimla(td))
                    {
                        MessageBox.Show("Tedarikci Tanımlama başarılı!");
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;
                        td.TedarikcileriGetir(lvTedarikciler);
                        DataBagla();
                        Konum();
                    }
                    else { MessageBox.Show("Tedarikçi Tanımlama işlemi gerçekleşemedi!!!", "HATA"); }
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cTedarikci td = new cTedarikci();
            if (td.TedarikciKontrol(txtUnvan.Text, Convert.ToInt32(txtFirmaID.Text)))
            {
                MessageBox.Show("Firma Kaydı bulunmaktadır!");
                txtUnvan.Focus();
            }
            else
            {
                bs1.EndEdit();
                td.Unvan = txtUnvan.Text;
                td.Yetkili = txtYetkili.Text;
                td.Telefon = txtTelefon.Text;
                td.Adres = txtAdres.Text;
                td.Il = txtil.Text;
                td.Ilce = txtilce.Text;
                td.VergiNo = txtVergiNo.Text;
                td.Vergidairesi = txtVergiDairesi.Text;

                if (td.TedarikciGuncelle(td))
                {
                    MessageBox.Show("Tedarikci Güncelleme Başarılı!");
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;
                    td.TedarikcileriGetir(lvTedarikciler);
                    DataBagla();
                    Konum();
                }
                else { MessageBox.Show("Tedarikçi güncelleme işlemi gerçekleşemedi!!!", "HATA"); }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cTedarikci td = new cTedarikci();
                if (td.TedarikciSil(Convert.ToInt32(txtFirmaID.Text)))
                {
                    MessageBox.Show("Tedarikçi firma silindi!");
                    td.TedarikcileriGetir(lvTedarikciler);
                    DataBagla();
                    Konum();
                }
                else MessageBox.Show("Tedarikçi silme işlemi tamamlanamadı!!!", "DİKKAT");
            }
        }
        private void lvTedarikciler_DoubleClick(object sender, EventArgs e)
        {
            txtFirmaID.Text = lvTedarikciler.Items[0].SubItems[0].Text;
            txtUnvan.Text = lvTedarikciler.Items[0].SubItems[1].Text;
            txtYetkili.Text = lvTedarikciler.Items[0].SubItems[2].Text;
            txtTelefon.Text = lvTedarikciler.Items[0].SubItems[3].Text;
            txtAdres.Text = lvTedarikciler.Items[0].SubItems[4].Text;
            txtil.Text = lvTedarikciler.Items[0].SubItems[5].Text;
            txtilce.Text = lvTedarikciler.Items[0].SubItems[6].Text;
            txtVergiNo.Text = lvTedarikciler.Items[0].SubItems[7].Text;
            txtVergiDairesi.Text = lvTedarikciler.Items[0].SubItems[8].Text;

            cTedarikci u = new cTedarikci();
            int kacinci = u.KacinciTedarikci(Convert.ToInt32(lvTedarikciler.SelectedItems[0].SubItems[0].Text));
            bs1.Position = kacinci;
            Konum();
        }

        private void txtFirmaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lvTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUnvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYetkili_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVergiNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtilce_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
