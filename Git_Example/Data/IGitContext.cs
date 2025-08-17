using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Git_Example.Entities;

namespace Git_Example.Data;
public interface IGitContext
{
    DbSet<Git> Gits { get; set; }

    DatabaseFacade Database { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}