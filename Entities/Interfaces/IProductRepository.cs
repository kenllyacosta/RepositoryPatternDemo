using Entities.POCOs;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface IProductRepository
    {
        void SetDiscontinued(int id);
        IEnumerable<Product> GetProductsBySpecification(Specifications.Specification<Product> specification);
        void AddToCategoryFromProductNames(Category category, IEnumerable<string> productNames);
        IEnumerable<Product> GetAll();
    }
}
