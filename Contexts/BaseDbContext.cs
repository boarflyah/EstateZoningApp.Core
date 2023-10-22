using System.Data.Entity;

namespace EstateZoningApp.Core.Contexts;
public abstract class BaseDbContext : DbContext
{
    public BaseDbContext(): base($"name=ProjectsDbConnectionString")
    {
    }
}
