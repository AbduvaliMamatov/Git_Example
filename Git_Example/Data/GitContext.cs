using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Git_Example.Entities;

namespace Git_Example.Data;

public class GitContext : DbContext, IGitContext
{
    public DbSet<Git> Gits { get; set; } = null!;

    public DatabaseFacade Database => base.Database;

    public GitContext(DbContextOptions<GitContext> options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}