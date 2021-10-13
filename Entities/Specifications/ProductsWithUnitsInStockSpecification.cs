using Entities.POCOs;
using System;
using System.Linq.Expressions;

namespace Entities.Specifications
{
    public class ProductsWithUnitsInStockSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> Expression =>
            p => p.UnitsInStock > 0;
    }
}