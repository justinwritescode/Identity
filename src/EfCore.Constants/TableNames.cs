/*
 * TableNames.cs
 *
 *   Created: 2022-12-01-05:14:16
 *   Modified: 2022-12-01-05:14:17
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.EntityFrameworkCore;

public static partial class Constants
{
    public static partial class TableNames
    {
        public const string tbl_User = nameof(tbl_User);
        public const string tbl_UserLogin = nameof(tbl_UserLogin);
        public const string tbl_Role = nameof(tbl_Role);
        public const string tbl_UserRole = nameof(tbl_UserRole);
        public const string tbl_UserClaim = nameof(tbl_UserClaim);
        public const string tbl_RoleClaim = nameof(tbl_RoleClaim);
        public const string tbl_UserToken = nameof(tbl_UserToken);
        public const string tbl_LoginProvider = nameof(tbl_LoginProvider);
        public const string tbl_ClaimType = nameof(tbl_ClaimType);
    }
}
