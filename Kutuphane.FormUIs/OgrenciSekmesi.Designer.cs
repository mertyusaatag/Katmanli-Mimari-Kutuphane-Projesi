
namespace Kutuphane.FormUIs
{
    partial class OgrenciSekmesi
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
            System.Windows.Forms.Label lblAddOgrenciSifre;
            System.Windows.Forms.Label lblUpdateOgrenciSifre;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxAddOgrenciPassword = new System.Windows.Forms.TextBox();
            this.btnAddOgrenci = new System.Windows.Forms.Button();
            this.tbxAddOgrenciNum = new System.Windows.Forms.TextBox();
            this.tbxAddOgrenciTel = new System.Windows.Forms.TextBox();
            this.tbxAddOgrenciEmail = new System.Windows.Forms.TextBox();
            this.tbxAddOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.tbxAddOgrenciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddOgrenciTelefon = new System.Windows.Forms.Label();
            this.lblAddOgrenciEposta = new System.Windows.Forms.Label();
            this.lblAddOgrenciSoyad = new System.Windows.Forms.Label();
            this.lblAddOgrenciAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateOgrenci = new System.Windows.Forms.Button();
            this.tbxUpdateOgrenciSifre = new System.Windows.Forms.TextBox();
            this.tbxUpdateOgrenciOkulNumarası = new System.Windows.Forms.TextBox();
            this.tbxUpdateOgrenciTel = new System.Windows.Forms.TextBox();
            this.tbxUpdateOgrenciEmail = new System.Windows.Forms.TextBox();
            this.tbxUpdateOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.tbxUpdateOgrenciAd = new System.Windows.Forms.TextBox();
            this.lblUpdateOgrenciOkulNumarası = new System.Windows.Forms.Label();
            this.lblUpdateOgrenciTel = new System.Windows.Forms.Label();
            this.lblUpdateOgrenciEmail = new System.Windows.Forms.Label();
            this.lblUpdateOgrSoyad = new System.Windows.Forms.Label();
            this.lblUpdateOgrenciAd = new System.Windows.Forms.Label();
            this.btnDeleteOgrenci = new System.Windows.Forms.Button();
            this.dgwOgrenci = new System.Windows.Forms.DataGridView();
            lblAddOgrenciSifre = new System.Windows.Forms.Label();
            lblUpdateOgrenciSifre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddOgrenciSifre
            // 
            lblAddOgrenciSifre.AutoSize = true;
            lblAddOgrenciSifre.Location = new System.Drawing.Point(26, 183);
            lblAddOgrenciSifre.Name = "lblAddOgrenciSifre";
            lblAddOgrenciSifre.Size = new System.Drawing.Size(78, 15);
            lblAddOgrenciSifre.TabIndex = 11;
            lblAddOgrenciSifre.Text = "Kullanıcı Şifre";
            // 
            // lblUpdateOgrenciSifre
            // 
            lblUpdateOgrenciSifre.AutoSize = true;
            lblUpdateOgrenciSifre.Location = new System.Drawing.Point(253, 91);
            lblUpdateOgrenciSifre.Name = "lblUpdateOgrenciSifre";
            lblUpdateOgrenciSifre.Size = new System.Drawing.Size(78, 15);
            lblUpdateOgrenciSifre.TabIndex = 13;
            lblUpdateOgrenciSifre.Text = "Kullanıcı Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAddOgrenciPassword);
            this.groupBox1.Controls.Add(lblAddOgrenciSifre);
            this.groupBox1.Controls.Add(this.btnAddOgrenci);
            this.groupBox1.Controls.Add(this.tbxAddOgrenciNum);
            this.groupBox1.Controls.Add(this.tbxAddOgrenciTel);
            this.groupBox1.Controls.Add(this.tbxAddOgrenciEmail);
            this.groupBox1.Controls.Add(this.tbxAddOgrenciSoyad);
            this.groupBox1.Controls.Add(this.tbxAddOgrenciAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAddOgrenciTelefon);
            this.groupBox1.Controls.Add(this.lblAddOgrenciEposta);
            this.groupBox1.Controls.Add(this.lblAddOgrenciSoyad);
            this.groupBox1.Controls.Add(this.lblAddOgrenciAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekleme Kısmı";
            // 
            // tbxAddOgrenciPassword
            // 
            this.tbxAddOgrenciPassword.Location = new System.Drawing.Point(227, 180);
            this.tbxAddOgrenciPassword.Name = "tbxAddOgrenciPassword";
            this.tbxAddOgrenciPassword.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciPassword.TabIndex = 12;
            // 
            // btnAddOgrenci
            // 
            this.btnAddOgrenci.Location = new System.Drawing.Point(76, 236);
            this.btnAddOgrenci.Name = "btnAddOgrenci";
            this.btnAddOgrenci.Size = new System.Drawing.Size(186, 46);
            this.btnAddOgrenci.TabIndex = 10;
            this.btnAddOgrenci.Text = "Kayıt Et";
            this.btnAddOgrenci.UseVisualStyleBackColor = true;
            this.btnAddOgrenci.Click += new System.EventHandler(this.btnAddOgrenci_Click);
            // 
            // tbxAddOgrenciNum
            // 
            this.tbxAddOgrenciNum.Location = new System.Drawing.Point(227, 142);
            this.tbxAddOgrenciNum.Name = "tbxAddOgrenciNum";
            this.tbxAddOgrenciNum.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciNum.TabIndex = 9;
            // 
            // tbxAddOgrenciTel
            // 
            this.tbxAddOgrenciTel.Location = new System.Drawing.Point(227, 106);
            this.tbxAddOgrenciTel.Name = "tbxAddOgrenciTel";
            this.tbxAddOgrenciTel.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciTel.TabIndex = 8;
            // 
            // tbxAddOgrenciEmail
            // 
            this.tbxAddOgrenciEmail.Location = new System.Drawing.Point(227, 77);
            this.tbxAddOgrenciEmail.Name = "tbxAddOgrenciEmail";
            this.tbxAddOgrenciEmail.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciEmail.TabIndex = 7;
            // 
            // tbxAddOgrenciSoyad
            // 
            this.tbxAddOgrenciSoyad.Location = new System.Drawing.Point(227, 48);
            this.tbxAddOgrenciSoyad.Name = "tbxAddOgrenciSoyad";
            this.tbxAddOgrenciSoyad.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciSoyad.TabIndex = 6;
            // 
            // tbxAddOgrenciAd
            // 
            this.tbxAddOgrenciAd.Location = new System.Drawing.Point(227, 19);
            this.tbxAddOgrenciAd.Name = "tbxAddOgrenciAd";
            this.tbxAddOgrenciAd.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Okul Numarası";
            // 
            // lblAddOgrenciTelefon
            // 
            this.lblAddOgrenciTelefon.AutoSize = true;
            this.lblAddOgrenciTelefon.Location = new System.Drawing.Point(26, 114);
            this.lblAddOgrenciTelefon.Name = "lblAddOgrenciTelefon";
            this.lblAddOgrenciTelefon.Size = new System.Drawing.Size(144, 15);
            this.lblAddOgrenciTelefon.TabIndex = 3;
            this.lblAddOgrenciTelefon.Text = "Öğrenci Telefon Numarası";
            // 
            // lblAddOgrenciEposta
            // 
            this.lblAddOgrenciEposta.AutoSize = true;
            this.lblAddOgrenciEposta.Location = new System.Drawing.Point(26, 80);
            this.lblAddOgrenciEposta.Name = "lblAddOgrenciEposta";
            this.lblAddOgrenciEposta.Size = new System.Drawing.Size(81, 15);
            this.lblAddOgrenciEposta.TabIndex = 2;
            this.lblAddOgrenciEposta.Text = "Öğrenci Email";
            this.lblAddOgrenciEposta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAddOgrenciSoyad
            // 
            this.lblAddOgrenciSoyad.AutoSize = true;
            this.lblAddOgrenciSoyad.Location = new System.Drawing.Point(26, 51);
            this.lblAddOgrenciSoyad.Name = "lblAddOgrenciSoyad";
            this.lblAddOgrenciSoyad.Size = new System.Drawing.Size(87, 15);
            this.lblAddOgrenciSoyad.TabIndex = 1;
            this.lblAddOgrenciSoyad.Text = "Öğrenci Soyadı";
            // 
            // lblAddOgrenciAd
            // 
            this.lblAddOgrenciAd.AutoSize = true;
            this.lblAddOgrenciAd.Location = new System.Drawing.Point(26, 19);
            this.lblAddOgrenciAd.Name = "lblAddOgrenciAd";
            this.lblAddOgrenciAd.Size = new System.Drawing.Size(73, 15);
            this.lblAddOgrenciAd.TabIndex = 0;
            this.lblAddOgrenciAd.Text = "Öğrenci Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateOgrenci);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciSifre);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciOkulNumarası);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciTel);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciEmail);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciSoyad);
            this.groupBox2.Controls.Add(this.tbxUpdateOgrenciAd);
            this.groupBox2.Controls.Add(lblUpdateOgrenciSifre);
            this.groupBox2.Controls.Add(this.lblUpdateOgrenciOkulNumarası);
            this.groupBox2.Controls.Add(this.lblUpdateOgrenciTel);
            this.groupBox2.Controls.Add(this.lblUpdateOgrenciEmail);
            this.groupBox2.Controls.Add(this.lblUpdateOgrSoyad);
            this.groupBox2.Controls.Add(this.lblUpdateOgrenciAd);
            this.groupBox2.Location = new System.Drawing.Point(523, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Güncelleme Kısmı";
            // 
            // btnUpdateOgrenci
            // 
            this.btnUpdateOgrenci.Location = new System.Drawing.Point(249, 148);
            this.btnUpdateOgrenci.Name = "btnUpdateOgrenci";
            this.btnUpdateOgrenci.Size = new System.Drawing.Size(254, 23);
            this.btnUpdateOgrenci.TabIndex = 3;
            this.btnUpdateOgrenci.Text = "Güncelle";
            this.btnUpdateOgrenci.UseVisualStyleBackColor = true;
            this.btnUpdateOgrenci.Click += new System.EventHandler(this.btnUpdateOgrenci_Click);
            // 
            // tbxUpdateOgrenciSifre
            // 
            this.tbxUpdateOgrenciSifre.Location = new System.Drawing.Point(403, 88);
            this.tbxUpdateOgrenciSifre.Name = "tbxUpdateOgrenciSifre";
            this.tbxUpdateOgrenciSifre.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciSifre.TabIndex = 18;
            // 
            // tbxUpdateOgrenciOkulNumarası
            // 
            this.tbxUpdateOgrenciOkulNumarası.Location = new System.Drawing.Point(403, 59);
            this.tbxUpdateOgrenciOkulNumarası.Name = "tbxUpdateOgrenciOkulNumarası";
            this.tbxUpdateOgrenciOkulNumarası.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciOkulNumarası.TabIndex = 17;
            // 
            // tbxUpdateOgrenciTel
            // 
            this.tbxUpdateOgrenciTel.Location = new System.Drawing.Point(403, 30);
            this.tbxUpdateOgrenciTel.Name = "tbxUpdateOgrenciTel";
            this.tbxUpdateOgrenciTel.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciTel.TabIndex = 16;
            // 
            // tbxUpdateOgrenciEmail
            // 
            this.tbxUpdateOgrenciEmail.Location = new System.Drawing.Point(147, 89);
            this.tbxUpdateOgrenciEmail.Name = "tbxUpdateOgrenciEmail";
            this.tbxUpdateOgrenciEmail.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciEmail.TabIndex = 15;
            // 
            // tbxUpdateOgrenciSoyad
            // 
            this.tbxUpdateOgrenciSoyad.Location = new System.Drawing.Point(147, 56);
            this.tbxUpdateOgrenciSoyad.Name = "tbxUpdateOgrenciSoyad";
            this.tbxUpdateOgrenciSoyad.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciSoyad.TabIndex = 14;
            // 
            // tbxUpdateOgrenciAd
            // 
            this.tbxUpdateOgrenciAd.Location = new System.Drawing.Point(147, 28);
            this.tbxUpdateOgrenciAd.Name = "tbxUpdateOgrenciAd";
            this.tbxUpdateOgrenciAd.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateOgrenciAd.TabIndex = 13;
            // 
            // lblUpdateOgrenciOkulNumarası
            // 
            this.lblUpdateOgrenciOkulNumarası.AutoSize = true;
            this.lblUpdateOgrenciOkulNumarası.Location = new System.Drawing.Point(253, 59);
            this.lblUpdateOgrenciOkulNumarası.Name = "lblUpdateOgrenciOkulNumarası";
            this.lblUpdateOgrenciOkulNumarası.Size = new System.Drawing.Size(131, 15);
            this.lblUpdateOgrenciOkulNumarası.TabIndex = 13;
            this.lblUpdateOgrenciOkulNumarası.Text = "Öğrenci Okul Numarası";
            // 
            // lblUpdateOgrenciTel
            // 
            this.lblUpdateOgrenciTel.AutoSize = true;
            this.lblUpdateOgrenciTel.Location = new System.Drawing.Point(253, 33);
            this.lblUpdateOgrenciTel.Name = "lblUpdateOgrenciTel";
            this.lblUpdateOgrenciTel.Size = new System.Drawing.Size(144, 15);
            this.lblUpdateOgrenciTel.TabIndex = 13;
            this.lblUpdateOgrenciTel.Text = "Öğrenci Telefon Numarası";
            // 
            // lblUpdateOgrenciEmail
            // 
            this.lblUpdateOgrenciEmail.AutoSize = true;
            this.lblUpdateOgrenciEmail.Location = new System.Drawing.Point(18, 97);
            this.lblUpdateOgrenciEmail.Name = "lblUpdateOgrenciEmail";
            this.lblUpdateOgrenciEmail.Size = new System.Drawing.Size(81, 15);
            this.lblUpdateOgrenciEmail.TabIndex = 13;
            this.lblUpdateOgrenciEmail.Text = "Öğrenci Email";
            // 
            // lblUpdateOgrSoyad
            // 
            this.lblUpdateOgrSoyad.AutoSize = true;
            this.lblUpdateOgrSoyad.Location = new System.Drawing.Point(18, 61);
            this.lblUpdateOgrSoyad.Name = "lblUpdateOgrSoyad";
            this.lblUpdateOgrSoyad.Size = new System.Drawing.Size(87, 15);
            this.lblUpdateOgrSoyad.TabIndex = 13;
            this.lblUpdateOgrSoyad.Text = "Öğrenci Soyadı";
            // 
            // lblUpdateOgrenciAd
            // 
            this.lblUpdateOgrenciAd.AutoSize = true;
            this.lblUpdateOgrenciAd.Location = new System.Drawing.Point(18, 30);
            this.lblUpdateOgrenciAd.Name = "lblUpdateOgrenciAd";
            this.lblUpdateOgrenciAd.Size = new System.Drawing.Size(73, 15);
            this.lblUpdateOgrenciAd.TabIndex = 13;
            this.lblUpdateOgrenciAd.Text = "Öğrenci Adı:";
            // 
            // btnDeleteOgrenci
            // 
            this.btnDeleteOgrenci.Location = new System.Drawing.Point(1038, 12);
            this.btnDeleteOgrenci.Name = "btnDeleteOgrenci";
            this.btnDeleteOgrenci.Size = new System.Drawing.Size(61, 222);
            this.btnDeleteOgrenci.TabIndex = 3;
            this.btnDeleteOgrenci.Text = "Sil";
            this.btnDeleteOgrenci.UseVisualStyleBackColor = true;
            this.btnDeleteOgrenci.Click += new System.EventHandler(this.btnDeleteOgrenci_Click);
            // 
            // dgwOgrenci
            // 
            this.dgwOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenci.Location = new System.Drawing.Point(498, 12);
            this.dgwOgrenci.Name = "dgwOgrenci";
            this.dgwOgrenci.Size = new System.Drawing.Size(534, 222);
            this.dgwOgrenci.TabIndex = 4;
            this.dgwOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenci_CellClick_1);
            // 
            // OgrenciSekmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 464);
            this.Controls.Add(this.dgwOgrenci);
            this.Controls.Add(this.btnDeleteOgrenci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciSekmesi";
            this.Text = "Öğrenci Sekmesi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddOgrenciEposta;
        private System.Windows.Forms.Label lblAddOgrenciSoyadAd;
        private System.Windows.Forms.Label lblAddOgrenciAd;
        private System.Windows.Forms.Label lblAddOgrenciTelefon;
        private System.Windows.Forms.Label lblAddOgrenciSoyad;
        private System.Windows.Forms.Button btnAddOgrenci;
        private System.Windows.Forms.TextBox tbxAddOgrenciNum;
        private System.Windows.Forms.TextBox tbxAddOgrenciTel;
        private System.Windows.Forms.TextBox tbxAddOgrenciEmail;
        private System.Windows.Forms.TextBox tbxAddOgrenciSoyad;
        private System.Windows.Forms.TextBox tbxAddOgrenciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddOgrenciPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateOgrenci;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciSifre;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciOkulNumarası;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciTel;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciEmail;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciSoyad;
        private System.Windows.Forms.TextBox tbxUpdateOgrenciAd;
        private System.Windows.Forms.Label lblUpdateOgrenciOkulNumarası;
        private System.Windows.Forms.Label lblUpdateOgrenciTel;
        private System.Windows.Forms.Label lblUpdateOgrenciEmail;
        private System.Windows.Forms.Label lblUpdateOgrSoyad;
        private System.Windows.Forms.Label lblUpdateOgrenciAd;
        private System.Windows.Forms.Button btnDeleteOgrenci;
        private System.Windows.Forms.Label lblUpdateOgrenciSoyad;
        private System.Windows.Forms.DataGridView dgwOgrenci;
    }
}