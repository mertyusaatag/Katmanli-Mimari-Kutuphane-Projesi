using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.DataAccess.Concrete
{
    public class OgrenciDal : EntityRepositoryBase<Ogrenci, KutuphaneDbContext>, IOgrenciDal
    {
         KutuphaneDbContext context = new KutuphaneDbContext();
         Ogrenci ogrenci = new Ogrenci();

        public int getId(string text1, string text2,int deger)
        {
            var query = from item in context.Ogrenci
                        where item.ogrenciEposta == text1 && item.ogrenciSifre == text2
                        select item.Id;

            foreach (var item in query)
            {
                deger = item;
            }
            return deger;
        }

        public bool LoginIsTrue(string text1, string text2, int deger)
        {
            var query = from item in context.Ogrenci
                        where item.ogrenciEposta == text1 && item.ogrenciSifre == text2
                        select item;
            foreach (var item in query)
            {
                deger = item.Id;
            };

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
