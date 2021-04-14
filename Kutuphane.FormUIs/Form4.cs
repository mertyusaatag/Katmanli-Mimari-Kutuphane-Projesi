using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane.FormUIs
{
    public partial class Form4 : Form
    {
        KutuphaneDbContext db = new KutuphaneDbContext();
        private IKitapService kitapService;
        public Form4()
        {
            InitializeComponent();
          
            kitapService = new KitapManager(new KitapDal());

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            LoadData();
            
        }

        private void LoadData()
        {
            dgwKitapListesi.DataSource = kitapService.GetAll();
        }

        private void btnAddKitap_Click(object sender, EventArgs e)
        {
            kitapService.Add(new Kitap
            {
                kitapAd = tbxAddKitapAdı.Text,
                kitapYazari = tbkAddKitapYazar.Text,
                kitapSayfaSayisi = Convert.ToInt32(tbxAddKitapSayfa.Text),
                kitapRaftami = Convert.ToBoolean(tbxUpdateKitapRaf.Text)
            });
            MessageBox.Show("Kitap Başarıyla Eklendi.");
            LoadData();
        }

        private void btnUpdateKitap_Click(object sender, EventArgs e)
        {
            kitapService.Update(new Kitap
            {
                Id = Convert.ToInt32(dgwKitapListesi.CurrentRow.Cells[0].Value),
                kitapAd = tbxUpdateKitapAD.Text,
                kitapYazari = tbxUpdateKitapYazar.Text,
                kitapSayfaSayisi = Convert.ToInt32(tbxUpdateKitapSayfa.Text),
                kitapRaftami = Convert.ToBoolean(tbxUpdateKitapRaf.Text)
                

            });
            
            MessageBox.Show("Kitap Başarıyla Güncellenmiştir.");
            LoadData();
        }

        private void dgwKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateKitapAD.Text = dgwKitapListesi.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateKitapYazar.Text = dgwKitapListesi.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateKitapSayfa.Text = Convert.ToString(dgwKitapListesi.CurrentRow.Cells[2].Value);
            tbxUpdateKitapRaf.Text = Convert.ToString(dgwKitapListesi.CurrentRow.Cells[4].Value);


            
        }

        private void btnDeleteKitap_Click(object sender, EventArgs e)
        {
            kitapService.Delete(new Kitap
            {
                Id = Convert.ToInt32(dgwKitapListesi.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Kitap Başarıyla Silinmiştir");
            LoadData();
        }
    }
}
