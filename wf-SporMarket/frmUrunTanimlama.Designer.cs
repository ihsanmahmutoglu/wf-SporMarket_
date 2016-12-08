namespace wf_SporMarket
{
    partial class frmUrunTanimlama
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
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKategoriNo = new System.Windows.Forms.TextBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtKritikSeviye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader25,
            this.columnHeader29,
            this.columnHeader30});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.Location = new System.Drawing.Point(361, 53);
            this.lvUrunler.Margin = new System.Windows.Forms.Padding(5);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(717, 398);
            this.lvUrunler.TabIndex = 85;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.DoubleClick += new System.EventHandler(this.lvUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Kodu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numara";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Birim Fiyat";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Miktar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kritik Seviye";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "UrunID";
            this.columnHeader25.Width = 0;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "MarkaID";
            this.columnHeader29.Width = 0;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "KategoriNo";
            this.columnHeader30.Width = 0;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(170, 221);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(164, 23);
            this.txtNumara.TabIndex = 80;
            this.txtNumara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 226);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 17);
            this.label20.TabIndex = 79;
            this.label20.Text = "Numara";
            // 
            // txtKategoriNo
            // 
            this.txtKategoriNo.Location = new System.Drawing.Point(13, 145);
            this.txtKategoriNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtKategoriNo.Name = "txtKategoriNo";
            this.txtKategoriNo.ReadOnly = true;
            this.txtKategoriNo.Size = new System.Drawing.Size(24, 23);
            this.txtKategoriNo.TabIndex = 78;
            this.txtKategoriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKategoriNo.Visible = false;
            // 
            // cbMarka
            // 
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.DropDownWidth = 100;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(308, 178);
            this.cbMarka.Margin = new System.Windows.Forms.Padding(5);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(25, 24);
            this.cbMarka.TabIndex = 77;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(170, 178);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(164, 23);
            this.txtMarka.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 183);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 75;
            this.label17.Text = "Marka";
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.Location = new System.Drawing.Point(13, 183);
            this.txtMarkaID.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.ReadOnly = true;
            this.txtMarkaID.Size = new System.Drawing.Size(24, 23);
            this.txtMarkaID.TabIndex = 74;
            this.txtMarkaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMarkaID.Visible = false;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(13, 58);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(24, 23);
            this.txtUrunID.TabIndex = 73;
            this.txtUrunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrunID.Visible = false;
            // 
            // txtKritikSeviye
            // 
            this.txtKritikSeviye.Location = new System.Drawing.Point(170, 353);
            this.txtKritikSeviye.Margin = new System.Windows.Forms.Padding(5);
            this.txtKritikSeviye.Name = "txtKritikSeviye";
            this.txtKritikSeviye.Size = new System.Drawing.Size(164, 23);
            this.txtKritikSeviye.TabIndex = 72;
            this.txtKritikSeviye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Kritik Seviye";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(172, 277);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(164, 23);
            this.txtBirimFiyat.TabIndex = 70;
            this.txtBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Birim Fiyat";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(170, 315);
            this.txtStokMiktar.Margin = new System.Windows.Forms.Padding(5);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.ReadOnly = true;
            this.txtStokMiktar.Size = new System.Drawing.Size(164, 23);
            this.txtStokMiktar.TabIndex = 68;
            this.txtStokMiktar.Text = "0";
            this.txtStokMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Stok Miktarı";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.DropDownWidth = 100;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(308, 140);
            this.cbKategoriler.Margin = new System.Windows.Forms.Padding(5);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(25, 24);
            this.cbKategoriler.TabIndex = 66;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(170, 140);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(5);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(164, 23);
            this.txtKategori.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Kategori";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(170, 92);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(164, 23);
            this.txtUrunAdi.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ürün Adı";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(170, 53);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(164, 23);
            this.txtUrunKodu.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ürün Kodu";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.iptal_kucuk;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(245, 395);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 37);
            this.btnSil.TabIndex = 89;
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
            this.btnDegistir.Location = new System.Drawing.Point(145, 395);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(91, 37);
            this.btnDegistir.TabIndex = 88;
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
            this.btnKaydet.Location = new System.Drawing.Point(45, 395);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnKaydet.TabIndex = 87;
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
            this.btnYeni.Location = new System.Drawing.Point(58, 15);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(91, 37);
            this.btnYeni.TabIndex = 86;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmUrunTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1104, 469);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtKategoriNo);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMarkaID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.txtKritikSeviye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStokMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKategoriler);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrunTanimlama";
            this.Text = "UrunTanimlama";
            this.Load += new System.EventHandler(this.frmUrunTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKategoriNo;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtKritikSeviye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStokMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}