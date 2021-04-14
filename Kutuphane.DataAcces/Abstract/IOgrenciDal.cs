using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.DataAccess.Abstract
{
    public interface IOgrenciDal : IEntityRepository<Ogrenci>
    {
        bool LoginIsTrue(string text1, string text2, int deger);
        
        int getId(string text1, string text2,int deger);
    }
}
