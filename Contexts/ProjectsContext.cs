using System.Data.Entity;
using EstateZoningApp.Core.Models;

namespace EstateZoningApp.Core.Contexts;
public class ProjectsContext : BaseDbContext
{
    public ProjectsContext() : base()
    {
    }

    public DbSet<Project> Projects
    {
        get;
        set;
    }
}
