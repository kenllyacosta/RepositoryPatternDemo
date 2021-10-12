using Entities.Interfaces;
using Entities.POCOs;
using Repository.EFCore.DataContext;

namespace Repository.EFCore.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly RepositoryContext RepositoryContext;
        public CategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }
    }
}
