using Entities.Interfaces;
using Entities.POCOs;
using Repository.EFCore.DataContext;
using System.Collections.Generic;
using System.Linq;

namespace Repository.EFCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RepositoryContext Context;
        public CategoryRepository(RepositoryContext context) =>
            Context = context;

        public void Add(Category category) =>
            Context.Add(category);

        public IEnumerable<Category> GetAll()
            => Context.Categories.ToList();
    }
}
