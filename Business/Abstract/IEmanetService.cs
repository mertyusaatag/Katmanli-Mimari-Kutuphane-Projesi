using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.Business.Abstract
{
    public interface  IEmanetService
    {
        List<Emanet> GetAll();
        void Add(Emanet emanet);

        void Delete(Emanet emanet);

        void Update(Emanet emanet);
 
       
    }
}
