using Microsoft.EntityFrameworkCore;

namespace Git_Example.Repositories.Abstractions;

public class BaseRepository<TContext, TEntity, TKey>(TContext context, TEntity entity, TKey id) : IBaseRepository<TEntity, TKey>
    where TEntity : class
    where TContext : DbContext
    where TKey : IComparable, IEquatable<TKey>
{
    public Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}