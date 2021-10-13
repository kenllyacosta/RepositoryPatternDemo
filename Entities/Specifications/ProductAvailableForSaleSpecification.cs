using Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Specifications
{
    public class ProductAvailableForSaleSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> Expression 
        {
            get
            {
                var inStock = new ProductsWithUnitsInStockSpecification();
                var notDiscontinued = new ProductDiscontinuedSpecification().Not();

                return inStock.And(notDiscontinued).Expression;
            } 
        }            
    }
}
