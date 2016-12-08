namespace wf_SporMarket
{
    partial class frmKullaniciİslemleri
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSifreDeisikligi = new System.Windows.Forms.TabPage();
            this.tpKullaniciTanimla = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.btnSifreDegis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoyad2 = new System.Windows.Forms.TextBox();
            this.lvKullanicilar = new System.Windows.Forms.ListView();
            this.cbKullaniciTurleri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtAdaGoreAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.rbYeniTur = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYeniTurAd = new System.Windows.Forms.TextBox();
            this.txtTurID = new System.Windows.Forms.TextBox();
            this.txtTurAd = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpSifreDeisikligi.SuspendLayout();
            this.tpKullaniciTanimla.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSifreDeisikligi);
            this.tabControl1.Controls.Add(this.tpKullaniciTanimla);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSifreDeisikligi
            // 
            this.tpSifreDeisikligi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpSifreDeisikligi.Controls.Add(this.label4);
            this.tpSifreDeisikligi.Controls.Add(this.txtYeniSifre);
            this.tpSifreDeisikligi.Controls.Add(this.btnSifreDegis);
            this.tpSifreDeisikligi.Controls.Add(this.label3);
            this.tpSifreDeisikligi.Controls.Add(this.txtEskiSifre);
            this.tpSifreDeisikligi.Controls.Add(this.label1);
            this.tpSifreDeisikligi.Controls.Add(this.txtAdı);
            this.tpSifreDeisikligi.Controls.Add(this.label2);
            this.tpSifreDeisikligi.Controls.Add(this.txtSoyadı);
            this.tpSifreDeisikligi.Location = new System.Drawing.Point(4, 25);
            this.tpSifreDeisikligi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSifreDeisikligi.Name = "tpSifreDeisikligi";
            this.tpSifreDeisikligi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSifreDeisikligi.Size = new System.Drawing.Size(570, 260);
            this.tpSifreDeisikligi.TabIndex = 0;
            this.tpSifreDeisikligi.Text = "Sifre Değişikliği";
            // 
            // tpKullaniciTanimla
            // 
            this.tpKullaniciTanimla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpKullaniciTanimla.Controls.Add(this.txtTurID);
            this.tpKullaniciTanimla.Controls.Add(this.txtTurAd);
            this.tpKullaniciTanimla.Controls.Add(this.txtYeniTurAd);
            this.tpKullaniciTanimla.Controls.Add(this.label12);
            this.tpKullaniciTanimla.Controls.Add(this.rbYeniTur);
            this.tpKullaniciTanimla.Controls.Add(this.btnSil);
            this.tpKullaniciTanimla.Controls.Add(this.btnDegistir);
            this.tpKullaniciTanimla.Controls.Add(this.btnKaydet);
            this.tpKullaniciTanimla.Controls.Add(this.btnYeni);
            this.tpKullaniciTanimla.Controls.Add(this.label9);
            this.tpKullaniciTanimla.Controls.Add(this.txtAdaGoreAra);
            this.tpKullaniciTanimla.Controls.Add(this.txtKullaniciID);
            this.tpKullaniciTanimla.Controls.Add(this.label6);
            this.tpKullaniciTanimla.Controls.Add(this.cbKullaniciTurleri);
            this.tpKullaniciTanimla.Controls.Add(this.lvKullanicilar);
            this.tpKullaniciTanimla.Controls.Add(this.label5);
            this.tpKullaniciTanimla.Controls.Add(this.txtSifre2);
            this.tpKullaniciTanimla.Controls.Add(this.label7);
            this.tpKullaniciTanimla.Controls.Add(this.txtAd2);
            this.tpKullaniciTanimla.Controls.Add(this.label8);
            this.tpKullaniciTanimla.Controls.Add(this.txtSoyad2);
            this.tpKullaniciTanimla.Location = new System.Drawing.Point(4, 25);
            this.tpKullaniciTanimla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpKullaniciTanimla.Name = "tpKullaniciTanimla";
            this.tpKullaniciTanimla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpKullaniciTanimla.Size = new System.Drawing.Size(570, 260);
            this.tpKullaniciTanimla.TabIndex = 1;
            this.tpKullaniciTanimla.Text = "Kullanıcı Tanımlama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad";
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(215, 33);
            this.txtAdı.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.ReadOnly = true;
            this.txtAdı.Size = new System.Drawing.Size(127, 23);
            this.txtAdı.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad";
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(215, 68);
            this.txtSoyadı.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.ReadOnly = true;
            this.txtSoyadı.Size = new System.Drawing.Size(127, 23);
            this.txtSoyadı.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eski Şifre";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(215, 103);
            this.txtEskiSifre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(127, 23);
            this.txtEskiSifre.TabIndex = 23;
            // 
            // btnSifreDegis
            // 
            this.btnSifreDegis.Location = new System.Drawing.Point(253, 170);
            this.btnSifreDegis.Name = "btnSifreDegis";
            this.btnSifreDegis.Size = new System.Drawing.Size(89, 47);
            this.btnSifreDegis.TabIndex = 24;
            this.btnSifreDegis.Text = "Şifreyi Değiştir";
            this.btnSifreDegis.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(215, 138);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(127, 23);
            this.txtYeniSifre.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kullanıcı Şifre";
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(140, 114);
            this.txtSifre2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(148, 23);
            this.txtSifre2.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kullanıcı Ad";
            // 
            // txtAd2
            // 
            this.txtAd2.Location = new System.Drawing.Point(140, 44);
            this.txtAd2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAd2.Name = "txtAd2";
            this.txtAd2.Size = new System.Drawing.Size(148, 23);
            this.txtAd2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kullanıcı Soyad";
            // 
            // txtSoyad2
            // 
            this.txtSoyad2.Location = new System.Drawing.Point(140, 79);
            this.txtSoyad2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyad2.Name = "txtSoyad2";
            this.txtSoyad2.Size = new System.Drawing.Size(148, 23);
            this.txtSoyad2.TabIndex = 30;
            // 
            // lvKullanicilar
            // 
            this.lvKullanicilar.Location = new System.Drawing.Point(296, 63);
            this.lvKullanicilar.Name = "lvKullanicilar";
            this.lvKullanicilar.Size = new System.Drawing.Size(268, 194);
            this.lvKullanicilar.TabIndex = 36;
            this.lvKullanicilar.UseCompatibleStateImageBehavior = false;
            // 
            // cbKullaniciTurleri
            // 
            this.cbKullaniciTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciTurleri.DropDownWidth = 100;
            this.cbKullaniciTurleri.FormattingEnabled = true;
            this.cbKullaniciTurleri.Location = new System.Drawing.Point(259, 146);
            this.cbKullaniciTurleri.Name = "cbKullaniciTurleri";
            this.cbKullaniciTurleri.Size = new System.Drawing.Size(27, 24);
            this.cbKullaniciTurleri.TabIndex = 37;
            this.cbKullaniciTurleri.SelectedIndexChanged += new System.EventHandler(this.cbKullaniciTipi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Kullanıcı Turu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(138, 15);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.ReadOnly = true;
            this.txtKullaniciID.Size = new System.Drawing.Size(20, 23);
            this.txtKullaniciID.TabIndex = 39;
            // 
            // txtAdaGoreAra
            // 
            this.txtAdaGoreAra.Location = new System.Drawing.Point(296, 41);
            this.txtAdaGoreAra.Name = "txtAdaGoreAra";
            this.txtAdaGoreAra.Size = new System.Drawing.Size(100, 23);
            this.txtAdaGoreAra.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Ada Göre Ara";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(222, 221);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 36);
            this.btnSil.TabIndex = 45;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(157, 221);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(64, 36);
            this.btnDegistir.TabIndex = 44;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(92, 221);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 36);
            this.btnKaydet.TabIndex = 43;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(27, 221);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(64, 36);
            this.btnYeni.TabIndex = 42;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // rbYeniTur
            // 
            this.rbYeniTur.AutoSize = true;
            this.rbYeniTur.Location = new System.Drawing.Point(150, 185);
            this.rbYeniTur.Name = "rbYeniTur";
            this.rbYeniTur.Size = new System.Drawing.Size(14, 13);
            this.rbYeniTur.TabIndex = 46;
            this.rbYeniTur.TabStop = true;
            this.rbYeniTur.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Yeni Tür Tanımla";
            // 
            // txtYeniTurAd
            // 
            this.txtYeniTurAd.Location = new System.Drawing.Point(177, 182);
            this.txtYeniTurAd.Name = "txtYeniTurAd";
            this.txtYeniTurAd.Size = new System.Drawing.Size(111, 23);
            this.txtYeniTurAd.TabIndex = 48;
            // 
            // txtTurID
            // 
            this.txtTurID.Location = new System.Drawing.Point(114, 147);
            this.txtTurID.Name = "txtTurID";
            this.txtTurID.ReadOnly = true;
            this.txtTurID.Size = new System.Drawing.Size(20, 23);
            this.txtTurID.TabIndex = 58;
            // 
            // txtTurAd
            // 
            this.txtTurAd.Location = new System.Drawing.Point(140, 146);
            this.txtTurAd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTurAd.Name = "txtTurAd";
            this.txtTurAd.Size = new System.Drawing.Size(119, 23);
            this.txtTurAd.TabIndex = 57;
            // 
            // frmKullaniciİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 289);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKullaniciİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.tabControl1.ResumeLayout(false);
            this.tpSifreDeisikligi.ResumeLayout(false);
            this.tpSifreDeisikligi.PerformLayout();
            this.tpKullaniciTanimla.ResumeLayout(false);
            this.tpKullaniciTanimla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSifreDeisikligi;
        private System.Windows.Forms.TabPage tpKullaniciTanimla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.Button btnSifreDegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKullaniciTurleri;
        private System.Windows.Forms.ListView lvKullanicilar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoyad2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdaGoreAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbYeniTur;
        private System.Windows.Forms.TextBox txtTurID;
        private System.Windows.Forms.TextBox txtTurAd;
        private System.Windows.Forms.TextBox txtYeniTurAd;
    }
}