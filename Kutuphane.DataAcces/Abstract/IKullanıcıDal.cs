using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.DataAccess.Abstract
{
    public interface IKullanıcıDal : IEntityRepository<Kullanıcı>
    {
    
        bool LoginIsTrue(string text1, string text2,int Deger);
    }
}
