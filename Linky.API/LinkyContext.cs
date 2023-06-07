using Linky.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Linky.API;

public class LinkyContext : DbContext
{
    public LinkyContext()
    {
    }

    public LinkyContext(DbContextOptions<LinkyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Indicator> Indicator { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Indicator>(entity =>
        {
            entity.HasKey(e => e.IdIndicator);

            entity.ToTable("Indicator");

            entity.Property(e => e.NumIndicator);

            entity.Property(e => e.SwitchOnIndicator);

            entity.Property(e => e.ConsumIndicator);

            entity.Property(e => e.PowerIndicator);

            entity.Property(e => e.HourConsumIndicator);

            entity.Property(e => e.DayConsumIndicator);

            entity.Property(e => e.MonthConsumIndicator);

        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
        base.OnConfiguring(optionsBuilder);
    }
}
