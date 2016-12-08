namespace wf_SporMarket
{
    partial class frmKullaniciTanimlama
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
            this.txtTurID = new System.Windows.Forms.TextBox();
            this.txtTurAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdaGoreAra = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKullaniciTurleri = new System.Windows.Forms.ComboBox();
            this.lvKullanicilar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTurID
            // 
            this.txtTurID.Location = new System.Drawing.Point(104, 228);
            this.txtTurID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurID.Name = "txtTurID";
            this.txtTurID.ReadOnly = true;
            this.txtTurID.Size = new System.Drawing.Size(25, 23);
            this.txtTurID.TabIndex = 79;
            this.txtTurID.Visible = false;
            // 
            // txtTurAd
            // 
            this.txtTurAd.Location = new System.Drawing.Point(139, 226);
            this.txtTurAd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTurAd.Name = "txtTurAd";
            this.txtTurAd.ReadOnly = true;
            this.txtTurAd.Size = new System.Drawing.Size(168, 23);
            this.txtTurAd.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Ada Göre Arama";
            // 
            // txtAdaGoreAra
            // 
            this.txtAdaGoreAra.Location = new System.Drawing.Point(352, 34);
            this.txtAdaGoreAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaGoreAra.Name = "txtAdaGoreAra";
            this.txtAdaGoreAra.Size = new System.Drawing.Size(212, 23);
            this.txtAdaGoreAra.TabIndex = 69;
            this.txtAdaGoreAra.TextChanged += new System.EventHandler(this.txtAdaGoreAra_TextChanged);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(139, 26);
            this.txtKullaniciID.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.ReadOnly = true;
            this.txtKullaniciID.Size = new System.Drawing.Size(25, 23);
            this.txtKullaniciID.TabIndex = 68;
            this.txtKullaniciID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Kullanıcı Turu";
            // 
            // cbKullaniciTurleri
            // 
            this.cbKullaniciTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciTurleri.DropDownWidth = 60;
            this.cbKullaniciTurleri.FormattingEnabled = true;
            this.cbKullaniciTurleri.Location = new System.Drawing.Point(307, 226);
            this.cbKullaniciTurleri.Margin = new System.Windows.Forms.Padding(4);
            this.cbKullaniciTurleri.Name = "cbKullaniciTurleri";
            this.cbKullaniciTurleri.Size = new System.Drawing.Size(27, 24);
            this.cbKullaniciTurleri.TabIndex = 66;
            this.cbKullaniciTurleri.SelectedIndexChanged += new System.EventHandler(this.cbKullaniciTurleri_SelectedIndexChanged);
            // 
            // lvKullanicilar
            // 
            this.lvKullanicilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvKullanicilar.FullRowSelect = true;
            this.lvKullanicilar.Location = new System.Drawing.Point(352, 62);
            this.lvKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.lvKullanicilar.Name = "lvKullanicilar";
            this.lvKullanicilar.Size = new System.Drawing.Size(285, 284);
            this.lvKullanicilar.TabIndex = 65;
            this.lvKullanicilar.UseCompatibleStateImageBehavior = false;
            this.lvKullanicilar.View = System.Windows.Forms.View.Details;
            this.lvKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lvKullanicilar_SelectedIndexChanged);
            this.lvKullanicilar.DoubleClick += new System.EventHandler(this.lvKullanicilar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KullaniciID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KullaniciTipi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KullaniciAdi";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adi";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadi";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sifre";
            this.columnHeader6.Width = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Yeni Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(141, 148);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 23);
            this.txtSifre.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(141, 62);
            this.txtAd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 23);
            this.txtAd.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Kullanıcı Soyadı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(141, 105);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 23);
            this.txtSoyad.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = " Yeni Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(139, 187);
            this.txtSifreTekrar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(196, 23);
            this.txtSifreTekrar.TabIndex = 81;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.iptal_kucuk;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(243, 282);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 37);
            this.btnSil.TabIndex = 85;
            this.btnSil.Text = " Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Image = global::wf_SporMarket.Properties.Resources.update_kucuk;
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegistir.Location = new System.Drawing.Point(143, 282);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(91, 37);
            this.btnDegistir.TabIndex = 84;
            this.btnDegistir.Text = " Guncelle";
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Image = global::wf_SporMarket.Properties.Resources.save_kucuk;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(43, 282);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnKaydet.TabIndex = 83;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Image = global::wf_SporMarket.Properties.Resources.new_kucuk;
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.Location = new System.Drawing.Point(19, 26);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(91, 37);
            this.btnYeni.TabIndex = 82;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmKullaniciTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(647, 359);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtTurID);
            this.Controls.Add(this.txtTurAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdaGoreAra);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKullaniciTurleri);
            this.Controls.Add(this.lvKullanicilar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Tanımlama İşlemleri";
            this.Load += new System.EventHandler(this.frmKullaniciTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurID;
        private System.Windows.Forms.TextBox txtTurAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdaGoreAra;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKullaniciTurleri;
        private System.Windows.Forms.ListView lvKullanicilar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}