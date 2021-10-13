using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Specifications
{
    public class AndSpecification<T> : Specification<T>
    {
        readonly Specification<T> Specification;
        public AndSpecification(Specification<T> specification)
        {
            Specification = specification;
        }

        public override Expression<Func<T, bool>> Expression
        {
            get
            {
                var Param = System.Linq.Expressions.Expression.Parameter(typeof(T));
                var Body = System.Linq.Expressions.Expression.AndAlso(
                    System.Linq.Expressions.Expression.Invoke(Specification.Expression, Param));

                return System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(Body, Param);
            }
        }
    }
}
