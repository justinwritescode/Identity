/*
 * JwcPrincipal.cs
 *
 *   Created: 2022-11-13-03:32:35
 *   Modified: 2022-12-02-10:38:11
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models
{
    [DebuggerDisplay("{User}")]
    public class Principal : ClaimsPrincipal
    {
        public Principal(User user, string authenticationType, string nameType, string roleType)
            : base(new Identity(user.Claims, authenticationType, nameType, roleType))
        {
            User = user;
        }

        public User User { get; }

        protected override ClaimsIdentity CreateClaimsIdentity(BinaryReader reader)
        {
            var claimsIdentity = base.CreateClaimsIdentity(reader);
            return new Identity(claimsIdentity.Claims.Cast<UserClaim>(), claimsIdentity.AuthenticationType, claimsIdentity.NameClaimType, claimsIdentity.RoleClaimType);
        }
    }

    public class Identity : ClaimsIdentity
    {
        public Identity(IEnumerable<UserClaim> claims, string authenticationType, string nameType, string roleType)
            : base(claims.Cast<C>(), authenticationType, nameType, roleType)
        {
            Claims = claims.Select(c => c.ToClaim()).ToList();
        }

        public override string? Name => FindFirst(NameClaimType)?.Value;
        protected override C CreateClaim(BinaryReader reader) => (UserClaim)base.CreateClaim(reader);


        public override IEnumerable<C> Claims { get; }
        // // public override IEnumerable<C> Claims => Claims.Cast<C>();
        // public override void AddClaim(C claim) => AddClaims(new[] { claim });
        // public override void AddClaims(IEnumerable<C>? claims) => Claims.AddRange(claims.Cast<UserClaim>());
        // public override void RemoveClaim(Claim? claim) { Claims.Remove(Claims.FirstOrDefault(c => c.Type == claim.Type && c.Value == claim.Value)); }
    }
}
