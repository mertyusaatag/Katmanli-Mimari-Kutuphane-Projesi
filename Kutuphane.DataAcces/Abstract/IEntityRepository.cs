using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Kutuphane.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T entity);
        void Add(T entity);


    }
}
