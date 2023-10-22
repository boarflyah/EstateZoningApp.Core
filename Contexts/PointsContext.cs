using System.Data.Entity;
using EstateZoningApp.Core.Models;

namespace EstateZoningApp.Core.Contexts;
public class PointsContext : BaseDbContext
{
    public PointsContext() : base()
    {
    }

    public DbSet<SimplePoint> Points
    {
        get; set;
    }
}
