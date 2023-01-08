/*
 * ClaimsPrincipalExtensions.cs
 *
 *   Created: 2023-01-06-06:07:12
 *   Modified: 2023-01-06-06:07:13
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Extensions.Security;

using JustinWritesCode.Identity;

public static class ClaimsPrincipalExtensions
{
    public static ClaimsPrincipal ToClaimsPrincipal(this User user)
    {
        return new ClaimsPrincipal(user);
    }

    public static ClaimsIdentity ToClaimsIdentity(this User user)
    {
        return new ClaimsIdentity();
    }
}
