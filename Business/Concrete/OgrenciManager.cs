using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        private IOgrenciDal _OgrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _OgrenciDal = ogrenciDal;
        }
        public void Add(Ogrenci ogrenci)
        {
            _OgrenciDal.Add(ogrenci);
        }

        public void Delete(Ogrenci ogrenci)
        {
            _OgrenciDal.Delete(ogrenci);
        }

        public List<Ogrenci> GetAll()
        {
            return _OgrenciDal.GetAll();
        }

        public List<Ogrenci> getAll()
        {
           return _OgrenciDal.GetAll();
        }

        public int getId(string text1, string text2,int deger)
        {
            return _OgrenciDal.getId(text1, text2,deger);
        }

        public List<Ogrenci> GetName(Ogrenci ogrenci)
        {
            using (KutuphaneDbContext kutuhaneDb = new KutuphaneDbContext())
            {
                return kutuhaneDb.Ogrenci.Where(p => ogrenci.ogrenciAd == p.ogrenciAd).ToList();
            }

        }

        public bool LoginIsTrue(string text1, string text2, int deger)
        {
            return _OgrenciDal.LoginIsTrue(text1,text2,deger);
        }

        public void Update(Ogrenci ogrenci)
        {
            _OgrenciDal.Update(ogrenci);
        }

    }
}
