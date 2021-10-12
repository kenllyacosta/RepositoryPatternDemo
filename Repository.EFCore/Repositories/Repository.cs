using Entities.Interfaces;
using Repository.EFCore.DataContext;
using System.Collections.Generic;
using System.Linq;

namespace Repository.EFCore.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RepositoryContext RepositoryContext;
        public Repository(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;

        public void Add(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return RepositoryContext.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return RepositoryContext.Set<T>().Find(id);
        }

        public IQueryable<T> Query()
        {
            return RepositoryContext.Set<T>().AsQueryable();
        }

        public void Remove(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
