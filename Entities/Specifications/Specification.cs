using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> Expression { get; }

        public bool IsSatisfied(T entity)
        {
            Func<T, bool> Delegate = Expression.Compile();
            return Delegate(entity);
        }

        public Specification<T> Not() =>
            new NotSpecification<T>(this);

        public Specification<T> And(Specification<T> specification) =>
            new AndSpecification<T>(this, specification);
    }
}
