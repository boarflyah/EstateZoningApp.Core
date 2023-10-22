using System.Data.Entity;
using EstateZoningApp.Core.Models;

namespace EstateZoningApp.Core.Contexts;
public class ShapesContext : BaseDbContext
{
    public ShapesContext() : base()
    {
    }

    public DbSet<SimpleShape> Shapes
    {
        get;
        set;
    }
}
