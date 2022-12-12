using EntertaimentCenter.Application.DbAccess.Configuration;
using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;


namespace EntertaimentCenter.Application.DbAccess;

internal class EntertaimentCenterDbContext : DbContext
{
    public EntertaimentCenterDbContext(DbContextOptions<EntertaimentCenterDbContext> options)
        : base(options)
    {

    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<CustomEvent> CustomEvents { get; set; }

    public DbSet<Discount> Discounts { get; set; }

    public DbSet<DiscountCard> DiscountsCards { get; set; } 

    public DbSet<Order> Orders { get; set; }

    public DbSet<Place> Places { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountCardConfiguration());
        modelBuilder.ApplyConfiguration(new EventConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new PlaceConfiguration());
    }
}
