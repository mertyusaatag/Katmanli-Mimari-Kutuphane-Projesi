using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.DataAccess.Concrete
{
    public class KitapDal : EntityRepositoryBase<Kitap, KutuphaneDbContext>, IKitapDal
    {

    }
}
