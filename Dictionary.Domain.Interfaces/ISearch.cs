using System;
using System.Collections.Generic;
using System.Linq.Expressions;
//using System.Collections.Generic;
using System.Text;
using Dictionary.Domain.Core;

namespace Dictionary.Domain.Interfaces
{
    public interface ISearch<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);

    }
}
