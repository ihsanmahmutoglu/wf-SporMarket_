namespace wf_SporMarket
{
    partial class frmKullanicisifredegistirme
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.btnSifreDegis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(91, 143);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(127, 23);
            this.txtYeniSifre.TabIndex = 35;
            // 
            // btnSifreDegis
            // 
            this.btnSifreDegis.Location = new System.Drawing.Point(91, 175);
            this.btnSifreDegis.Name = "btnSifreDegis";
            this.btnSifreDegis.Size = new System.Drawing.Size(127, 47);
            this.btnSifreDegis.TabIndex = 33;
            this.btnSifreDegis.Text = "Şifreyi Değiştir";
            this.btnSifreDegis.UseVisualStyleBackColor = true;
            this.btnSifreDegis.Click += new System.EventHandler(this.btnSifreDegis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Eski Şifre";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(91, 108);
            this.txtEskiSifre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.PasswordChar = '*';
            this.txtEskiSifre.Size = new System.Drawing.Size(127, 23);
            this.txtEskiSifre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad";
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(91, 38);
            this.txtAdı.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.ReadOnly = true;
            this.txtAdı.Size = new System.Drawing.Size(127, 23);
            this.txtAdı.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad";
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(91, 73);
            this.txtSoyadı.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.ReadOnly = true;
            this.txtSoyadı.Size = new System.Drawing.Size(127, 23);
            this.txtSoyadı.TabIndex = 30;
            // 
            // frmKullanicisifredegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(234, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.btnSifreDegis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullanicisifredegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.frmKullaniciİslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button btnSifreDegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadı;
    }
}