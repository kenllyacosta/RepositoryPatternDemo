using Entities.POCOs;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        void SetDiscontinued(int id);
        IEnumerable<Product> GetDiscontinuedProducts();
        void AddToCategoryFromProductNames(Category category, IEnumerable<string> productNames);
    }
}
