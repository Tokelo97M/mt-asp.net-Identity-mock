﻿using IdentityApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace IdentityApp.Areas.Identity.Data;

public class DbIdentitySample : IdentityDbContext<IdentityAppUser>
{
    public DbIdentitySample(DbContextOptions<DbIdentitySample> options)
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

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<IdentityAppUser>
{
    public void Configure(EntityTypeBuilder<IdentityAppUser> builder)
    {
        builder.Property(x => x.Fname).HasMaxLength(100);
        builder.Property(y => y.Lname).HasMaxLength(100);
    }
}