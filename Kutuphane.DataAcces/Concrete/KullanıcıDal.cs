using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.DataAccess.Concrete
{
    public class KullanıcıDal : EntityRepositoryBase<Kullanıcı, KutuphaneDbContext>, IKullanıcıDal
    {
        
        public bool LoginIsTrue(string text1, string text2,int Deger)
        {
            KutuphaneDbContext dbContext = new KutuphaneDbContext();
            var query = from item in dbContext.kullanıcıs
                        where item.kullanıcıUserName == text1 && item.kullanıcıPassword == text2 
                        select item;
            foreach (var item in query)
            {
                Deger = item.k_ogrenciNo;
            }

            if(query.Any())
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
