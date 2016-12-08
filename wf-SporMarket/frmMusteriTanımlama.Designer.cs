namespace wf_SporMarket
{
    partial class frmMusteriTanımlama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.txtMusteriID);
            this.groupBox1.Controls.Add(this.cbCinsiyet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtilce);
            this.groupBox1.Controls.Add(this.txtil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(400, 479);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgi Formu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.delete;
            this.btnSil.Location = new System.Drawing.Point(293, 400);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 68);
            this.btnSil.TabIndex = 78;
            this.btnSil.Text = " ";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Image = global::wf_SporMarket.Properties.Resources.update;
            this.btnDegistir.Location = new System.Drawing.Point(209, 400);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(80, 68);
            this.btnDegistir.TabIndex = 77;
            this.btnDegistir.Text = " ";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Image = global::wf_SporMarket.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(125, 400);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 68);
            this.btnKaydet.TabIndex = 76;
            this.btnKaydet.Text = " ";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Image = global::wf_SporMarket.Properties.Resources._new;
            this.btnYeni.Location = new System.Drawing.Point(41, 400);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(80, 68);
            this.btnYeni.TabIndex = 75;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click_1);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(9, 26);
            this.txtMusteriID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(32, 23);
            this.txtMusteriID.TabIndex = 37;
            this.txtMusteriID.Visible = false;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(132, 370);
            this.cbCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(132, 24);
            this.cbCinsiyet.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cinsiyet";
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(132, 324);
            this.txtilce.Margin = new System.Windows.Forms.Padding(4);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(132, 23);
            this.txtilce.TabIndex = 27;
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(132, 282);
            this.txtil.Margin = new System.Windows.Forms.Padding(4);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(132, 23);
            this.txtil.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "İl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(132, 70);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(241, 23);
            this.txtAdi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(132, 113);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(241, 23);
            this.txtSoyadi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(132, 156);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(241, 23);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(132, 199);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(241, 67);
            this.txtAdres.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader1});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(448, 73);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(574, 428);
            this.lvMusteriler.TabIndex = 38;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Cinsiyet";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MüsteriAd";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MüsteriSoyad";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Telefon";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adres";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "İL";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "İlçe";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MusteriID";
            this.columnHeader1.Width = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(447, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(578, 43);
            this.label9.TabIndex = 37;
            this.label9.Text = "MÜŞTERİLER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMusteriTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMusteriTanımlama";
            this.Text = "Müşteri Tanımlama";
            this.Load += new System.EventHandler(this.frmMusteriTanımlama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}