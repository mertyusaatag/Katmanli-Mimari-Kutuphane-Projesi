using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Concrete;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.Business.Concrete
{
    public class EmanetManager : IEmanetService
    {
        private EmanetDal _emanetDal;

  
        public EmanetManager(EmanetDal emanetDal)
        {
            _emanetDal = emanetDal;
        }
        public void Add(Emanet emanet)
        {
             _emanetDal.Add(emanet);
        }

        public void Delete(Emanet emanet)
        {
            _emanetDal.Delete(emanet);
        }

        public List<Emanet> GetAll()
        {
            return _emanetDal.GetAll();
        }

        public void Update(Emanet emanet)
        {
            throw new NotImplementedException();
        }
    }
}
