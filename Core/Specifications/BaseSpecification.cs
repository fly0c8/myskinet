﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {

        }
        public BaseSpecification(Expression<Func<T, bool>> critieria)
        {
            Critieria = critieria;            
        }
     
        public Expression<Func<T, bool>> Critieria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
