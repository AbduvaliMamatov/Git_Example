using Git_Example.Data;
using Git_Example.Entities;
using Git_Example.Repositories.Abstractions;

namespace Git_Example.Repositories;

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