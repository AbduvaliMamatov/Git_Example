using Git_Example.Entities ;
using Microsoft.EntityFrameworkCore;
using Git_Example;
namespace Git_Example.Repositories;
public interface IGitRepository : IBaseRepository<Git, int>
{
    Task<Git?> GetByVersionAsync(double version, CancellationToken cancellationToken = default);
}