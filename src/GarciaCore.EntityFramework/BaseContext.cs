using GarciaCore.Application;
using GarciaCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace GarciaCore.EntityFramework;

public class BaseContext : DbContext
{
    private readonly ILoggedInUserService _loggedInUserService;

    public BaseContext(DbContextOptions options, ILoggedInUserService loggedInUserService) : base(options)
    {
        _loggedInUserService = loggedInUserService;
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<IEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedOn = DateTimeOffset.UtcNow;
                    entry.Entity.CreatedBy = _loggedInUserService?.UserId;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastUpdatedOn = DateTimeOffset.UtcNow;
                    entry.Entity.LastUpdatedBy = _loggedInUserService?.UserId;
                    break;
                case EntityState.Deleted:
                    entry.Entity.DeletedOn = DateTimeOffset.UtcNow;
                    entry.Entity.DeletedBy = _loggedInUserService?.UserId;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}