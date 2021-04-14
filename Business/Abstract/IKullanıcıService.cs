using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.Business.Abstract
{
    public interface IKullanıcıService
    {
        List<Kullanıcı> GetAll();
        void Add(Kullanıcı kullanıcı);
        void Delete(Kullanıcı kullanıcı);
        void Update(Kullanıcı kullanıcı);
        bool LoginIsTrue(string text1, string text2,int Deger);
        void getOgrenciNo();
     
    }
}
