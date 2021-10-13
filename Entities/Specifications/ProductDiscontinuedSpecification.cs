using Entities.POCOs;
using System;
using System.Linq.Expressions;

namespace Entities.Specifications
{
    public class ProductDiscontinuedSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> Expression =>
            product => product.Discontinued;
    }
}
