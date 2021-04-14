
namespace Kutuphane.FormUIs
{
    partial class Form4
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
            this.dgwKitapListesi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateKitap = new System.Windows.Forms.Button();
            this.tbxUpdateKitapAD = new System.Windows.Forms.TextBox();
            this.tbxUpdateKitapSayfa = new System.Windows.Forms.TextBox();
            this.tbxUpdateKitapRaf = new System.Windows.Forms.TextBox();
            this.tbxUpdateKitapYazar = new System.Windows.Forms.TextBox();
            this.lblUpdateKitapRaf = new System.Windows.Forms.Label();
            this.lblUpdateKitapSayfa = new System.Windows.Forms.Label();
            this.lblUpdateKitapYazar = new System.Windows.Forms.Label();
            this.lblUpdateKitapAd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddKitap = new System.Windows.Forms.Button();
            this.tbxAddKitapRaf = new System.Windows.Forms.TextBox();
            this.tbxAddKitapSayfa = new System.Windows.Forms.TextBox();
            this.tbkAddKitapYazar = new System.Windows.Forms.TextBox();
            this.tbxAddKitapAdı = new System.Windows.Forms.TextBox();
            this.lblAddKitapRaf = new System.Windows.Forms.Label();
            this.lblAddKitapSayfası = new System.Windows.Forms.Label();
            this.lblAddKitapYazar = new System.Windows.Forms.Label();
            this.lblAddKitapAdı = new System.Windows.Forms.Label();
            this.btnDeleteKitap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKitapListesi
            // 
            this.dgwKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitapListesi.Location = new System.Drawing.Point(313, 12);
            this.dgwKitapListesi.Name = "dgwKitapListesi";
            this.dgwKitapListesi.RowTemplate.Height = 25;
            this.dgwKitapListesi.Size = new System.Drawing.Size(469, 186);
            this.dgwKitapListesi.TabIndex = 0;
            this.dgwKitapListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitapListesi_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateKitap);
            this.groupBox2.Controls.Add(this.tbxUpdateKitapAD);
            this.groupBox2.Controls.Add(this.tbxUpdateKitapSayfa);
            this.groupBox2.Controls.Add(this.tbxUpdateKitapRaf);
            this.groupBox2.Controls.Add(this.tbxUpdateKitapYazar);
            this.groupBox2.Controls.Add(this.lblUpdateKitapRaf);
            this.groupBox2.Controls.Add(this.lblUpdateKitapSayfa);
            this.groupBox2.Controls.Add(this.lblUpdateKitapYazar);
            this.groupBox2.Controls.Add(this.lblUpdateKitapAd);
            this.groupBox2.Location = new System.Drawing.Point(313, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Güncelleme İşlemleri";
            // 
            // btnUpdateKitap
            // 
            this.btnUpdateKitap.Location = new System.Drawing.Point(320, 34);
            this.btnUpdateKitap.Name = "btnUpdateKitap";
            this.btnUpdateKitap.Size = new System.Drawing.Size(75, 104);
            this.btnUpdateKitap.TabIndex = 5;
            this.btnUpdateKitap.Text = "Kitap Güncelle";
            this.btnUpdateKitap.UseVisualStyleBackColor = true;
            // 
            // tbxUpdateKitapAD
            // 
            this.tbxUpdateKitapAD.Location = new System.Drawing.Point(171, 34);
            this.tbxUpdateKitapAD.Name = "tbxUpdateKitapAD";
            this.tbxUpdateKitapAD.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateKitapAD.TabIndex = 12;
            // 
            // tbxUpdateKitapSayfa
            // 
            this.tbxUpdateKitapSayfa.Location = new System.Drawing.Point(171, 89);
            this.tbxUpdateKitapSayfa.Name = "tbxUpdateKitapSayfa";
            this.tbxUpdateKitapSayfa.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateKitapSayfa.TabIndex = 11;
            // 
            // tbxUpdateKitapRaf
            // 
            this.tbxUpdateKitapRaf.Location = new System.Drawing.Point(171, 115);
            this.tbxUpdateKitapRaf.Name = "tbxUpdateKitapRaf";
            this.tbxUpdateKitapRaf.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateKitapRaf.TabIndex = 10;
            // 
            // tbxUpdateKitapYazar
            // 
            this.tbxUpdateKitapYazar.Location = new System.Drawing.Point(171, 61);
            this.tbxUpdateKitapYazar.Name = "tbxUpdateKitapYazar";
            this.tbxUpdateKitapYazar.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdateKitapYazar.TabIndex = 9;
            // 
            // lblUpdateKitapRaf
            // 
            this.lblUpdateKitapRaf.AutoSize = true;
            this.lblUpdateKitapRaf.Location = new System.Drawing.Point(18, 118);
            this.lblUpdateKitapRaf.Name = "lblUpdateKitapRaf";
            this.lblUpdateKitapRaf.Size = new System.Drawing.Size(152, 15);
            this.lblUpdateKitapRaf.TabIndex = 8;
            this.lblUpdateKitapRaf.Text = "Kitap Raf Bilgisi (True/False)";
            // 
            // lblUpdateKitapSayfa
            // 
            this.lblUpdateKitapSayfa.AutoSize = true;
            this.lblUpdateKitapSayfa.Location = new System.Drawing.Point(18, 92);
            this.lblUpdateKitapSayfa.Name = "lblUpdateKitapSayfa";
            this.lblUpdateKitapSayfa.Size = new System.Drawing.Size(103, 15);
            this.lblUpdateKitapSayfa.TabIndex = 8;
            this.lblUpdateKitapSayfa.Text = "Kitap Sayfa Sayısı :";
            // 
            // lblUpdateKitapYazar
            // 
            this.lblUpdateKitapYazar.AutoSize = true;
            this.lblUpdateKitapYazar.Location = new System.Drawing.Point(18, 64);
            this.lblUpdateKitapYazar.Name = "lblUpdateKitapYazar";
            this.lblUpdateKitapYazar.Size = new System.Drawing.Size(73, 15);
            this.lblUpdateKitapYazar.TabIndex = 8;
            this.lblUpdateKitapYazar.Text = "Kitap Yazarı: ";
            // 
            // lblUpdateKitapAd
            // 
            this.lblUpdateKitapAd.AutoSize = true;
            this.lblUpdateKitapAd.Location = new System.Drawing.Point(18, 34);
            this.lblUpdateKitapAd.Name = "lblUpdateKitapAd";
            this.lblUpdateKitapAd.Size = new System.Drawing.Size(61, 15);
            this.lblUpdateKitapAd.TabIndex = 8;
            this.lblUpdateKitapAd.Text = "Kitap Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddKitap);
            this.groupBox1.Controls.Add(this.tbxAddKitapRaf);
            this.groupBox1.Controls.Add(this.tbxAddKitapSayfa);
            this.groupBox1.Controls.Add(this.tbkAddKitapYazar);
            this.groupBox1.Controls.Add(this.tbxAddKitapAdı);
            this.groupBox1.Controls.Add(this.lblAddKitapRaf);
            this.groupBox1.Controls.Add(this.lblAddKitapSayfası);
            this.groupBox1.Controls.Add(this.lblAddKitapYazar);
            this.groupBox1.Controls.Add(this.lblAddKitapAdı);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekleme İşlemleri";
            // 
            // btnAddKitap
            // 
            this.btnAddKitap.Location = new System.Drawing.Point(150, 157);
            this.btnAddKitap.Name = "btnAddKitap";
            this.btnAddKitap.Size = new System.Drawing.Size(100, 23);
            this.btnAddKitap.TabIndex = 4;
            this.btnAddKitap.Text = "Kitap Ekle";
            this.btnAddKitap.UseVisualStyleBackColor = true;
            this.btnAddKitap.Click += new System.EventHandler(this.btnAddKitap_Click);
            // 
            // tbxAddKitapRaf
            // 
            this.tbxAddKitapRaf.Location = new System.Drawing.Point(150, 114);
            this.tbxAddKitapRaf.Name = "tbxAddKitapRaf";
            this.tbxAddKitapRaf.Size = new System.Drawing.Size(100, 23);
            this.tbxAddKitapRaf.TabIndex = 7;
            // 
            // tbxAddKitapSayfa
            // 
            this.tbxAddKitapSayfa.Location = new System.Drawing.Point(150, 85);
            this.tbxAddKitapSayfa.Name = "tbxAddKitapSayfa";
            this.tbxAddKitapSayfa.Size = new System.Drawing.Size(100, 23);
            this.tbxAddKitapSayfa.TabIndex = 6;
            // 
            // tbkAddKitapYazar
            // 
            this.tbkAddKitapYazar.Location = new System.Drawing.Point(150, 56);
            this.tbkAddKitapYazar.Name = "tbkAddKitapYazar";
            this.tbkAddKitapYazar.Size = new System.Drawing.Size(100, 23);
            this.tbkAddKitapYazar.TabIndex = 5;
            // 
            // tbxAddKitapAdı
            // 
            this.tbxAddKitapAdı.Location = new System.Drawing.Point(150, 27);
            this.tbxAddKitapAdı.Name = "tbxAddKitapAdı";
            this.tbxAddKitapAdı.Size = new System.Drawing.Size(100, 23);
            this.tbxAddKitapAdı.TabIndex = 4;
            // 
            // lblAddKitapRaf
            // 
            this.lblAddKitapRaf.AutoSize = true;
            this.lblAddKitapRaf.Location = new System.Drawing.Point(0, 117);
            this.lblAddKitapRaf.Name = "lblAddKitapRaf";
            this.lblAddKitapRaf.Size = new System.Drawing.Size(152, 15);
            this.lblAddKitapRaf.TabIndex = 3;
            this.lblAddKitapRaf.Text = "Kitap Raf Bilgisi (True/False)";
            // 
            // lblAddKitapSayfası
            // 
            this.lblAddKitapSayfası.AutoSize = true;
            this.lblAddKitapSayfası.Location = new System.Drawing.Point(0, 88);
            this.lblAddKitapSayfası.Name = "lblAddKitapSayfası";
            this.lblAddKitapSayfası.Size = new System.Drawing.Size(103, 15);
            this.lblAddKitapSayfası.TabIndex = 2;
            this.lblAddKitapSayfası.Text = "Kitap Sayfa Sayısı :";
            // 
            // lblAddKitapYazar
            // 
            this.lblAddKitapYazar.AutoSize = true;
            this.lblAddKitapYazar.Location = new System.Drawing.Point(0, 59);
            this.lblAddKitapYazar.Name = "lblAddKitapYazar";
            this.lblAddKitapYazar.Size = new System.Drawing.Size(73, 15);
            this.lblAddKitapYazar.TabIndex = 1;
            this.lblAddKitapYazar.Text = "Kitap Yazarı: ";
            // 
            // lblAddKitapAdı
            // 
            this.lblAddKitapAdı.AutoSize = true;
            this.lblAddKitapAdı.Location = new System.Drawing.Point(0, 30);
            this.lblAddKitapAdı.Name = "lblAddKitapAdı";
            this.lblAddKitapAdı.Size = new System.Drawing.Size(61, 15);
            this.lblAddKitapAdı.TabIndex = 0;
            this.lblAddKitapAdı.Text = "Kitap Adı :";
            // 
            // btnDeleteKitap
            // 
            this.btnDeleteKitap.Location = new System.Drawing.Point(788, 12);
            this.btnDeleteKitap.Name = "btnDeleteKitap";
            this.btnDeleteKitap.Size = new System.Drawing.Size(75, 186);
            this.btnDeleteKitap.TabIndex = 8;
            this.btnDeleteKitap.Text = "Kitap Sil";
            this.btnDeleteKitap.UseVisualStyleBackColor = true;
            this.btnDeleteKitap.Click += new System.EventHandler(this.btnDeleteKitap_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 394);
            this.Controls.Add(this.btnDeleteKitap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwKitapListesi);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitapListesi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxAddKitapRaf;
        private System.Windows.Forms.TextBox tbxAddKitapSayfa;
        private System.Windows.Forms.TextBox tbkAddKitapYazar;
        private System.Windows.Forms.TextBox tbxAddKitapAdı;
        private System.Windows.Forms.Label lblAddKitapRaf;
        private System.Windows.Forms.Label lblAddKitapSayfası;
        private System.Windows.Forms.Label lblAddKitapYazar;
        private System.Windows.Forms.Label lblAddKitapAdı;
        private System.Windows.Forms.Button btnUpdateKitap;
        private System.Windows.Forms.TextBox tbxUpdateKitapAD;
        private System.Windows.Forms.TextBox tbxUpdateKitapSayfa;
        private System.Windows.Forms.TextBox tbxUpdateKitapRaf;
        private System.Windows.Forms.TextBox tbxUpdateKitapYazar;
        private System.Windows.Forms.Label lblUpdateKitapRaf;
        private System.Windows.Forms.Label lblUpdateKitapSayfa;
        private System.Windows.Forms.Label lblUpdateKitapYazar;
        private System.Windows.Forms.Label lblUpdateKitapAd;
        private System.Windows.Forms.Button btnAddKitap;
        private System.Windows.Forms.Button btnDeleteKitap;
    }
}