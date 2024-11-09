using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Contexts;

public class CloudSalesDbContext(DbContextOptions<CloudSalesDbContext> options) : DbContext(options)
{
    public DbSet<License> Licenses { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Service>()
            .HasKey(s => s.Id);

        modelBuilder.Entity<License>()
            .HasKey(l => l.Id);

        modelBuilder.Entity<Account>()
            .HasKey(a => a.Id);

        modelBuilder.Entity<License>()
            .HasOne(l => l.Account)
            .WithMany(a => a.Licenses)
            .HasForeignKey(l => l.AccountId);
    }
}