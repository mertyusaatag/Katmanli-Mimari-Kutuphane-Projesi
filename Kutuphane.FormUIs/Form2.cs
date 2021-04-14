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

namespace Kutuphane.FormUIs
{
    public partial class Form2 : Form
    {
        public static int OgrenciId;
        KutuphaneDbContext kutuphaneDbContext = new KutuphaneDbContext();
        private IOgrenciService _ogrenciservice;
        private IKullanıcıService _kullanıcıService;

        public Form2()
        {
            InitializeComponent();
            _ogrenciservice = new OgrenciManager(new OgrenciDal());
            _kullanıcıService = new KullanıcıManager(new KullanıcıDal());
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _ogrenciservice.getAll();
            dataGridView2.DataSource = _kullanıcıService.GetAll();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                ogrenciSoyad=tbxAddOgrenciSoyad.Text,
                ogrenciEposta=tbxAddOgrenciEmail.Text,
                ogrenciTelefon=tbxAddOgrenciTel.Text,
                ogrenciNumarası=tbxAddOgrenciNum.Text,
               
               
                

            });
            _kullanıcıService.Add(new Kullanıcı
            {

                kullanıcıUserName = tbxAddOgrenciEmail.Text,
                kullanıcıPassword = tbxAddOgrenciNum.Text,
                k_ogrenciNo = Convert.ToInt32(tbxAddOgrenciNum.Text)


            }
            );
            dataGridView1.DataSource = _ogrenciservice.getAll();
            dataGridView2.DataSource = _kullanıcıService.GetAll();
        }
    }
}
