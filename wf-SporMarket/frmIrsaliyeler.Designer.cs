namespace wf_SporMarket
{
    partial class frmIrsaliyeler
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
            this.vw_IrsaliyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SporMarketDataSet3 = new wf_SporMarket.SporMarketDataSet3();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIrsaliyeKodunaGore = new System.Windows.Forms.TextBox();
            this.cbIrsaliyeTuruneGore = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnvanaGore = new System.Windows.Forms.TextBox();
            this.lvIrsaliyeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFaturaTarihi = new System.Windows.Forms.GroupBox();
            this.txtIlkTarih = new System.Windows.Forms.TextBox();
            this.txtSonTarih = new System.Windows.Forms.TextBox();
            this.dtpFaturaIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFaturaSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_IrsaliyelerTableAdapter = new wf_SporMarket.SporMarketDataSet3TableAdapters.vw_IrsaliyelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_IrsaliyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet3)).BeginInit();
            this.gbFaturaTarihi.SuspendLayout();
            this.SuspendLayout();
            // 
            // vw_IrsaliyelerBindingSource
            // 
            this.vw_IrsaliyelerBindingSource.DataMember = "vw_Irsaliyeler";
            this.vw_IrsaliyelerBindingSource.DataSource = this.SporMarketDataSet3;
            // 
            // SporMarketDataSet3
            // 
            this.SporMarketDataSet3.DataSetName = "SporMarketDataSet3";
            this.SporMarketDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "İrsaliye Kodu";
            // 
            // txtIrsaliyeKodunaGore
            // 
            this.txtIrsaliyeKodunaGore.Location = new System.Drawing.Point(164, 140);
            this.txtIrsaliyeKodunaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtIrsaliyeKodunaGore.Name = "txtIrsaliyeKodunaGore";
            this.txtIrsaliyeKodunaGore.Size = new System.Drawing.Size(93, 23);
            this.txtIrsaliyeKodunaGore.TabIndex = 26;
            this.txtIrsaliyeKodunaGore.TextChanged += new System.EventHandler(this.txtIrsaliyeKodunaGore_TextChanged);
            // 
            // cbIrsaliyeTuruneGore
            // 
            this.cbIrsaliyeTuruneGore.FormattingEnabled = true;
            this.cbIrsaliyeTuruneGore.Items.AddRange(new object[] {
            "TümTürler",
            "Giriş",
            "Çıkış"});
            this.cbIrsaliyeTuruneGore.Location = new System.Drawing.Point(257, 139);
            this.cbIrsaliyeTuruneGore.Margin = new System.Windows.Forms.Padding(4);
            this.cbIrsaliyeTuruneGore.Name = "cbIrsaliyeTuruneGore";
            this.cbIrsaliyeTuruneGore.Size = new System.Drawing.Size(96, 24);
            this.cbIrsaliyeTuruneGore.TabIndex = 25;
            this.cbIrsaliyeTuruneGore.SelectedIndexChanged += new System.EventHandler(this.cbIrsaliyeTuruneGore_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "İrsaliye Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tedarikçi Unvanı";
            // 
            // txtUnvanaGore
            // 
            this.txtUnvanaGore.Location = new System.Drawing.Point(16, 140);
            this.txtUnvanaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnvanaGore.Name = "txtUnvanaGore";
            this.txtUnvanaGore.Size = new System.Drawing.Size(149, 23);
            this.txtUnvanaGore.TabIndex = 19;
            this.txtUnvanaGore.TextChanged += new System.EventHandler(this.txtUnvanaGore_TextChanged);
            // 
            // lvIrsaliyeler
            // 
            this.lvIrsaliyeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lvIrsaliyeler.FullRowSelect = true;
            this.lvIrsaliyeler.Location = new System.Drawing.Point(16, 182);
            this.lvIrsaliyeler.Margin = new System.Windows.Forms.Padding(4);
            this.lvIrsaliyeler.Name = "lvIrsaliyeler";
            this.lvIrsaliyeler.Size = new System.Drawing.Size(497, 296);
            this.lvIrsaliyeler.TabIndex = 18;
            this.lvIrsaliyeler.UseCompatibleStateImageBehavior = false;
            this.lvIrsaliyeler.View = System.Windows.Forms.View.Details;
            this.lvIrsaliyeler.DoubleClick += new System.EventHandler(this.lvIrsaliyeler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tedarikçi Unvanı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Irsaliye Kodu";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Irsaliye Türü";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İrsaliye Tarihi";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IrsaliyeID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "FirmaID";
            this.columnHeader7.Width = 0;
            // 
            // gbFaturaTarihi
            // 
            this.gbFaturaTarihi.Controls.Add(this.txtIlkTarih);
            this.gbFaturaTarihi.Controls.Add(this.txtSonTarih);
            this.gbFaturaTarihi.Controls.Add(this.dtpFaturaIlkTarih);
            this.gbFaturaTarihi.Controls.Add(this.label4);
            this.gbFaturaTarihi.Controls.Add(this.dtpFaturaSonTarih);
            this.gbFaturaTarihi.Controls.Add(this.label5);
            this.gbFaturaTarihi.Location = new System.Drawing.Point(119, 19);
            this.gbFaturaTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.gbFaturaTarihi.Name = "gbFaturaTarihi";
            this.gbFaturaTarihi.Padding = new System.Windows.Forms.Padding(4);
            this.gbFaturaTarihi.Size = new System.Drawing.Size(332, 81);
            this.gbFaturaTarihi.TabIndex = 34;
            this.gbFaturaTarihi.TabStop = false;
            this.gbFaturaTarihi.Text = "İrsaliye Tarihi";
            // 
            // txtIlkTarih
            // 
            this.txtIlkTarih.Location = new System.Drawing.Point(113, 22);
            this.txtIlkTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtIlkTarih.Name = "txtIlkTarih";
            this.txtIlkTarih.Size = new System.Drawing.Size(188, 23);
            this.txtIlkTarih.TabIndex = 11;
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Location = new System.Drawing.Point(113, 50);
            this.txtSonTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(188, 23);
            this.txtSonTarih.TabIndex = 10;
            // 
            // dtpFaturaIlkTarih
            // 
            this.dtpFaturaIlkTarih.Location = new System.Drawing.Point(300, 22);
            this.dtpFaturaIlkTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFaturaIlkTarih.Name = "dtpFaturaIlkTarih";
            this.dtpFaturaIlkTarih.Size = new System.Drawing.Size(19, 23);
            this.dtpFaturaIlkTarih.TabIndex = 5;
            this.dtpFaturaIlkTarih.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpFaturaIlkTarih.ValueChanged += new System.EventHandler(this.dtpFaturaIlkTarih_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Son Tarih";
            // 
            // dtpFaturaSonTarih
            // 
            this.dtpFaturaSonTarih.Location = new System.Drawing.Point(300, 50);
            this.dtpFaturaSonTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFaturaSonTarih.Name = "dtpFaturaSonTarih";
            this.dtpFaturaSonTarih.Size = new System.Drawing.Size(19, 23);
            this.dtpFaturaSonTarih.TabIndex = 7;
            this.dtpFaturaSonTarih.ValueChanged += new System.EventHandler(this.dtpFaturaSonTarih_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "İlk Tarih";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = global::wf_SporMarket.Properties.Resources.dökümanoluştur;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(360, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 36);
            this.button6.TabIndex = 68;
            this.button6.Text = "Döküman Oluştur";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 61;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_IrsaliyelerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(63, 39);
            this.reportViewer1.TabIndex = 69;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            // 
            // vw_IrsaliyelerTableAdapter
            // 
            this.vw_IrsaliyelerTableAdapter.ClearBeforeFill = true;
            // 
            // frmIrsaliyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(524, 497);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.gbFaturaTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIrsaliyeKodunaGore);
            this.Controls.Add(this.cbIrsaliyeTuruneGore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnvanaGore);
            this.Controls.Add(this.lvIrsaliyeler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIrsaliyeler";
            this.Text = "frmIrsaliye";
            this.Load += new System.EventHandler(this.frmIrsaliyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_IrsaliyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet3)).EndInit();
            this.gbFaturaTarihi.ResumeLayout(false);
            this.gbFaturaTarihi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIrsaliyeKodunaGore;
        private System.Windows.Forms.ComboBox cbIrsaliyeTuruneGore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnvanaGore;
        private System.Windows.Forms.ListView lvIrsaliyeler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox gbFaturaTarihi;
        private System.Windows.Forms.TextBox txtIlkTarih;
        private System.Windows.Forms.TextBox txtSonTarih;
        private System.Windows.Forms.DateTimePicker dtpFaturaIlkTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFaturaSonTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_IrsaliyelerBindingSource;
        private SporMarketDataSet3 SporMarketDataSet3;
        private SporMarketDataSet3TableAdapters.vw_IrsaliyelerTableAdapter vw_IrsaliyelerTableAdapter;
    }
}