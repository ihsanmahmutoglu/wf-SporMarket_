namespace wf_SporMarket
{
    partial class frmStokGoruntule
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
            this.label18 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodaGore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(36, 216);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 54;
            this.label18.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(120, 212);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(81, 23);
            this.txtNumara.TabIndex = 53;
            this.txtNumara.TextChanged += new System.EventHandler(this.txtNumara_TextChanged);
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Items.AddRange(new object[] {
            "Hepsi"});
            this.cbKategoriler.Location = new System.Drawing.Point(120, 167);
            this.cbKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(107, 24);
            this.cbKategoriler.TabIndex = 52;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(36, 170);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Kategori";
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Items.AddRange(new object[] {
            "Hepsi"});
            this.cbMarkalar.Location = new System.Drawing.Point(120, 124);
            this.cbMarkalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(124, 24);
            this.cbMarkalar.TabIndex = 50;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(36, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Marka";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdaGore.Location = new System.Drawing.Point(120, 79);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(124, 23);
            this.txtAdaGore.TabIndex = 48;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ürün Adı";
            // 
            // txtKodaGore
            // 
            this.txtKodaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKodaGore.Location = new System.Drawing.Point(120, 41);
            this.txtKodaGore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtKodaGore.Name = "txtKodaGore";
            this.txtKodaGore.Size = new System.Drawing.Size(124, 23);
            this.txtKodaGore.TabIndex = 46;
            this.txtKodaGore.TextChanged += new System.EventHandler(this.txtKodaGore_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(36, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ürün Kodu";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(284, 23);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(613, 351);
            this.dgvUrunler.TabIndex = 61;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            this.dgvUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtKodaGore);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.txtAdaGore);
            this.groupBox1.Controls.Add(this.cbKategoriler);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbMarkalar);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 351);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Arama";
            // 
            // frmStokGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStokGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Sorgulama";
            this.Load += new System.EventHandler(this.frmStokGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKodaGore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}