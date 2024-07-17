﻿using Core.CoreFeatures.Interfaces.Services;
using Core.CoreFeatures.Security.Models.Identity;
using Core.Domain.Contracts;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Database.Contexts;

public class EFAppDbContext : AuditableContext
{
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTimeService;
    public EFAppDbContext(DbContextOptions<EFAppDbContext> options, ICurrentUserService currentUserService, IDateTimeService dateTimeService) : base(options)
    {
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries<IAuditableEntity>().ToList())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedOn = _dateTimeService.NowUtc;
                    entry.Entity.CreatedBy = _currentUserService.UserId;
                    break;

                case EntityState.Modified:
                    entry.Entity.LastModifiedOn = _dateTimeService.NowUtc;
                    entry.Entity.LastModifiedBy = _currentUserService.UserId;
                    break;
                case EntityState.Deleted:
                    entry.Entity.DeletedOn = _dateTimeService.NowUtc;
                    entry.Entity.DeletedBy = _currentUserService.UserId;
                    break;
            }
        }
        if (_currentUserService.UserId == null)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        else
        {
            return await base.SaveChangesAsync(_currentUserService.UserId, cancellationToken);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }

        foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.Name is "LastModifiedBy" or "CreatedBy"))
        {
            property.SetColumnType("nvarchar(128)");
        }

        base.OnModelCreating(builder);
        builder.Entity<UserAccount>(entity =>
        {
            entity.ToTable(name: "Users", "Identity");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        builder.Entity<AccountRole>(entity =>
        {
            entity.ToTable(name: "Roles", "Identity");
        });
        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles", "Identity");
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims", "Identity");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins", "Identity");
        });

        builder.Entity<AccountRoleClaim>(entity =>
        {
            entity.ToTable(name: "RoleClaims", "Identity");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.RoleClaims)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens", "Identity");
        });
    }
}