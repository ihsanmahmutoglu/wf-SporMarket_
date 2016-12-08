namespace wf_SporMarket
{
    partial class frmFaturalar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_FaturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SporMarketDataSet1 = new wf_SporMarket.SporMarketDataSet1();
            this.cbFatura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFaturaKodu = new System.Windows.Forms.TextBox();
            this.cbIslem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lvFaturalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFaturaSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFaturaIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.gbFaturaTarihi = new System.Windows.Forms.GroupBox();
            this.txtIlkTarih = new System.Windows.Forms.TextBox();
            this.txtSonTarih = new System.Windows.Forms.TextBox();
            this.btnDokuman = new System.Windows.Forms.Button();
            this.rvFatura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SporMarketDataSet = new wf_SporMarket.SporMarketDataSet();
            this.vw_StokGiriscikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_StokGiriscikisTableAdapter = new wf_SporMarket.SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter();
            this.vw_FaturalarTableAdapter = new wf_SporMarket.SporMarketDataSet1TableAdapters.vw_FaturalarTableAdapter();
            this.Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vw_FaturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet1)).BeginInit();
            this.gbFaturaTarihi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_FaturalarBindingSource
            // 
            this.vw_FaturalarBindingSource.DataMember = "vw_Faturalar";
            this.vw_FaturalarBindingSource.DataSource = this.SporMarketDataSet1;
            // 
            // SporMarketDataSet1
            // 
            this.SporMarketDataSet1.DataSetName = "SporMarketDataSet1";
            this.SporMarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFatura
            // 
            this.cbFatura.FormattingEnabled = true;
            this.cbFatura.Items.AddRange(new object[] {
            "Tüm Faturalar",
            "Satış",
            "İade",
            "Değişim"});
            this.cbFatura.Location = new System.Drawing.Point(234, 130);
            this.cbFatura.Margin = new System.Windows.Forms.Padding(4);
            this.cbFatura.Name = "cbFatura";
            this.cbFatura.Size = new System.Drawing.Size(80, 24);
            this.cbFatura.TabIndex = 40;
            this.cbFatura.SelectedIndexChanged += new System.EventHandler(this.cbFatura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fatura Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fatura Kodu";
            // 
            // txtFaturaKodu
            // 
            this.txtFaturaKodu.Location = new System.Drawing.Point(129, 131);
            this.txtFaturaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaKodu.Name = "txtFaturaKodu";
            this.txtFaturaKodu.Size = new System.Drawing.Size(97, 23);
            this.txtFaturaKodu.TabIndex = 37;
            this.txtFaturaKodu.TextChanged += new System.EventHandler(this.txtFaturaKodu_TextChanged);
            // 
            // cbIslem
            // 
            this.cbIslem.FormattingEnabled = true;
            this.cbIslem.Items.AddRange(new object[] {
            "Tüm İşlemler",
            "Nakit",
            "Kredi Kartı"});
            this.cbIslem.Location = new System.Drawing.Point(314, 130);
            this.cbIslem.Margin = new System.Windows.Forms.Padding(4);
            this.cbIslem.Name = "cbIslem";
            this.cbIslem.Size = new System.Drawing.Size(88, 24);
            this.cbIslem.TabIndex = 36;
            this.cbIslem.SelectedIndexChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "İşlem Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Müşteri Adı";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(23, 131);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(107, 23);
            this.txtMusteriAd.TabIndex = 31;
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // lvFaturalar
            // 
            this.lvFaturalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.Tutar});
            this.lvFaturalar.FullRowSelect = true;
            this.lvFaturalar.Location = new System.Drawing.Point(8, 162);
            this.lvFaturalar.Margin = new System.Windows.Forms.Padding(4);
            this.lvFaturalar.Name = "lvFaturalar";
            this.lvFaturalar.Size = new System.Drawing.Size(570, 342);
            this.lvFaturalar.TabIndex = 30;
            this.lvFaturalar.UseCompatibleStateImageBehavior = false;
            this.lvFaturalar.View = System.Windows.Forms.View.Details;
            this.lvFaturalar.DoubleClick += new System.EventHandler(this.lvFaturalar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fatura Kodu";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fatura Tipi";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tipi";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fatura Tarihi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FaturaID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MusteriID";
            this.columnHeader7.Width = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "İlk Tarih";
            // 
            // dtpFaturaSonTarih
            // 
            this.dtpFaturaSonTarih.Location = new System.Drawing.Point(274, 50);
            this.dtpFaturaSonTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFaturaSonTarih.Name = "dtpFaturaSonTarih";
            this.dtpFaturaSonTarih.Size = new System.Drawing.Size(19, 23);
            this.dtpFaturaSonTarih.TabIndex = 7;
            this.dtpFaturaSonTarih.ValueChanged += new System.EventHandler(this.dtpFaturaSonTarih_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Son Tarih";
            // 
            // dtpFaturaIlkTarih
            // 
            this.dtpFaturaIlkTarih.Location = new System.Drawing.Point(274, 22);
            this.dtpFaturaIlkTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFaturaIlkTarih.Name = "dtpFaturaIlkTarih";
            this.dtpFaturaIlkTarih.Size = new System.Drawing.Size(19, 23);
            this.dtpFaturaIlkTarih.TabIndex = 5;
            this.dtpFaturaIlkTarih.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpFaturaIlkTarih.ValueChanged += new System.EventHandler(this.dtpFaturaIlkTarih_ValueChanged);
            // 
            // gbFaturaTarihi
            // 
            this.gbFaturaTarihi.Controls.Add(this.txtIlkTarih);
            this.gbFaturaTarihi.Controls.Add(this.txtSonTarih);
            this.gbFaturaTarihi.Controls.Add(this.dtpFaturaIlkTarih);
            this.gbFaturaTarihi.Controls.Add(this.dtpFaturaSonTarih);
            this.gbFaturaTarihi.Controls.Add(this.label4);
            this.gbFaturaTarihi.Controls.Add(this.label5);
            this.gbFaturaTarihi.Location = new System.Drawing.Point(23, 15);
            this.gbFaturaTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.gbFaturaTarihi.Name = "gbFaturaTarihi";
            this.gbFaturaTarihi.Padding = new System.Windows.Forms.Padding(4);
            this.gbFaturaTarihi.Size = new System.Drawing.Size(312, 81);
            this.gbFaturaTarihi.TabIndex = 33;
            this.gbFaturaTarihi.TabStop = false;
            this.gbFaturaTarihi.Text = "Fatura Tarihi";
            // 
            // txtIlkTarih
            // 
            this.txtIlkTarih.Location = new System.Drawing.Point(84, 22);
            this.txtIlkTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtIlkTarih.Name = "txtIlkTarih";
            this.txtIlkTarih.Size = new System.Drawing.Size(192, 23);
            this.txtIlkTarih.TabIndex = 11;
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Location = new System.Drawing.Point(84, 50);
            this.txtSonTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(192, 23);
            this.txtSonTarih.TabIndex = 10;
            // 
            // btnDokuman
            // 
            this.btnDokuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDokuman.Image = global::wf_SporMarket.Properties.Resources.dökümanoluştur;
            this.btnDokuman.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokuman.Location = new System.Drawing.Point(386, 62);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(165, 32);
            this.btnDokuman.TabIndex = 67;
            this.btnDokuman.Text = "Döküman Oluştur";
            this.btnDokuman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokuman.UseVisualStyleBackColor = true;
            this.btnDokuman.Click += new System.EventHandler(this.btnDokuman_Click);
            // 
            // rvFatura
            // 
            this.rvFatura.DocumentMapWidth = 22;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vw_FaturalarBindingSource;
            this.rvFatura.LocalReport.DataSources.Add(reportDataSource2);
            this.rvFatura.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report2.rdlc";
            this.rvFatura.Location = new System.Drawing.Point(0, -1);
            this.rvFatura.Name = "rvFatura";
            this.rvFatura.Size = new System.Drawing.Size(32, 30);
            this.rvFatura.TabIndex = 68;
            this.rvFatura.Visible = false;
            this.rvFatura.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rvFatura_Print);
            // 
            // SporMarketDataSet
            // 
            this.SporMarketDataSet.DataSetName = "SporMarketDataSet";
            this.SporMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_StokGiriscikisBindingSource
            // 
            this.vw_StokGiriscikisBindingSource.DataMember = "vw_StokGiriscikis";
            this.vw_StokGiriscikisBindingSource.DataSource = this.SporMarketDataSet;
            // 
            // vw_StokGiriscikisTableAdapter
            // 
            this.vw_StokGiriscikisTableAdapter.ClearBeforeFill = true;
            // 
            // vw_FaturalarTableAdapter
            // 
            this.vw_FaturalarTableAdapter.ClearBeforeFill = true;
            // 
            // Tutar
            // 
            this.Tutar.Text = "Tutar";
            this.Tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tutar.Width = 80;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(478, 511);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 23);
            this.txtToplamTutar.TabIndex = 69;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(342, 511);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(130, 23);
            this.btnTopla.TabIndex = 71;
            this.btnTopla.Text = "Toplamı Göster";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // frmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(581, 541);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.rvFatura);
            this.Controls.Add(this.btnDokuman);
            this.Controls.Add(this.cbFatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFaturaKodu);
            this.Controls.Add(this.cbIslem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbFaturaTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.lvFaturalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.frmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_FaturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet1)).EndInit();
            this.gbFaturaTarihi.ResumeLayout(false);
            this.gbFaturaTarihi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFaturaKodu;
        private System.Windows.Forms.ComboBox cbIslem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.ListView lvFaturalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFaturaSonTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFaturaIlkTarih;
        private System.Windows.Forms.GroupBox gbFaturaTarihi;
        private System.Windows.Forms.TextBox txtIlkTarih;
        private System.Windows.Forms.TextBox txtSonTarih;
        private System.Windows.Forms.Button btnDokuman;
        private Microsoft.Reporting.WinForms.ReportViewer rvFatura;
        private System.Windows.Forms.BindingSource vw_StokGiriscikisBindingSource;
        private SporMarketDataSet SporMarketDataSet;
        private SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter vw_StokGiriscikisTableAdapter;
        private System.Windows.Forms.BindingSource vw_FaturalarBindingSource;
        private SporMarketDataSet1 SporMarketDataSet1;
        private SporMarketDataSet1TableAdapters.vw_FaturalarTableAdapter vw_FaturalarTableAdapter;
        private System.Windows.Forms.ColumnHeader Tutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btnTopla;
    }
}