using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.Business.Concrete
{
    public class KullanıcıManager : IKullanıcıService
    {
        private IKullanıcıDal _kullanıcıDal;
        public KullanıcıManager(KullanıcıDal kullanıcıDal)

        {
            _kullanıcıDal = kullanıcıDal;
        }

     
        public void Add(Kullanıcı kullanıcı)
        {
             _kullanıcıDal.Add(kullanıcı);
        }

        public void Delete(Kullanıcı kullanıcı)
        {
            _kullanıcıDal.Delete(kullanıcı);
        }

        public List<Kullanıcı> GetAll()
        {
            return _kullanıcıDal.GetAll();
        }

        public void getOgrenciNo()
        {
            throw new NotImplementedException();
        }

        public bool LoginIsTrue(string text1, string text2,int Deger)
        {
            return _kullanıcıDal.LoginIsTrue(text1,text2,Deger);
        }

        public void Update(Kullanıcı kullanıcı)
        {
            _kullanıcıDal.Update(kullanıcı);
        }
    }
}
