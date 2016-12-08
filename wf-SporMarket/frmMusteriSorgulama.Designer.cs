namespace wf_SporMarket
{
    partial class frmMusteriSorgulama
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMcinsiyet = new System.Windows.Forms.ComboBox();
            this.txtMilce = new System.Windows.Forms.TextBox();
            this.txtMil = new System.Windows.Forms.TextBox();
            this.txtMtelefon = new System.Windows.Forms.TextBox();
            this.txtMsoyadi = new System.Windows.Forms.TextBox();
            this.txtMadi = new System.Windows.Forms.TextBox();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 63;
            this.label15.Text = "Cinsiyet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 241);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "İlçe";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 203);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "İl";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Ad";
            // 
            // cbMcinsiyet
            // 
            this.cbMcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMcinsiyet.FormattingEnabled = true;
            this.cbMcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Hepsi"});
            this.cbMcinsiyet.Location = new System.Drawing.Point(87, 59);
            this.cbMcinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMcinsiyet.Name = "cbMcinsiyet";
            this.cbMcinsiyet.Size = new System.Drawing.Size(112, 24);
            this.cbMcinsiyet.TabIndex = 57;
            this.cbMcinsiyet.SelectedIndexChanged += new System.EventHandler(this.cbMcinsiyet_SelectedIndexChanged_1);
            // 
            // txtMilce
            // 
            this.txtMilce.Location = new System.Drawing.Point(87, 235);
            this.txtMilce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMilce.Name = "txtMilce";
            this.txtMilce.Size = new System.Drawing.Size(112, 23);
            this.txtMilce.TabIndex = 56;
            this.txtMilce.TextChanged += new System.EventHandler(this.txtMilce_TextChanged);
            // 
            // txtMil
            // 
            this.txtMil.Location = new System.Drawing.Point(87, 200);
            this.txtMil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMil.Name = "txtMil";
            this.txtMil.Size = new System.Drawing.Size(112, 23);
            this.txtMil.TabIndex = 55;
            this.txtMil.TextChanged += new System.EventHandler(this.txtMil_TextChanged);
            // 
            // txtMtelefon
            // 
            this.txtMtelefon.Location = new System.Drawing.Point(87, 165);
            this.txtMtelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMtelefon.Name = "txtMtelefon";
            this.txtMtelefon.Size = new System.Drawing.Size(112, 23);
            this.txtMtelefon.TabIndex = 54;
            this.txtMtelefon.TextChanged += new System.EventHandler(this.txtMtelefon_TextChanged);
            // 
            // txtMsoyadi
            // 
            this.txtMsoyadi.Location = new System.Drawing.Point(87, 130);
            this.txtMsoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsoyadi.Name = "txtMsoyadi";
            this.txtMsoyadi.Size = new System.Drawing.Size(112, 23);
            this.txtMsoyadi.TabIndex = 53;
            this.txtMsoyadi.TextChanged += new System.EventHandler(this.txtMsoyadi_TextChanged);
            // 
            // txtMadi
            // 
            this.txtMadi.Location = new System.Drawing.Point(87, 95);
            this.txtMadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadi.Name = "txtMadi";
            this.txtMadi.Size = new System.Drawing.Size(112, 23);
            this.txtMadi.TabIndex = 52;
            this.txtMadi.TextChanged += new System.EventHandler(this.txtMadi_TextChanged);
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(238, 13);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(658, 347);
            this.lvMusteriler.TabIndex = 51;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adres";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İl";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İlçe";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cbMcinsiyet);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMadi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtMsoyadi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMtelefon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMil);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMilce);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 347);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ara";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(910, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMusteriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMusteriSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMcinsiyet;
        private System.Windows.Forms.TextBox txtMilce;
        private System.Windows.Forms.TextBox txtMil;
        private System.Windows.Forms.TextBox txtMtelefon;
        private System.Windows.Forms.TextBox txtMsoyadi;
        private System.Windows.Forms.TextBox txtMadi;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}