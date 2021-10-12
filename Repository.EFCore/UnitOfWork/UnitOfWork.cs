using Entities.Interfaces;
using Repository.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext RepositoryContext;
        public UnitOfWork(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public int SaveChanges()
        {
            return RepositoryContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return RepositoryContext.SaveChangesAsync();
        }
    }
}
