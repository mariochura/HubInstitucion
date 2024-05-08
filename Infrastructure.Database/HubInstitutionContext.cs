using Infrastructure.Database.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class HubInstitutionContext : DbContext
{
    public DbSet<OrganizationEntity> Organizations { get; set; }

    public HubInstitutionContext(DbContextOptions<HubInstitutionContext> options) : base(options)
    {
        SeedData();
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<OrganizationEntity>()
            .Property(p => p.Name)
            .HasMaxLength(100);

        base.OnModelCreating(builder);
    }

    private void SeedData()
    {
        Organizations.Add(new OrganizationEntity { Name = "Carlos" });
        Organizations.Add(new OrganizationEntity { Name = "Maria" });
        Organizations.Add(new OrganizationEntity { Name = "Jose" });
        Organizations.Add(new OrganizationEntity { Name = "Joana" });
        SaveChanges();
    }
}