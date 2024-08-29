using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mvcproject2.Areas.Identity.Data;

namespace mvcproject2.Areas.Identity.Data;

public class sampleDbContext : IdentityDbContext<sampleUser>
{
    public sampleDbContext(DbContextOptions<sampleDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<sampleUser>
{
    public void Configure(EntityTypeBuilder<sampleUser> builder)
    {
        builder.Property(x => x.name).HasMaxLength(30);
    }
}
