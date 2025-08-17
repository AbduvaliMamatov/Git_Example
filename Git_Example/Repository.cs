using Microsoft.EntityFrameworkCore;

namespace Git_Example;

public class Repository<TContext,T>(TContext context, T) : IBaseRepository<T>
    where T : class
    where TContext: DbContext
{
    public Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}