namespace wf_SporMarket
{
    partial class frmStokGirisCikis
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
            this.vw_StokGiriscikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SporMarketDataSet = new wf_SporMarket.SporMarketDataSet();
            this.txtFırmaID = new System.Windows.Forms.TextBox();
            this.txtIrsaliye = new System.Windows.Forms.TextBox();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtIrsaliyeID = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dtPTarih = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.labelqwe = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.cbIrsaliyeTurleri = new System.Windows.Forms.ComboBox();
            this.txtIrsaliyeTuru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUrunkodlari = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rvStokGirisCikis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_StokGiriscikisTableAdapter = new wf_SporMarket.SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnFirmaBul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_StokGiriscikisBindingSource
            // 
            this.vw_StokGiriscikisBindingSource.DataMember = "vw_StokGiriscikis";
            this.vw_StokGiriscikisBindingSource.DataSource = this.SporMarketDataSet;
            // 
            // SporMarketDataSet
            // 
            this.SporMarketDataSet.DataSetName = "SporMarketDataSet";
            this.SporMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFırmaID
            // 
            this.txtFırmaID.Location = new System.Drawing.Point(40, 63);
            this.txtFırmaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFırmaID.Name = "txtFırmaID";
            this.txtFırmaID.ReadOnly = true;
            this.txtFırmaID.Size = new System.Drawing.Size(20, 23);
            this.txtFırmaID.TabIndex = 68;
            // 
            // txtIrsaliye
            // 
            this.txtIrsaliye.Location = new System.Drawing.Point(166, 124);
            this.txtIrsaliye.Margin = new System.Windows.Forms.Padding(5);
            this.txtIrsaliye.Name = "txtIrsaliye";
            this.txtIrsaliye.Size = new System.Drawing.Size(175, 23);
            this.txtIrsaliye.TabIndex = 4;
            this.txtIrsaliye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader23,
            this.columnHeader9,
            this.columnHeader24});
            this.lvHareketler.FullRowSelect = true;
            this.lvHareketler.Location = new System.Drawing.Point(27, 260);
            this.lvHareketler.Margin = new System.Windows.Forms.Padding(5);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(387, 224);
            this.lvHareketler.TabIndex = 56;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UrunID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Ürün Kodu";
            this.columnHeader23.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Adı";
            this.columnHeader9.Width = 125;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Adet";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 127);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 64;
            this.label15.Text = "İrsaliye Adı";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(306, 187);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(107, 23);
            this.txtAdet.TabIndex = 7;
            // 
            // txtIrsaliyeID
            // 
            this.txtIrsaliyeID.Location = new System.Drawing.Point(40, 123);
            this.txtIrsaliyeID.Margin = new System.Windows.Forms.Padding(5);
            this.txtIrsaliyeID.Name = "txtIrsaliyeID";
            this.txtIrsaliyeID.ReadOnly = true;
            this.txtIrsaliyeID.Size = new System.Drawing.Size(20, 23);
            this.txtIrsaliyeID.TabIndex = 57;
            this.txtIrsaliyeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(11, 165);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(45, 23);
            this.txtUrunID.TabIndex = 53;
            this.txtUrunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(309, 168);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 17);
            this.label19.TabIndex = 66;
            this.label19.Text = "Adet";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(40, 187);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(141, 23);
            this.txtUrunKodu.TabIndex = 5;
            this.txtUrunKodu.TextChanged += new System.EventHandler(this.txtUrunKodu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Ürün Kodu";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(166, 25);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(5);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(175, 23);
            this.txtTarih.TabIndex = 0;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtPTarih
            // 
            this.dtPTarih.Location = new System.Drawing.Point(341, 25);
            this.dtPTarih.Margin = new System.Windows.Forms.Padding(5);
            this.dtPTarih.Name = "dtPTarih";
            this.dtPTarih.Size = new System.Drawing.Size(14, 23);
            this.dtPTarih.TabIndex = 60;
            this.dtPTarih.ValueChanged += new System.EventHandler(this.dtPTarih_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Tarih";
            // 
            // labelqwe
            // 
            this.labelqwe.AutoSize = true;
            this.labelqwe.Location = new System.Drawing.Point(66, 64);
            this.labelqwe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelqwe.Name = "labelqwe";
            this.labelqwe.Size = new System.Drawing.Size(43, 17);
            this.labelqwe.TabIndex = 61;
            this.labelqwe.Text = "Firma";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(165, 62);
            this.txtFirma.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(175, 23);
            this.txtFirma.TabIndex = 1;
            this.txtFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbIrsaliyeTurleri
            // 
            this.cbIrsaliyeTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIrsaliyeTurleri.DropDownWidth = 100;
            this.cbIrsaliyeTurleri.FormattingEnabled = true;
            this.cbIrsaliyeTurleri.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.cbIrsaliyeTurleri.Location = new System.Drawing.Point(341, 95);
            this.cbIrsaliyeTurleri.Margin = new System.Windows.Forms.Padding(5);
            this.cbIrsaliyeTurleri.Name = "cbIrsaliyeTurleri";
            this.cbIrsaliyeTurleri.Size = new System.Drawing.Size(19, 24);
            this.cbIrsaliyeTurleri.TabIndex = 3;
            this.cbIrsaliyeTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIrsaliyeTurleri_SelectedIndexChanged);
            // 
            // txtIrsaliyeTuru
            // 
            this.txtIrsaliyeTuru.Location = new System.Drawing.Point(166, 95);
            this.txtIrsaliyeTuru.Margin = new System.Windows.Forms.Padding(5);
            this.txtIrsaliyeTuru.Name = "txtIrsaliyeTuru";
            this.txtIrsaliyeTuru.ReadOnly = true;
            this.txtIrsaliyeTuru.Size = new System.Drawing.Size(175, 23);
            this.txtIrsaliyeTuru.TabIndex = 2;
            this.txtIrsaliyeTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "İrsaaliye Türü";
            // 
            // lbUrunkodlari
            // 
            this.lbUrunkodlari.FormattingEnabled = true;
            this.lbUrunkodlari.ItemHeight = 16;
            this.lbUrunkodlari.Location = new System.Drawing.Point(40, 206);
            this.lbUrunkodlari.Name = "lbUrunkodlari";
            this.lbUrunkodlari.Size = new System.Drawing.Size(141, 68);
            this.lbUrunkodlari.TabIndex = 74;
            this.lbUrunkodlari.Visible = false;
            this.lbUrunkodlari.DoubleClick += new System.EventHandler(this.lbUrunkodlari_DoubleClick);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(181, 187);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(126, 23);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Ürün Adı";
            // 
            // rvStokGirisCikis
            // 
            this.rvStokGirisCikis.DocumentMapWidth = 41;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_StokGiriscikisBindingSource;
            this.rvStokGirisCikis.LocalReport.DataSources.Add(reportDataSource1);
            this.rvStokGirisCikis.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report1.rdlc";
            this.rvStokGirisCikis.Location = new System.Drawing.Point(0, 1);
            this.rvStokGirisCikis.Name = "rvStokGirisCikis";
            this.rvStokGirisCikis.Size = new System.Drawing.Size(56, 25);
            this.rvStokGirisCikis.TabIndex = 77;
            this.rvStokGirisCikis.Visible = false;
            this.rvStokGirisCikis.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rvStokGirisCikis_Print);
            // 
            // vw_StokGiriscikisTableAdapter
            // 
            this.vw_StokGiriscikisTableAdapter.ClearBeforeFill = true;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Image = global::wf_SporMarket.Properties.Resources.search_icon;
            this.btnUrunAra.Location = new System.Drawing.Point(16, 187);
            this.btnUrunAra.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(27, 23);
            this.btnUrunAra.TabIndex = 73;
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::wf_SporMarket.Properties.Resources.save_kucuk;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(273, 486);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 37);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Irsaliye Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnFirmaBul
            // 
            this.btnFirmaBul.Image = global::wf_SporMarket.Properties.Resources.search_icon;
            this.btnFirmaBul.Location = new System.Drawing.Point(338, 61);
            this.btnFirmaBul.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFirmaBul.Name = "btnFirmaBul";
            this.btnFirmaBul.Size = new System.Drawing.Size(35, 26);
            this.btnFirmaBul.TabIndex = 63;
            this.btnFirmaBul.UseVisualStyleBackColor = true;
            this.btnFirmaBul.Click += new System.EventHandler(this.btnFirmaBul_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::wf_SporMarket.Properties.Resources.cancel_shop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(320, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 112;
            this.button1.Text = "İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::wf_SporMarket.Properties.Resources.remove_shop;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(233, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 111;
            this.button2.Text = "Çıkart";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnÇıkar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::wf_SporMarket.Properties.Resources.add_shop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(146, 217);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 110;
            this.button3.Text = "Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmStokGirisCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(425, 526);
            this.Controls.Add(this.rvStokGirisCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lbUrunkodlari);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.cbIrsaliyeTurleri);
            this.Controls.Add(this.txtIrsaliyeTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFırmaID);
            this.Controls.Add(this.txtIrsaliye);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtIrsaliyeID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.dtPTarih);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFirmaBul);
            this.Controls.Add(this.labelqwe);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 565);
            this.Name = "frmStokGirisCikis";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.frmStokGirisCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFırmaID;
        private System.Windows.Forms.TextBox txtIrsaliye;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtIrsaliyeID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DateTimePicker dtPTarih;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFirmaBul;
        private System.Windows.Forms.Label labelqwe;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.ComboBox cbIrsaliyeTurleri;
        private System.Windows.Forms.TextBox txtIrsaliyeTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.ListBox lbUrunkodlari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rvStokGirisCikis;
        private System.Windows.Forms.BindingSource vw_StokGiriscikisBindingSource;
        private SporMarketDataSet SporMarketDataSet;
        private SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter vw_StokGiriscikisTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}