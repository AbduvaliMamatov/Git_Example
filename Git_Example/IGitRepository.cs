using Git_Example.Entities ;
using Microsoft.EntityFrameworkCore;
using Git_Example;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Git_Example.Data;
namespace Git_Example.Repositories;

public interface IGitRepository : IBaseRepository<Git, int>
{
    Task<Git?> GetByVersionAsync(double version, CancellationToken cancellationToken = default);
}
public class GitRepository : BaseRepository<GitContext, Git, int>, IGitRepository
{
    public GitRepository(GitContext context) : base(context, null, 0)
    {
    }

    public async Task<Git?> GetByVersionAsync(double version, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}