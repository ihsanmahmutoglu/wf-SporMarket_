namespace wf_SporMarket
{
    partial class frmMusteriTanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriTanimlama));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txtil = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bCount = new System.Windows.Forms.ToolStripLabel();
            this.bnFirst = new System.Windows.Forms.ToolStripButton();
            this.bnPrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnNext = new System.Windows.Forms.ToolStripButton();
            this.bnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).BeginInit();
            this.bn1.SuspendLayout();
            this.SuspendLayout();
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
            this.lvMusteriler.Location = new System.Drawing.Point(351, 102);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(567, 301);
            this.lvMusteriler.TabIndex = 34;
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
            this.label9.Location = new System.Drawing.Point(356, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(562, 35);
            this.label9.TabIndex = 33;
            this.label9.Text = "MÜŞTERİLER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMusteriID);
            this.groupBox1.Controls.Add(this.cbCinsiyet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtilce);
            this.groupBox1.Controls.Add(this.txtil);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(315, 383);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgi Formu";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(7, 21);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(25, 20);
            this.txtMusteriID.TabIndex = 37;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(96, 282);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbCinsiyet.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cinsiyet";
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(96, 244);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(100, 20);
            this.txtilce.TabIndex = 27;
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(96, 210);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(100, 20);
            this.txtil.TabIndex = 26;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(239, 319);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 36);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "İlçe";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(165, 319);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(64, 36);
            this.btnDegistir.TabIndex = 24;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "İl";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(91, 319);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 36);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(17, 319);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(64, 36);
            this.btnYeni.TabIndex = 22;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(96, 38);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(207, 20);
            this.txtAdi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(96, 73);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(207, 20);
            this.txtSoyadi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(96, 108);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(207, 20);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(96, 143);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(207, 55);
            this.txtAdres.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres";
            // 
            // bn1
            // 
            this.bn1.AddNewItem = null;
            this.bn1.CountItem = this.bCount;
            this.bn1.DeleteItem = null;
            this.bn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnFirst,
            this.bnPrev,
            this.bindingNavigatorSeparator,
            this.bPosition,
            this.bCount,
            this.bindingNavigatorSeparator1,
            this.bnNext,
            this.bnLast,
            this.bindingNavigatorSeparator2});
            this.bn1.Location = new System.Drawing.Point(0, 0);
            this.bn1.MoveFirstItem = this.bnFirst;
            this.bn1.MoveLastItem = this.bnLast;
            this.bn1.MoveNextItem = this.bnNext;
            this.bn1.MovePreviousItem = this.bnPrev;
            this.bn1.Name = "bn1";
            this.bn1.PositionItem = this.bPosition;
            this.bn1.Size = new System.Drawing.Size(947, 25);
            this.bn1.TabIndex = 36;
            this.bn1.Text = "bindingNavigator1";
            // 
            // bCount
            // 
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(35, 22);
            this.bCount.Text = "of {0}";
            this.bCount.ToolTipText = "Total number of items";
            // 
            // bnFirst
            // 
            this.bnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnFirst.Image")));
            this.bnFirst.Name = "bnFirst";
            this.bnFirst.RightToLeftAutoMirrorImage = true;
            this.bnFirst.Size = new System.Drawing.Size(23, 22);
            this.bnFirst.Text = "Move first";
            this.bnFirst.Click += new System.EventHandler(this.bnFirst_Click);
            // 
            // bnPrev
            // 
            this.bnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnPrev.Image = ((System.Drawing.Image)(resources.GetObject("bnPrev.Image")));
            this.bnPrev.Name = "bnPrev";
            this.bnPrev.RightToLeftAutoMirrorImage = true;
            this.bnPrev.Size = new System.Drawing.Size(23, 22);
            this.bnPrev.Text = "Move previous";
            this.bnPrev.Click += new System.EventHandler(this.bnPrev_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bPosition
            // 
            this.bPosition.AccessibleName = "Position";
            this.bPosition.AutoSize = false;
            this.bPosition.Name = "bPosition";
            this.bPosition.Size = new System.Drawing.Size(50, 23);
            this.bPosition.Text = "0";
            this.bPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnNext
            // 
            this.bnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnNext.Image = ((System.Drawing.Image)(resources.GetObject("bnNext.Image")));
            this.bnNext.Name = "bnNext";
            this.bnNext.RightToLeftAutoMirrorImage = true;
            this.bnNext.Size = new System.Drawing.Size(23, 22);
            this.bnNext.Text = "Move next";
            this.bnNext.Click += new System.EventHandler(this.bnNext_Click);
            // 
            // bnLast
            // 
            this.bnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnLast.Image = ((System.Drawing.Image)(resources.GetObject("bnLast.Image")));
            this.bnLast.Name = "bnLast";
            this.bnLast.RightToLeftAutoMirrorImage = true;
            this.bnLast.Size = new System.Drawing.Size(23, 22);
            this.bnLast.Text = "Move last";
            this.bnLast.Click += new System.EventHandler(this.bnLast_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMusteriTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 499);
            this.Controls.Add(this.bn1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.label9);
            this.Name = "frmMusteriTanimlama";
            this.Text = "frmMusteriTanimlama";
            this.Load += new System.EventHandler(this.frmMusteriTanimlama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).EndInit();
            this.bn1.ResumeLayout(false);
            this.bn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator bn1;
        private System.Windows.Forms.ToolStripLabel bCount;
        private System.Windows.Forms.ToolStripButton bnFirst;
        private System.Windows.Forms.ToolStripButton bnPrev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnNext;
        private System.Windows.Forms.ToolStripButton bnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtMusteriID;
    }
}