namespace wf_SporMarket
{
    partial class frmKategoriler
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
            this.txtKatogoriID = new System.Windows.Forms.TextBox();
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKatogoriID
            // 
            this.txtKatogoriID.Location = new System.Drawing.Point(60, 33);
            this.txtKatogoriID.Margin = new System.Windows.Forms.Padding(4);
            this.txtKatogoriID.Name = "txtKatogoriID";
            this.txtKatogoriID.ReadOnly = true;
            this.txtKatogoriID.Size = new System.Drawing.Size(31, 23);
            this.txtKatogoriID.TabIndex = 46;
            this.txtKatogoriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKatogoriID.Visible = false;
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader16});
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.Location = new System.Drawing.Point(15, 230);
            this.lvKategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(393, 183);
            this.lvKategoriler.TabIndex = 45;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.DoubleClick += new System.EventHandler(this.lvKategoriler_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kategori Adı";
            this.columnHeader10.Width = 190;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Açıklama";
            this.columnHeader11.Width = 250;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "KategoriID";
            this.columnHeader16.Width = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(99, 65);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(269, 90);
            this.txtAciklama.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Açıklama";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(99, 33);
            this.txtKategoriAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(269, 23);
            this.txtKategoriAdi.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Kategori";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.iptal_kucuk;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(336, 183);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 37);
            this.btnSil.TabIndex = 78;
            this.btnSil.Text = " Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Image = global::wf_SporMarket.Properties.Resources.update_kucuk;
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegistir.Location = new System.Drawing.Point(236, 183);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(91, 37);
            this.btnDegistir.TabIndex = 77;
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
            this.btnKaydet.Location = new System.Drawing.Point(136, 183);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnKaydet.TabIndex = 76;
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
            this.btnYeni.Location = new System.Drawing.Point(36, 183);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(91, 37);
            this.btnYeni.TabIndex = 75;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(422, 437);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtKatogoriID);
            this.Controls.Add(this.lvKategoriler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKategoriler";
            this.Text = "Kategori Tanımlama";
            this.Load += new System.EventHandler(this.frmKategoriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKatogoriID;
        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}