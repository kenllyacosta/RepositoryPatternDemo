using Entities.Interfaces;
using Entities.POCOs;
using Repository.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly RepositoryContext RepositoryContext;
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void AddToCategoryFromProductNames(Category category, IEnumerable<string> productNames)
        {
            foreach (var item in productNames)
            {
                Add(new Product() { Name = item, Category = category });
            }
        }

        public IEnumerable<Product> GetDiscontinuedProducts()
        {
            return Query().Where(x => x.Discontinued).ToList();
        }

        public void SetDiscontinued(int id)
        {
            var Product = GetById(id);
            if (Product != null)
            {
                Product.Discontinued = true;
            }
        }
    }
}
