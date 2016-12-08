namespace wf_SporMarket
{
    partial class frmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mitmMusteriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmTedarikciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.MitmTedarikciTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmTedarikciSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKasa = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmGunlukSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDepoIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.frmUrunTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKategoriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMarkaTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmUrunGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmUrunSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmIRsaliyeSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSifreDegistirme = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKullaniciTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriIslemleri,
            this.mitmTedarikciIslemleri,
            this.mitmKasa,
            this.mitmDepoIslemleri,
            this.mitmRaporlama,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.mitmCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1126, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mitmMusteriIslemleri
            // 
            this.mitmMusteriIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriTanimlama,
            this.mitmMusteriSorgulama});
            this.mitmMusteriIslemleri.Image = global::wf_SporMarket.Properties.Resources.müşteri;
            this.mitmMusteriIslemleri.Name = "mitmMusteriIslemleri";
            this.mitmMusteriIslemleri.Size = new System.Drawing.Size(182, 36);
            this.mitmMusteriIslemleri.Text = "Müşteri İşlemleri";
            // 
            // mitmMusteriTanimlama
            // 
            this.mitmMusteriTanimlama.Name = "mitmMusteriTanimlama";
            this.mitmMusteriTanimlama.Size = new System.Drawing.Size(227, 26);
            this.mitmMusteriTanimlama.Text = "Müşteri Tanımlama";
            this.mitmMusteriTanimlama.Click += new System.EventHandler(this.mitmMusteriTanimlama_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(227, 26);
            this.mitmMusteriSorgulama.Text = "Müşteri Sorgulama";
            this.mitmMusteriSorgulama.Click += new System.EventHandler(this.mitmMusteriSorgulama_Click);
            // 
            // mitmTedarikciIslemleri
            // 
            this.mitmTedarikciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MitmTedarikciTanimlama,
            this.mitmTedarikciSorgulama});
            this.mitmTedarikciIslemleri.Image = global::wf_SporMarket.Properties.Resources.tedarikçiler;
            this.mitmTedarikciIslemleri.Name = "mitmTedarikciIslemleri";
            this.mitmTedarikciIslemleri.Size = new System.Drawing.Size(193, 36);
            this.mitmTedarikciIslemleri.Text = "Tedarikçi İşlemleri";
            // 
            // MitmTedarikciTanimlama
            // 
            this.MitmTedarikciTanimlama.Name = "MitmTedarikciTanimlama";
            this.MitmTedarikciTanimlama.Size = new System.Drawing.Size(238, 26);
            this.MitmTedarikciTanimlama.Text = "Tedarikçi Tanımlama";
            this.MitmTedarikciTanimlama.Click += new System.EventHandler(this.MitmTedarikciTanimlama_Click);
            // 
            // mitmTedarikciSorgulama
            // 
            this.mitmTedarikciSorgulama.Name = "mitmTedarikciSorgulama";
            this.mitmTedarikciSorgulama.Size = new System.Drawing.Size(238, 26);
            this.mitmTedarikciSorgulama.Text = "Tedarikçi Sorgulama";
            this.mitmTedarikciSorgulama.Click += new System.EventHandler(this.mitmTedarikciSorgulama_Click);
            // 
            // mitmKasa
            // 
            this.mitmKasa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmGunlukSatis});
            this.mitmKasa.Image = global::wf_SporMarket.Properties.Resources.kasa;
            this.mitmKasa.Name = "mitmKasa";
            this.mitmKasa.Size = new System.Drawing.Size(159, 36);
            this.mitmKasa.Text = "Kasa İşlemleri";
            this.mitmKasa.Click += new System.EventHandler(this.satışİşlemleriToolStripMenuItem_Click);
            // 
            // mitmGunlukSatis
            // 
            this.mitmGunlukSatis.Name = "mitmGunlukSatis";
            this.mitmGunlukSatis.Size = new System.Drawing.Size(245, 26);
            this.mitmGunlukSatis.Text = "Günlük Satış İşlemleri";
            this.mitmGunlukSatis.Click += new System.EventHandler(this.mitmGunlukSatis_Click);
            // 
            // mitmDepoIslemleri
            // 
            this.mitmDepoIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmUrunTanimlama,
            this.mitmUrunGirisi,
            this.mitmUrunSorgulama});
            this.mitmDepoIslemleri.Image = global::wf_SporMarket.Properties.Resources.depo;
            this.mitmDepoIslemleri.Name = "mitmDepoIslemleri";
            this.mitmDepoIslemleri.Size = new System.Drawing.Size(165, 36);
            this.mitmDepoIslemleri.Text = "Depo İşlemleri";
            // 
            // frmUrunTanimlama
            // 
            this.frmUrunTanimlama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmKategoriTanimlama,
            this.mitmMarkaTanimlama});
            this.frmUrunTanimlama.Name = "frmUrunTanimlama";
            this.frmUrunTanimlama.Size = new System.Drawing.Size(207, 26);
            this.frmUrunTanimlama.Text = "Ürün Tanımlama";
            this.frmUrunTanimlama.Click += new System.EventHandler(this.frmUrunTanimlama_Click);
            // 
            // mitmKategoriTanimlama
            // 
            this.mitmKategoriTanimlama.Name = "mitmKategoriTanimlama";
            this.mitmKategoriTanimlama.Size = new System.Drawing.Size(234, 26);
            this.mitmKategoriTanimlama.Text = "Kategori Tanımlama";
            this.mitmKategoriTanimlama.Click += new System.EventHandler(this.mitmKategoriTanimlama_Click);
            // 
            // mitmMarkaTanimlama
            // 
            this.mitmMarkaTanimlama.Name = "mitmMarkaTanimlama";
            this.mitmMarkaTanimlama.Size = new System.Drawing.Size(234, 26);
            this.mitmMarkaTanimlama.Text = "Marka Tanımlama";
            this.mitmMarkaTanimlama.Click += new System.EventHandler(this.mitmMarkaTanimlama_Click);
            // 
            // mitmUrunGirisi
            // 
            this.mitmUrunGirisi.Name = "mitmUrunGirisi";
            this.mitmUrunGirisi.Size = new System.Drawing.Size(207, 26);
            this.mitmUrunGirisi.Text = "Ürün Girişi";
            this.mitmUrunGirisi.Click += new System.EventHandler(this.mitmUrunGirisi_Click);
            // 
            // mitmUrunSorgulama
            // 
            this.mitmUrunSorgulama.Name = "mitmUrunSorgulama";
            this.mitmUrunSorgulama.Size = new System.Drawing.Size(207, 26);
            this.mitmUrunSorgulama.Text = "Ürün Sorgulama";
            this.mitmUrunSorgulama.Click += new System.EventHandler(this.mitmUrunSorgulama_Click);
            // 
            // mitmRaporlama
            // 
            this.mitmRaporlama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmIRsaliyeSorgulama,
            this.faturaSorgulamaToolStripMenuItem});
            this.mitmRaporlama.Image = global::wf_SporMarket.Properties.Resources.raporlama;
            this.mitmRaporlama.Name = "mitmRaporlama";
            this.mitmRaporlama.Size = new System.Drawing.Size(137, 36);
            this.mitmRaporlama.Text = "Raporlama";
            // 
            // mitmIRsaliyeSorgulama
            // 
            this.mitmIRsaliyeSorgulama.Name = "mitmIRsaliyeSorgulama";
            this.mitmIRsaliyeSorgulama.Size = new System.Drawing.Size(222, 26);
            this.mitmIRsaliyeSorgulama.Text = "İrsaliye Sorgulama";
            this.mitmIRsaliyeSorgulama.Click += new System.EventHandler(this.mitmIRsaliyeSorgulama_Click_1);
            // 
            // faturaSorgulamaToolStripMenuItem
            // 
            this.faturaSorgulamaToolStripMenuItem.Name = "faturaSorgulamaToolStripMenuItem";
            this.faturaSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.faturaSorgulamaToolStripMenuItem.Text = "Fatura Sorgulama";
            this.faturaSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.mitmFaturaSorgulama_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmSifreDegistirme,
            this.mitmKullaniciTanimlama});
            this.kullanıcıİşlemleriToolStripMenuItem.Image = global::wf_SporMarket.Properties.Resources.Kullanıcıİşelmeri;
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // mitmSifreDegistirme
            // 
            this.mitmSifreDegistirme.Name = "mitmSifreDegistirme";
            this.mitmSifreDegistirme.Size = new System.Drawing.Size(212, 26);
            this.mitmSifreDegistirme.Text = "Şifre Değiştirme";
            this.mitmSifreDegistirme.Click += new System.EventHandler(this.mitmSifreDegistirme_Click);
            // 
            // mitmKullaniciTanimlama
            // 
            this.mitmKullaniciTanimlama.Name = "mitmKullaniciTanimlama";
            this.mitmKullaniciTanimlama.Size = new System.Drawing.Size(212, 26);
            this.mitmKullaniciTanimlama.Text = "Kullanıcı Tanımla";
            this.mitmKullaniciTanimlama.Click += new System.EventHandler(this.mitmKullaniciTanimlama_Click);
            // 
            // mitmCikis
            // 
            this.mitmCikis.Image = global::wf_SporMarket.Properties.Resources.Çıkış;
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(90, 36);
            this.mitmCikis.Text = "Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblKullanici});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tslblKullanici
            // 
            this.tslblKullanici.Name = "tslblKullanici";
            this.tslblKullanici.Size = new System.Drawing.Size(118, 17);
            this.tslblKullanici.Text = "toolStripStatusLabel1";
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1126, 678);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmTedarikciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmKasa;
        private System.Windows.Forms.ToolStripMenuItem mitmDepoIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmRaporlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem MitmTedarikciTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmTedarikciSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmGunlukSatis;
        private System.Windows.Forms.ToolStripMenuItem frmUrunTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmUrunGirisi;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
        private System.Windows.Forms.ToolStripMenuItem mitmIRsaliyeSorgulama;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmSifreDegistirme;
        private System.Windows.Forms.ToolStripMenuItem mitmUrunSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmKategoriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMarkaTanimlama;
        public System.Windows.Forms.ToolStripMenuItem mitmKullaniciTanimlama;
        private System.Windows.Forms.ToolStripMenuItem faturaSorgulamaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblKullanici;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}