namespace wf_SporMarket
{
    partial class frmTedarikciTanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTedarikciTanimlama));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bCount = new System.Windows.Forms.ToolStripLabel();
            this.bnFirst = new System.Windows.Forms.ToolStripButton();
            this.bnPrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnNext = new System.Windows.Forms.ToolStripButton();
            this.bnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lvTedarikciler = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtFirmaID = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bCount;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnFirst,
            this.bnPrev,
            this.bindingNavigatorSeparator,
            this.bPosition,
            this.bCount,
            this.bindingNavigatorSeparator1,
            this.bnNext,
            this.bnLast,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(141, 16);
            this.bindingNavigator1.MoveFirstItem = this.bnFirst;
            this.bindingNavigator1.MoveLastItem = this.bnLast;
            this.bindingNavigator1.MoveNextItem = this.bnNext;
            this.bindingNavigator1.MovePreviousItem = this.bnPrev;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bPosition;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 38;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // lvTedarikciler
            // 
            this.lvTedarikciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvTedarikciler.FullRowSelect = true;
            this.lvTedarikciler.Location = new System.Drawing.Point(409, 73);
            this.lvTedarikciler.Margin = new System.Windows.Forms.Padding(4);
            this.lvTedarikciler.Name = "lvTedarikciler";
            this.lvTedarikciler.Size = new System.Drawing.Size(613, 438);
            this.lvTedarikciler.TabIndex = 37;
            this.lvTedarikciler.UseCompatibleStateImageBehavior = false;
            this.lvTedarikciler.View = System.Windows.Forms.View.Details;
            this.lvTedarikciler.SelectedIndexChanged += new System.EventHandler(this.lvTedarikciler_SelectedIndexChanged);
            this.lvTedarikciler.DoubleClick += new System.EventHandler(this.lvTedarikciler_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "FirmaID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Unvan";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Yetkili";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Telefon";
            this.columnHeader13.Width = 74;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Adres";
            this.columnHeader14.Width = 79;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "İL";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "İlce";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "VergiNo";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader17.Width = 81;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "VergiDairesi";
            this.columnHeader18.Width = 100;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(410, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(612, 43);
            this.label9.TabIndex = 36;
            this.label9.Text = "TEDARİKÇİLER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.txtFirmaID);
            this.groupBox1.Controls.Add(this.txtVergiNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVergiDairesi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtilce);
            this.groupBox1.Controls.Add(this.txtil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnvan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYetkili);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(383, 498);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Bilgi Formu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.delete;
            this.btnSil.Location = new System.Drawing.Point(286, 425);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 68);
            this.btnSil.TabIndex = 82;
            this.btnSil.Text = " ";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Image = global::wf_SporMarket.Properties.Resources.update;
            this.btnDegistir.Location = new System.Drawing.Point(202, 425);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(80, 68);
            this.btnDegistir.TabIndex = 81;
            this.btnDegistir.Text = " ";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Image = global::wf_SporMarket.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(118, 425);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 68);
            this.btnKaydet.TabIndex = 80;
            this.btnKaydet.Text = " ";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Image = global::wf_SporMarket.Properties.Resources._new;
            this.btnYeni.Location = new System.Drawing.Point(34, 425);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(80, 68);
            this.btnYeni.TabIndex = 79;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtFirmaID
            // 
            this.txtFirmaID.Location = new System.Drawing.Point(9, 22);
            this.txtFirmaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.Size = new System.Drawing.Size(37, 23);
            this.txtFirmaID.TabIndex = 35;
            this.txtFirmaID.Visible = false;
            this.txtFirmaID.TextChanged += new System.EventHandler(this.txtFirmaID_TextChanged);
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(141, 342);
            this.txtVergiNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(222, 23);
            this.txtVergiNo.TabIndex = 31;
            this.txtVergiNo.TextChanged += new System.EventHandler(this.txtVergiNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Vergi Dairesi";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(141, 392);
            this.txtVergiDairesi.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(222, 23);
            this.txtVergiDairesi.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Vergi No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(141, 302);
            this.txtilce.Margin = new System.Windows.Forms.Padding(4);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(222, 23);
            this.txtilce.TabIndex = 27;
            this.txtilce.TextChanged += new System.EventHandler(this.txtilce_TextChanged);
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(141, 260);
            this.txtil.Margin = new System.Windows.Forms.Padding(4);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(222, 23);
            this.txtil.TabIndex = 26;
            this.txtil.TextChanged += new System.EventHandler(this.txtil_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "İlçe";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "İl";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Unvan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(141, 48);
            this.txtUnvan.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(222, 23);
            this.txtUnvan.TabIndex = 15;
            this.txtUnvan.TextChanged += new System.EventHandler(this.txtUnvan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yetkili";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(141, 91);
            this.txtYetkili.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(222, 23);
            this.txtYetkili.TabIndex = 17;
            this.txtYetkili.TextChanged += new System.EventHandler(this.txtYetkili_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(141, 134);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(222, 23);
            this.txtTelefon.TabIndex = 19;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(141, 178);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(222, 67);
            this.txtAdres.TabIndex = 21;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmTedarikciTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1033, 515);
            this.Controls.Add(this.lvTedarikciler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTedarikciTanimlama";
            this.Text = "Tedarikçi Tanımlama";
            this.Load += new System.EventHandler(this.frmTedarikciTanimlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bCount;
        private System.Windows.Forms.ToolStripButton bnFirst;
        private System.Windows.Forms.ToolStripButton bnPrev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnNext;
        private System.Windows.Forms.ToolStripButton bnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ListView lvTedarikciler;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirmaID;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}