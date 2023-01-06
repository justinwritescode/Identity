/*
 * UserManager.cs
 *
 *   Created: 2022-12-13-10:53:25
 *   Modified: 2022-12-13-10:53:25
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Security.Claims;
using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MSIDR = Microsoft.AspNetCore.Identity.IdentityResult;

namespace JustinWritesCode.Identity;

public class UserManager : UserManager<User>, IHaveADbContext<IIdentityDbContext>
{
    private readonly IPasswordGenerator _passwordGenerator;

    public UserManager(IUserStore<User> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<User> passwordHasher, IEnumerable<IUserValidator<User>> userValidators, IEnumerable<IPasswordValidator<User>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<User>> logger, IIdentityDbContext db, IPasswordGenerator passwordGenerator)
        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
    {
        Db = db;
        _passwordGenerator = passwordGenerator;
    }

    public IIdentityDbContext Db { get; }
    // IDbContext IHaveADbContext.Db => Db;
    public override IQueryable<User> Users => Db.Users;

    public virtual Task<User?> FindByIdAsync(int userId) => FindByIdAsync(userId.ToString());

    public override Task<User?> FindByNameAsync(string userName)
    {
        if (userName is null)
            throw new ArgumentNullException(nameof(userName));

        var users = Users ?? Db.Users;
       return users.FirstOrDefaultAsync(u => u.UserName == userName);
    }

    public override async Task<IList<Claim>> GetClaimsAsync(User user)
    {
        if (user is null)
            throw new ArgumentNullException(nameof(user));

        var claims = await Db.UserClaims.Where(uc => uc.UserId == user.Id).Select(uc => uc.ToClaim()).ToListAsync();
        return claims;
    }

    public override async Task<MSIDR> AddClaimAsync(User user, Claim claim)
    {
        return user is null ? throw new ArgumentNullException(nameof(user))
            : claim is null ? throw new ArgumentNullException(nameof(claim)) :
            user.Claims.Any(c => c.ClaimType == claim.Type && c.ClaimValue == claim.Value) ?
            MSIDR.Success :
            await AddUserClaimAsync(user, UserClaim.FromClaim(user.Id, claim));

        async Task<MSIDR> AddUserClaimAsync(User user, UserClaim claim)
        {
            user.Claims.Add(claim);
            _ = Db.Users.Update(user);
            return await Db.SaveChangesAsync(default).ContinueWith(t => MSIDR.Success);
        };
    }

    public virtual async Task<string> GeneratePasswordAsync(User user)
    {
        var password = _passwordGenerator.GeneratePassword();
        return (await AddPasswordAsync(user, password)).Succeeded ? password : throw new Exception("Failed to generate password");
    }
}
