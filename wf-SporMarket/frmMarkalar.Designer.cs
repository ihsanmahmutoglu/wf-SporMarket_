namespace wf_SporMarket
{
    partial class frmMarkalar
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
            this.txtMarkaNo = new System.Windows.Forms.TextBox();
            this.lvMarkalar = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarkaNo
            // 
            this.txtMarkaNo.Location = new System.Drawing.Point(63, 21);
            this.txtMarkaNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarkaNo.Name = "txtMarkaNo";
            this.txtMarkaNo.ReadOnly = true;
            this.txtMarkaNo.Size = new System.Drawing.Size(48, 23);
            this.txtMarkaNo.TabIndex = 52;
            this.txtMarkaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMarkaNo.Visible = false;
            // 
            // lvMarkalar
            // 
            this.lvMarkalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader12});
            this.lvMarkalar.FullRowSelect = true;
            this.lvMarkalar.GridLines = true;
            this.lvMarkalar.Location = new System.Drawing.Point(121, 80);
            this.lvMarkalar.Margin = new System.Windows.Forms.Padding(5);
            this.lvMarkalar.Name = "lvMarkalar";
            this.lvMarkalar.Size = new System.Drawing.Size(226, 224);
            this.lvMarkalar.TabIndex = 51;
            this.lvMarkalar.UseCompatibleStateImageBehavior = false;
            this.lvMarkalar.View = System.Windows.Forms.View.Details;
            this.lvMarkalar.DoubleClick += new System.EventHandler(this.lvMarkalar_DoubleClick);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "MarkaID";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Marka Adı";
            this.columnHeader12.Width = 140;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(121, 46);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(226, 23);
            this.txtMarka.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 49);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "Marka ";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::wf_SporMarket.Properties.Resources.iptal_kucuk;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(256, 315);
            this.btnSil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 37);
            this.btnSil.TabIndex = 89;
            this.btnSil.Text = " Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Image = global::wf_SporMarket.Properties.Resources.update_kucuk;
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegistir.Location = new System.Drawing.Point(156, 315);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(91, 37);
            this.btnDegistir.TabIndex = 88;
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
            this.btnKaydet.Location = new System.Drawing.Point(56, 315);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnKaydet.TabIndex = 87;
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
            this.btnYeni.Location = new System.Drawing.Point(16, 266);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(91, 37);
            this.btnYeni.TabIndex = 86;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmMarkalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtMarkaNo);
            this.Controls.Add(this.lvMarkalar);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMarkalar";
            this.Text = "Marka Tanımlama";
            this.Load += new System.EventHandler(this.frmMarkalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarkaNo;
        private System.Windows.Forms.ListView lvMarkalar;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}