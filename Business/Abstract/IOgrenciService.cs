using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.Business.Abstract
{
    public interface IOgrenciService
    {
        List<Ogrenci> getAll();

        List<Ogrenci> GetName(Ogrenci ogrenci);

        void Add(Ogrenci ogrenci);
        void Delete(Ogrenci ogrenci);
        void Update(Ogrenci ogrenci);
        bool LoginIsTrue(string text1, string text2, int deger);
        
        int getId(string text1, string text2,int deger);
    }
}
