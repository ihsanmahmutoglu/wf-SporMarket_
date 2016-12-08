namespace wf_SporMarket
{
    partial class frmKasaGunlukSatis
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_GunlukKasaSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SporMarketDataSet2 = new wf_SporMarket.SporMarketDataSet2();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFaturaTipi = new System.Windows.Forms.TextBox();
            this.cbFaturaTipi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToplamGiris = new System.Windows.Forms.TextBox();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lvKasaHareketleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaturaKodu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIslemTipi = new System.Windows.Forms.TextBox();
            this.cbIslemTipi = new System.Windows.Forms.ComboBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnÇıkar = new System.Windows.Forms.Button();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_GunlukKasaSatisTableAdapter = new wf_SporMarket.SporMarketDataSet2TableAdapters.vw_GunlukKasaSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GunlukKasaSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_GunlukKasaSatisBindingSource
            // 
            this.vw_GunlukKasaSatisBindingSource.DataMember = "vw_GunlukKasaSatis";
            this.vw_GunlukKasaSatisBindingSource.DataSource = this.SporMarketDataSet2;
            // 
            // SporMarketDataSet2
            // 
            this.SporMarketDataSet2.DataSetName = "SporMarketDataSet2";
            this.SporMarketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 106;
            this.label7.Text = "Fatura Tipi";
            // 
            // txtFaturaTipi
            // 
            this.txtFaturaTipi.Location = new System.Drawing.Point(134, 89);
            this.txtFaturaTipi.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaTipi.Name = "txtFaturaTipi";
            this.txtFaturaTipi.ReadOnly = true;
            this.txtFaturaTipi.Size = new System.Drawing.Size(159, 23);
            this.txtFaturaTipi.TabIndex = 105;
            // 
            // cbFaturaTipi
            // 
            this.cbFaturaTipi.FormattingEnabled = true;
            this.cbFaturaTipi.Items.AddRange(new object[] {
            "Satış",
            "İade"});
            this.cbFaturaTipi.Location = new System.Drawing.Point(274, 89);
            this.cbFaturaTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cbFaturaTipi.Name = "cbFaturaTipi";
            this.cbFaturaTipi.Size = new System.Drawing.Size(19, 24);
            this.cbFaturaTipi.TabIndex = 104;
            this.cbFaturaTipi.SelectedIndexChanged += new System.EventHandler(this.cbFaturaTipi_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(154, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 103;
            this.label10.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(136, 148);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(103, 23);
            this.txtUrunAdi.TabIndex = 102;
            this.txtUrunAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(97, 26);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(29, 23);
            this.txtMusteriNo.TabIndex = 101;
            this.txtMusteriNo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Müşteri ";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(134, 27);
            this.txtMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(156, 23);
            this.txtMusteri.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(490, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "Toplam Tutar";
            // 
            // txtToplamGiris
            // 
            this.txtToplamGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamGiris.Location = new System.Drawing.Point(592, 474);
            this.txtToplamGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplamGiris.Name = "txtToplamGiris";
            this.txtToplamGiris.ReadOnly = true;
            this.txtToplamGiris.Size = new System.Drawing.Size(158, 26);
            this.txtToplamGiris.TabIndex = 93;
            this.txtToplamGiris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(642, 57);
            this.dtpIlkTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(19, 23);
            this.dtpIlkTarih.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(397, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "İşlem Tarihi";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(485, 57);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(159, 23);
            this.txtTarih.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(382, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(264, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Ürün Kodu";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(40, 148);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(96, 23);
            this.txtUrunKodu.TabIndex = 84;
            this.txtUrunKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(336, 148);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(99, 23);
            this.txtAdet.TabIndex = 83;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(239, 148);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(98, 23);
            this.txtFiyat.TabIndex = 82;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvKasaHareketleri
            // 
            this.lvKasaHareketleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader13,
            this.columnHeader12,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvKasaHareketleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvKasaHareketleri.FullRowSelect = true;
            this.lvKasaHareketleri.GridLines = true;
            this.lvKasaHareketleri.Location = new System.Drawing.Point(11, 186);
            this.lvKasaHareketleri.Margin = new System.Windows.Forms.Padding(4);
            this.lvKasaHareketleri.Name = "lvKasaHareketleri";
            this.lvKasaHareketleri.Size = new System.Drawing.Size(736, 280);
            this.lvKasaHareketleri.TabIndex = 81;
            this.lvKasaHareketleri.UseCompatibleStateImageBehavior = false;
            this.lvKasaHareketleri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UrunID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "UrunKodu";
            this.columnHeader13.Width = 92;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "UrunAdi";
            this.columnHeader12.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BirimFiyat";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KDV\'sizTutar";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 141;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "KDV\'liTutar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 144;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(23, 99);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(39, 23);
            this.txtUrunID.TabIndex = 110;
            this.txtUrunID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 112;
            this.label8.Text = "Fatura Kodu";
            // 
            // txtFaturaKodu
            // 
            this.txtFaturaKodu.Location = new System.Drawing.Point(134, 58);
            this.txtFaturaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaKodu.Name = "txtFaturaKodu";
            this.txtFaturaKodu.Size = new System.Drawing.Size(159, 23);
            this.txtFaturaKodu.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(410, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 119;
            this.label9.Text = "İşlem Tipi";
            // 
            // txtIslemTipi
            // 
            this.txtIslemTipi.Location = new System.Drawing.Point(485, 96);
            this.txtIslemTipi.Margin = new System.Windows.Forms.Padding(4);
            this.txtIslemTipi.Name = "txtIslemTipi";
            this.txtIslemTipi.ReadOnly = true;
            this.txtIslemTipi.Size = new System.Drawing.Size(159, 23);
            this.txtIslemTipi.TabIndex = 118;
            // 
            // cbIslemTipi
            // 
            this.cbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTipi.DropDownWidth = 100;
            this.cbIslemTipi.FormattingEnabled = true;
            this.cbIslemTipi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cbIslemTipi.Location = new System.Drawing.Point(642, 96);
            this.cbIslemTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cbIslemTipi.Name = "cbIslemTipi";
            this.cbIslemTipi.Size = new System.Drawing.Size(19, 24);
            this.cbIslemTipi.TabIndex = 117;
            this.cbIslemTipi.SelectedIndexChanged += new System.EventHandler(this.cbIslemTipi_SelectedIndexChanged);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Image = global::wf_SporMarket.Properties.Resources.search_icon;
            this.btnUrunAra.Location = new System.Drawing.Point(14, 147);
            this.btnUrunAra.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(30, 26);
            this.btnUrunAra.TabIndex = 113;
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::wf_SporMarket.Properties.Resources.cancel_shop;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(620, 137);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(85, 45);
            this.btnIptal.TabIndex = 109;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnÇıkar
            // 
            this.btnÇıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkar.Image = global::wf_SporMarket.Properties.Resources.remove_shop;
            this.btnÇıkar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnÇıkar.Location = new System.Drawing.Point(533, 137);
            this.btnÇıkar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnÇıkar.Name = "btnÇıkar";
            this.btnÇıkar.Size = new System.Drawing.Size(85, 45);
            this.btnÇıkar.TabIndex = 108;
            this.btnÇıkar.Text = "Çıkart";
            this.btnÇıkar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnÇıkar.UseVisualStyleBackColor = true;
            this.btnÇıkar.Click += new System.EventHandler(this.btnÇıkar_Click);
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBul.Image = global::wf_SporMarket.Properties.Resources.search_icon;
            this.btnMusteriBul.Location = new System.Drawing.Point(289, 26);
            this.btnMusteriBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(41, 25);
            this.btnMusteriBul.TabIndex = 100;
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::wf_SporMarket.Properties.Resources.add_shop;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(446, 137);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 45);
            this.btnEkle.TabIndex = 99;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGit
            // 
            this.btnGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGit.Image = global::wf_SporMarket.Properties.Resources.islemitamamla_kasa;
            this.btnGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGit.Location = new System.Drawing.Point(592, 505);
            this.btnGit.Margin = new System.Windows.Forms.Padding(4);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(157, 38);
            this.btnGit.TabIndex = 91;
            this.btnGit.Text = "İşlemi Tamamla";
            this.btnGit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 10;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_GunlukKasaSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(62, 32);
            this.reportViewer1.TabIndex = 120;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            // 
            // vw_GunlukKasaSatisTableAdapter
            // 
            this.vw_GunlukKasaSatisTableAdapter.ClearBeforeFill = true;
            // 
            // frmKasaGunlukSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(749, 542);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIslemTipi);
            this.Controls.Add(this.cbIslemTipi);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFaturaKodu);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnÇıkar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFaturaTipi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToplamGiris);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lvKasaHareketleri);
            this.Controls.Add(this.txtFaturaTipi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKasaGunlukSatis";
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.frmKasaGunlukSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_GunlukKasaSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFaturaTipi;
        private System.Windows.Forms.ComboBox cbFaturaTipi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToplamGiris;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ListView lvKasaHareketleri;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnÇıkar;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaturaKodu;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIslemTipi;
        private System.Windows.Forms.ComboBox cbIslemTipi;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_GunlukKasaSatisBindingSource;
        private SporMarketDataSet2 SporMarketDataSet2;
        private SporMarketDataSet2TableAdapters.vw_GunlukKasaSatisTableAdapter vw_GunlukKasaSatisTableAdapter;
    }
}