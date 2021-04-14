using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Kutuphane.DataAccess.Concrete
{
    public class EmanetDal : EntityRepositoryBase<Emanet, KutuphaneDbContext>, IEmanetDal
    {
        KutuphaneDbContext db = new KutuphaneDbContext();
       

        

      
    }
}
