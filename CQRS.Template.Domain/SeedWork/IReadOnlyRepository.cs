using System.Collections.Generic;
using CQRS.Template.Domain.QueryMapper;

namespace CQRS.Template.Domain.SeedWork
{
    public interface IReadOnlyRepository<T, TEntity>
    {
        IEnumerable<TEntity> GetMultiple(QueryOptions options);

        TEntity Get(T id);
    }
}