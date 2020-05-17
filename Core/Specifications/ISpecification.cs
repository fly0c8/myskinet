using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        // our where criteria
        Expression<Func<T, bool>> Critieria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
    }
}
