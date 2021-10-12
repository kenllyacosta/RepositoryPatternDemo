using System.Collections.Generic;
using System.Linq;

namespace Entities.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(object id);
        IEnumerable<T> GetAll();
        IQueryable<T> Query();
    }
}
