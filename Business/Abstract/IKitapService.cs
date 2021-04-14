using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.Business.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetAll();
        void Add(Kitap kitap);
        void Delete(Kitap kitap);
        void Update(Kitap kitap);


    }
}
