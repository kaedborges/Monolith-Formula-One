using Microsoft.EntityFrameworkCore;

namespace MonolithFormulaOne.Modules.Driver.Persistence.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {}

    public virtual DbSet<Moludes.Driver.Domain.Models.Driver> Drivers { get; set; }
}