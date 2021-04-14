
namespace Kutuphane.FormUIs
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(466, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(509, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAddOgrenci
            // 
            this.btnAddOgrenci.Location = new System.Drawing.Point(86, 220);
            this.btnAddOgrenci.Name = "btnAddOgrenci";
            this.btnAddOgrenci.Size = new System.Drawing.Size(186, 46);
            this.btnAddOgrenci.TabIndex = 10;
            this.btnAddOgrenci.Text = "Kayıt Et";
            this.btnAddOgrenci.UseVisualStyleBackColor = true;
            this.btnAddOgrenci.Click += new System.EventHandler(this.btnAddOgrenci_Click);
            // 
            // tbxAddOgrenciNum
            // 
            this.tbxAddOgrenciNum.Location = new System.Drawing.Point(218, 191);
            this.tbxAddOgrenciNum.Name = "tbxAddOgrenciNum";
            this.tbxAddOgrenciNum.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciNum.TabIndex = 9;
            // 
            // tbxAddOgrenciTel
            // 
            this.tbxAddOgrenciTel.Location = new System.Drawing.Point(218, 148);
            this.tbxAddOgrenciTel.Name = "tbxAddOgrenciTel";
            this.tbxAddOgrenciTel.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciTel.TabIndex = 8;
            // 
            // tbxAddOgrenciEmail
            // 
            this.tbxAddOgrenciEmail.Location = new System.Drawing.Point(218, 110);
            this.tbxAddOgrenciEmail.Name = "tbxAddOgrenciEmail";
            this.tbxAddOgrenciEmail.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciEmail.TabIndex = 7;
            // 
            // tbxAddOgrenciSoyad
            // 
            this.tbxAddOgrenciSoyad.Location = new System.Drawing.Point(218, 68);
            this.tbxAddOgrenciSoyad.Name = "tbxAddOgrenciSoyad";
            this.tbxAddOgrenciSoyad.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciSoyad.TabIndex = 6;
            // 
            // tbxAddOgrenciAd
            // 
            this.tbxAddOgrenciAd.Location = new System.Drawing.Point(218, 32);
            this.tbxAddOgrenciAd.Name = "tbxAddOgrenciAd";
            this.tbxAddOgrenciAd.Size = new System.Drawing.Size(100, 23);
            this.tbxAddOgrenciAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Okul Numarası";
            // 
            // lblAddOgrenciTelefon
            // 
            this.lblAddOgrenciTelefon.AutoSize = true;
            this.lblAddOgrenciTelefon.Location = new System.Drawing.Point(26, 148);
            this.lblAddOgrenciTelefon.Name = "lblAddOgrenciTelefon";
            this.lblAddOgrenciTelefon.Size = new System.Drawing.Size(144, 15);
            this.lblAddOgrenciTelefon.TabIndex = 3;
            this.lblAddOgrenciTelefon.Text = "Öğrenci Telefon Numarası";
            // 
            // lblAddOgrenciEposta
            // 
            this.lblAddOgrenciEposta.AutoSize = true;
            this.lblAddOgrenciEposta.Location = new System.Drawing.Point(26, 110);
            this.lblAddOgrenciEposta.Name = "lblAddOgrenciEposta";
            this.lblAddOgrenciEposta.Size = new System.Drawing.Size(81, 15);
            this.lblAddOgrenciEposta.TabIndex = 2;
            this.lblAddOgrenciEposta.Text = "Öğrenci Email";
            this.lblAddOgrenciEposta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAddOgrenciSoyad
            // 
            this.lblAddOgrenciSoyad.AutoSize = true;
            this.lblAddOgrenciSoyad.Location = new System.Drawing.Point(26, 68);
            this.lblAddOgrenciSoyad.Name = "lblAddOgrenciSoyad";
            this.lblAddOgrenciSoyad.Size = new System.Drawing.Size(87, 15);
            this.lblAddOgrenciSoyad.TabIndex = 1;
            this.lblAddOgrenciSoyad.Text = "Öğrenci Soyadı";
            // 
            // lblAddOgrenciAd
            // 
            this.lblAddOgrenciAd.AutoSize = true;
            this.lblAddOgrenciAd.Location = new System.Drawing.Point(26, 41);
            this.lblAddOgrenciAd.Name = "lblAddOgrenciAd";
            this.lblAddOgrenciAd.Size = new System.Drawing.Size(73, 15);
            this.lblAddOgrenciAd.TabIndex = 0;
            this.lblAddOgrenciAd.Text = "Öğrenci Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(467, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 290);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(405, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddOgrenciEposta;
        private System.Windows.Forms.Label lblAddOgrenciSoyadAd;
        private System.Windows.Forms.Label lblAddOgrenciAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddOgrenciTelefon;
        private System.Windows.Forms.Label lblAddOgrenciSoyad;
        private System.Windows.Forms.Button btnAddOgrenci;
        private System.Windows.Forms.TextBox tbxAddOgrenciNum;
        private System.Windows.Forms.TextBox tbxAddOgrenciTel;
        private System.Windows.Forms.TextBox tbxAddOgrenciEmail;
        private System.Windows.Forms.TextBox tbxAddOgrenciSoyad;
        private System.Windows.Forms.TextBox tbxAddOgrenciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}