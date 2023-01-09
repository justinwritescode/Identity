/*
 * ClaimsPrincipal.cs
 *
 *   Created: 2023-01-03-05:39:44
 *   Modified: 2023-01-03-05:39:45
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
// #if NETSTANDARD2_0_OR_GREATER
namespace JustinWritesCode.Identity;
using JustinWritesCode.Identity.Models;
using SystemClaimsIdentity = System.Security.Claims.ClaimsIdentity;
using SystemClaimsPrincipal = System.Security.Claims.ClaimsPrincipal;

public class ClaimsPrincipal : SystemClaimsPrincipal
{
    public ClaimsPrincipal(User user) : base(new ClaimsIdentity(user))
    {

    }
}

public class ClaimsIdentity : SystemClaimsIdentity
{
    public ClaimsIdentity(User user) : base(user.Claims.Select(c => c.ToClaim()))
    {

    }
}
// #endif
