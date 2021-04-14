using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.FormUIs
{
    public partial class Form1 : Form
    {
        public static int deger;

        KutuphaneDbContext kutuphaneDb = new KutuphaneDbContext();
        private IOgrenciService _ogrenciService;
        
        
       
        public Form1()
        {
            InitializeComponent();

            _ogrenciService = new OgrenciManager(new OgrenciDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           

        }

       
        

        private void btnLogin_Click(object sender, EventArgs e)
        {

            deger = _ogrenciService.getId(tbxLoginName.Text,tbxLoginPassword.Text,deger);
            if (_ogrenciService.LoginIsTrue(tbxLoginName.Text, tbxLoginPassword.Text,deger))
            {
             
                MessageBox.Show("Giriş Başarılı"+deger);
                Form form = new Form3();
                form.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
           
        }
    }
}

