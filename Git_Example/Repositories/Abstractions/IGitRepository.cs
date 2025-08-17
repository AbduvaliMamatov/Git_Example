using Git_Example.Entities ;
using Microsoft.EntityFrameworkCore;
using Git_Example.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Git_Example.Data;
namespace Git_Example.Repositories.Abstractions;

public interface IGitRepository : IBaseRepository<Git, int>
{
    Task<Git?> GetByVersionAsync(double version, CancellationToken cancellationToken = default);
}