using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Kutuphane.FormUIs
{
    public partial class OgrenciSekmesi : Form
    {
        public static int OgrenciId;
        KutuphaneDbContext kutuphaneDbContext = new KutuphaneDbContext();
        private IOgrenciService _ogrenciservice;
        public OgrenciSekmesi()
        {
             InitializeComponent();
            _ogrenciservice = new OgrenciManager(new OgrenciDal());
            LoadData();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        
        } 


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOgrenci_Click(object sender, EventArgs e)
        {
            _ogrenciservice.Add(new Ogrenci
            {
                ogrenciAd = tbxAddOgrenciAd.Text,
                ogrenciSoyad = tbxAddOgrenciSoyad.Text,
                ogrenciEposta = tbxAddOgrenciEmail.Text,
                ogrenciTelefon = tbxAddOgrenciTel.Text,
                ogrenciNumarası = tbxAddOgrenciNum.Text,
                ogrenciSifre = tbxAddOgrenciPassword.Text
            }) ;
            MessageBox.Show("Öğrenci Eklenmiştir");
            LoadData();
        }

        private void dgwOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateOgrenciAd.Text = dgwOgrenci.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateOgrenciSoyad.Text =dgwOgrenci.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateOgrenciEmail.Text = dgwOgrenci.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateOgrenciTel.Text = dgwOgrenci.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateOgrenciOkulNumarası.Text = dgwOgrenci.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateOgrenciSifre.Text = dgwOgrenci.CurrentRow.Cells[6].Value.ToString();
        }
        private void LoadData()
        {
            dgwOgrenci.DataSource = _ogrenciservice.getAll();
        }

        private void btnUpdateOgrenci_Click(object sender, EventArgs e)
        {
            _ogrenciservice.Update(new Ogrenci
            {
                Id = Convert.ToInt32(dgwOgrenci.CurrentRow.Cells[0].Value),
                ogrenciAd = tbxUpdateOgrenciAd.Text,
                ogrenciSoyad = tbxUpdateOgrenciSoyad.Text,
                ogrenciEposta = tbxUpdateOgrenciEmail.Text,
                ogrenciTelefon = tbxUpdateOgrenciTel.Text,
                ogrenciNumarası = tbxUpdateOgrenciOkulNumarası.Text,
                ogrenciSifre = tbxUpdateOgrenciSifre.Text
            }) ;
            MessageBox.Show("Öğrenci Güncellenmiştir");
            LoadData();
        }

        private void btnDeleteOgrenci_Click(object sender, EventArgs e)
        {
            _ogrenciservice.Delete(new Ogrenci { Id = Convert.ToInt32(dgwOgrenci.CurrentRow.Cells[0].Value) });
            MessageBox.Show("Oğrenci Silinmiştir");
            LoadData();
        }
    }
}
