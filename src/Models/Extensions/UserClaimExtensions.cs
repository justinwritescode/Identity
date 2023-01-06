/*
 * UserClaimExtensions.cs
 *
 *   Created: 2022-12-19-09:02:25
 *   Modified: 2022-12-19-09:02:26
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;

namespace JustinWritesCode.Identity;

public static class UserClaimExtensions
{
    public static UserClaim ToUserClaim(this C c)
    {
        var uc = new UserClaim();
        uc.InitializeFromClaim(c);
        return uc;
    }
}
