using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Kutuphane.FormUIs
{
    public partial class Form3 : Form
    {
        KutuphaneDbContext db = new KutuphaneDbContext();
        private IOgrenciService _ogrenciService;
        private IEmanetService _emanetService;
        public Form3()
        {
            InitializeComponent();
            _ogrenciService = new OgrenciManager(new OgrenciDal());
            _emanetService = new EmanetManager(new EmanetDal());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var query = from item in db.Ogrenci
                        where item.Id == Form1.deger
                        select item;
            foreach (var item in query)
            {
                lblAd.Text = item.ogrenciAd;
                lblSoyad.Text = item.ogrenciSoyad;
                lblemail.Text = item.ogrenciEposta;
                lblsifre.Text = item.ogrenciNumarası;
            }
            int a = 0;

       


        }

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }
    }
}
