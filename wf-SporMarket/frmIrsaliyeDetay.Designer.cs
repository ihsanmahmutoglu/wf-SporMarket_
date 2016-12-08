namespace wf_SporMarket
{
    partial class frmIrsaliyeDetay
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
            this.lvStokHareket = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIrsaliyeAdi = new System.Windows.Forms.TextBox();
            this.txtIrsaliyeKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SporMarketDataSet = new wf_SporMarket.SporMarketDataSet();
            this.vw_StokGiriscikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_StokGiriscikisTableAdapter = new wf_SporMarket.SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvStokHareket
            // 
            this.lvStokHareket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader5});
            this.lvStokHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvStokHareket.FullRowSelect = true;
            this.lvStokHareket.GridLines = true;
            this.lvStokHareket.Location = new System.Drawing.Point(12, 113);
            this.lvStokHareket.Name = "lvStokHareket";
            this.lvStokHareket.Size = new System.Drawing.Size(401, 338);
            this.lvStokHareket.TabIndex = 64;
            this.lvStokHareket.UseCompatibleStateImageBehavior = false;
            this.lvStokHareket.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HareketID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Kodu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "UrunAd";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 94;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = global::wf_SporMarket.Properties.Resources.dökümanoluştur;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(248, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 32);
            this.button6.TabIndex = 67;
            this.button6.Text = "Döküman Oluştur";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "İrsaliye Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "İrsaliye Kodu";
            // 
            // txtIrsaliyeAdi
            // 
            this.txtIrsaliyeAdi.Location = new System.Drawing.Point(277, 49);
            this.txtIrsaliyeAdi.Name = "txtIrsaliyeAdi";
            this.txtIrsaliyeAdi.ReadOnly = true;
            this.txtIrsaliyeAdi.Size = new System.Drawing.Size(129, 20);
            this.txtIrsaliyeAdi.TabIndex = 80;
            // 
            // txtIrsaliyeKodu
            // 
            this.txtIrsaliyeKodu.Location = new System.Drawing.Point(277, 23);
            this.txtIrsaliyeKodu.Name = "txtIrsaliyeKodu";
            this.txtIrsaliyeKodu.ReadOnly = true;
            this.txtIrsaliyeKodu.Size = new System.Drawing.Size(129, 20);
            this.txtIrsaliyeKodu.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Yetkili";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ünvan";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(71, 49);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.ReadOnly = true;
            this.txtYetkili.Size = new System.Drawing.Size(122, 20);
            this.txtYetkili.TabIndex = 76;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(71, 23);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.ReadOnly = true;
            this.txtUnvan.Size = new System.Drawing.Size(122, 20);
            this.txtUnvan.TabIndex = 75;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 88;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_StokGiriscikisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wf_SporMarket.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(90, 41);
            this.reportViewer1.TabIndex = 83;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
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
            // frmIrsaliyeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(418, 480);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIrsaliyeAdi);
            this.Controls.Add(this.txtIrsaliyeKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lvStokHareket);
            this.Name = "frmIrsaliyeDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIrsaliyeDetay";
            this.Load += new System.EventHandler(this.frmIrsaliyeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SporMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StokGiriscikisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStokHareket;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIrsaliyeAdi;
        private System.Windows.Forms.TextBox txtIrsaliyeKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.TextBox txtUnvan;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_StokGiriscikisBindingSource;
        private SporMarketDataSet SporMarketDataSet;
        private SporMarketDataSetTableAdapters.vw_StokGiriscikisTableAdapter vw_StokGiriscikisTableAdapter;
    }
}