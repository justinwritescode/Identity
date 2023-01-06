/*
 * DI.cs
 *
 *   Created: 2022-12-13-08:37:44
 *   Modified: 2022-12-13-08:37:44
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity;
using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using IdentityDbContext = JustinWritesCode.Identity.IdentityDbContext;
namespace Microsoft.Extensions.DependencyInjection;

public static class IdentityDependencyInjectionExtensions
{
    public static WebApplicationBuilder AddIdentity(this WebApplicationBuilder builder)
    {
        _ = builder.Services
            .AddSingleton<IPasswordGenerator, PasswordGenerator>();
        _ = builder.Services.Configure<PassphraseGeneratorOptions>(builder.Configuration.GetSection("PassphraseGeneratorOptions"));

        // _ = builder.Services.AddRazorPages();
        //_ = builder.Services.AddSingleton<ISystemClock, SystemClock>();
        _ = builder.Services.AddIdentityCore<User>(options => //.AddIdentity<User, Role>(options =>
        // _ = builder.Services.AddIdentity<User, Role>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
            options.User.RequireUniqueEmail = true;
            options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 16;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        })
            .AddEntityFrameworkStores<IdentityDbContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
            .AddSignInManager<SignInManager>()
            .AddRoles<Role>()
            .AddRoleStore<RoleStore>()
            .AddRoleManager<RoleManager>()
            .AddUserManager<UserManager>()
            .AddErrorDescriber<JustinsErrorDescriber>()
            .AddUserValidator<UserValidator<User>>()
            .AddPasswordValidator<PasswordValidator<User>>()
            .AddDefaultUI();
        return builder;
    }
}
