using Entities.Interfaces;
using Entities.POCOs;
using Entities.Specifications;
using Repository.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly RepositoryContext Context;
        public ProductRepository(RepositoryContext context) => Context = context;

        public void AddToCategoryFromProductNames(Category category, IEnumerable<string> productNames)
        {
            foreach (var item in productNames)
            {
                Context.Add(new Product() { Name = item, Category = category });
            }
        }

        public IEnumerable<Product> GetAll() 
            => Context.Products.ToList();

        public IEnumerable<Product> GetProductsBySpecification(Specification<Product> specification)
        {
            var expresionDelegate = specification.Expression.Compile();
            return Context.Products.Where(expresionDelegate).ToList();
        }

        public void SetDiscontinued(int id)
        {
            var Product = Context.Products.Find(id);
            if (Product != null)
            {
                Product.Discontinued = true;
            }
        }
    }
}
