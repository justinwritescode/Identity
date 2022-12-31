/*
 * IdentityDbContext.cs
 *
 *   Created: 2022-12-05-08:06:03
 *   Modified: 2022-12-05-08:06:03
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace JustinWritesCode.Identity;

using System.Net.Mail;
using JustinWritesCode.EntityFrameworkCore;
using JustinWritesCode.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Telegram.Bot.Types;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;
using static JustinWritesCode.Identity.EntityFrameworkCore.Constants;
using static JustinWritesCode.Identity.EntityFrameworkCore.Constants.TableNames;
using IdentityClaimType = JustinWritesCode.Identity.Models.ClaimType;
using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using User = JustinWritesCode.Identity.Models.User;

public class IdentityDbContext : MSID.IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>,
    IDbContext<IdentityDbContext>, IIdentityDbContext
{
    public virtual DbSet<Bot> Bots { get; set; }
    public virtual DbSet<UserContactId> UserContactIds { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<UserClaim> UserClaims { get; set; }
    public virtual DbSet<UserRole> UserRoles { get; set; }
    public virtual DbSet<UserLogin> UserLogins { get; set; }
    public virtual DbSet<RoleClaim> RoleClaims { get; set; }
    public virtual DbSet<UserToken> UserTokens { get; set; }
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>(entity =>
        {
            entity.ToTable(tbl_User, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasKey(e => e.Id);
            entity.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Ignore(e => e.EmailAddress);
            entity.Ignore(e => e.NormalizedEmailAddress);
            // entity.Property(e => e.Phone).HasConversion<System.Domain.PhoneNumber.EfCoreValueConverter>();
            entity.HasMany(u => u.Bots).WithMany(b => b.Contacts).UsingEntity<UserContactId>(
                uc => uc.HasOne(uc => uc.Bot).WithMany(bot => bot.ContactIds).HasForeignKey(uc => uc.BotId),
                uc => uc.HasOne(uc => uc.User).WithMany(user => user.ContactIds).HasForeignKey(uc => uc.UserId),
                uc => uc.HasKey(uc => new { uc.UserId, uc.BotId })
            );
            // // entity.Property(e => e.SendPulseId).HasConversion<SendPulse.Data.ValueObjects.SendPulseIdConverter>();
            // entity.HasIndex(e => e.NormalizedEmail)/*.HasName("EmailIndex")*/;
            // entity.HasIndex(e => e.NormalizedUserName).IsUnique()/*.HasName("UserNameIndex").HasFilter("[NormalizedUserName] IS NOT NULL")*/;
        });
        builder.Entity<Role>(entity =>
        {
            entity.ToTable(tbl_Role, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            // entity.Property(e => e.Name).HasMaxLength(256);
            // entity.Property(e => e.NormalizedName).HasMaxLength(256);
            // entity.HasIndex(e => e.NormalizedName).IsUnique().HasName("RoleNameIndex").HasFilter("[NormalizedName] IS NOT NULL");
            entity.Property(e => e.Uri).HasConversion<System.uri.EfCoreValueConverter>();
            entity.HasMany(e => e.Users).WithMany(u => u.Roles).UsingEntity<UserRole>(
                ur => ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId).HasPrincipalKey(u => u.Id),
                ur => ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).HasPrincipalKey(r => r.Id),
                ur => ur.HasKey(ur => new { ur.UserId, ur.RoleId })
            );
        });
        builder.Entity<UserRole>(entity =>
        {
            entity.ToTable(tbl_UserRole, IdSchema);
            entity.HasKey(e => new { e.UserId, e.RoleId });
            entity.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserClaim>(entity =>
        {
            entity.ToTable(tbl_UserClaim, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Properties).HasConversion <JsonObjectConverter<IStringDictionary>>();
            entity.Property(e => e.Type).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.Issuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.OriginalIssuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.ValueType).HasConversion<uri.EfCoreValueConverter>();
            entity.HasOne(e => e.User).WithMany(u => u.Claims).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserLogin>(entity =>
        {
            entity.ToTable(tbl_UserLogin, IdSchema);
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.ProviderDisplayName });
            entity.HasOne(e => e.User).WithMany(u => u.Logins).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<RoleClaim>(entity =>
        {
            entity.ToTable(tbl_RoleClaim, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Properties).HasConversion<JsonObjectConverter<IStringDictionary>>();
            entity.Property(e => e.Type).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.Issuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.OriginalIssuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.ValueType).HasConversion<uri.EfCoreValueConverter>();
            entity.HasOne(e => e.Role).WithMany().HasForeignKey(e => e.RoleId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserToken>(entity =>
        {
            entity.ToTable(tbl_UserToken, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasOne(e => e.User).WithMany(u => u.Tokens).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<Bot>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ApiToken).HasConversion<BotApiToken.EfCoreValueConverter>();
            entity.Property(e => e.SendPulseId).HasConversion<ObjectId.EfCoreValueConverter>();
        });
        builder.Entity<UserContactId>(entity =>
        {
            entity.Property(e => e.ContactId).HasConversion<ObjectId.EfCoreValueConverter>();
        });
        builder.Entity<IdentityClaimType>(entity =>
        {
            entity.ToTable(tbl_ClaimType, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Uri).HasConversion<uri.EfCoreValueConverter>();
            // entity.HasMany(e => e.Users).WithMany(u => u.ClaimTypes).UsingEntity<UserClaim>(
            //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc => uc.UserId).HasPrincipalKey(u => u.Id),
            //     uc => uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct => ct.Id
            //     uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
            // );
            // entity.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
        });
    }

    public override DbSet<TEntity> Set<TEntity>()
    {
        if (typeof(TEntity) == typeof(UserClaim))
        {
            return base.Set<UserClaim>().Include(uc => uc.ClaimType) as DbSet<TEntity>;
        }
        else if(typeof(TEntity) == typeof(User))
        {
            return Users.Include(u => u.Roles).Include(u => u.Claims) as DbSet<TEntity> ?? Users as DbSet<TEntity>;
        }
        else
        {
            return base.Set<TEntity>();
        }
        base.Set<TEntity>();
    }
}
