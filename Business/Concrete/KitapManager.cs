using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.Business.Concrete
{
    public class KitapManager : IKitapService
    {
        private IKitapDal _kitapDal;
        public KitapManager(IKitapDal kitap)
        {
            _kitapDal = kitap;
        }
        public void Add(Kitap kitap)
        {


            _kitapDal.Add(kitap);
            


        }

        public void Delete(Kitap kitap)
        {

            _kitapDal.Delete(kitap);

        }

        public List<Kitap> GetAll()
        {
            return _kitapDal.GetAll();
        }

        public void GetName()
        {

        }

        public void Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
        }
    }
}
