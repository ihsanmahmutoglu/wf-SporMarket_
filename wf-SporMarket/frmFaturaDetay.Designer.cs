namespace wf_SporMarket
{
    partial class frmFaturaDetay
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
            this.button6 = new System.Windows.Forms.Button();
            this.lvFaturaDetay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMusteriadi = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFaturaTipi = new System.Windows.Forms.TextBox();
            this.txtFaturaKodu = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SporMarketDataSet2 = new wf_SporMarket.SporMarketDataSet2();
            this.vw_GunlukKasaSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_GunlukKasaSatisTableAdapter = new wf_SporMarket.SporMarketDataSet2TableAdapters.vw_GunlukKasaSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GunlukKasaSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = global::wf_SporMarket.Properties.Resources.dökümanoluştur;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(448, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 32);
            this.button6.TabIndex = 66;
            this.button6.Text = "Döküman Oluştur";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lvFaturaDetay
            // 
            this.lvFaturaDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvFaturaDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvFaturaDetay.FullRowSelect = true;
            this.lvFaturaDetay.GridLines = true;
            this.lvFaturaDetay.Location = new System.Drawing.Point(12, 97);
            this.lvFaturaDetay.Name = "lvFaturaDetay";
            this.lvFaturaDetay.Size = new System.Drawing.Size(599, 336);
            this.lvFaturaDetay.TabIndex = 63;
            this.lvFaturaDetay.UseCompatibleStateImageBehavior = false;
            this.lvFaturaDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HareketID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunKodu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 99;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "UrunAd";
            this.columnHeader12.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BirimFiyat";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KDV\'sizTutar";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "KDV\'liTutar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 113;
            // 
            // txtMusteriadi
            // 
            this.txtMusteriadi.Location = new System.Drawing.Point(106, 25);
            this.txtMusteriadi.Name = "txtMusteriadi";
            this.txtMusteriadi.ReadOnly = true;
            this.txtMusteriadi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriadi.TabIndex = 67;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(106, 51);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.ReadOnly = true;
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyadi.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fatura Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Fatura Kodu";
            // 
            // txtFaturaTipi
            // 
            this.txtFaturaTipi.Location = new System.Drawing.Point(322, 51);
            this.txtFaturaTipi.Name = "txtFaturaTipi";
            this.txtFaturaTipi.ReadOnly = true;
            this.txtFaturaTipi.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaTipi.TabIndex = 72;
            // 
            // txtFaturaKodu
            // 
            this.txtFaturaKodu.Location = new System.Drawing.Point(322, 25);
            this.txtFaturaKodu.Name = "txtFaturaKodu";
            this.txtFaturaKodu.ReadOnly = true;
            this.txtFaturaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaKodu.TabIndex = 71;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 80;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_GunlukKasaSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(82, 43);
            this.reportViewer1.TabIndex = 75;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            // 
            // SporMarketDataSet2
            // 
            this.SporMarketDataSet2.DataSetName = "SporMarketDataSet2";
            this.SporMarketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_GunlukKasaSatisBindingSource
            // 
            this.vw_GunlukKasaSatisBindingSource.DataMember = "vw_GunlukKasaSatis";
            this.vw_GunlukKasaSatisBindingSource.DataSource = this.SporMarketDataSet2;
            // 
            // vw_GunlukKasaSatisTableAdapter
            // 
            this.vw_GunlukKasaSatisTableAdapter.ClearBeforeFill = true;
            // 
            // frmFaturaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFaturaTipi);
            this.Controls.Add(this.txtFaturaKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriSoyadi);
            this.Controls.Add(this.txtMusteriadi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lvFaturaDetay);
            this.Name = "frmFaturaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Detayları";
            this.Load += new System.EventHandler(this.frmFaturaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GunlukKasaSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView lvFaturaDetay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtMusteriadi;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFaturaTipi;
        private System.Windows.Forms.TextBox txtFaturaKodu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_GunlukKasaSatisBindingSource;
        private SporMarketDataSet2 SporMarketDataSet2;
        private SporMarketDataSet2TableAdapters.vw_GunlukKasaSatisTableAdapter vw_GunlukKasaSatisTableAdapter;
    }
}