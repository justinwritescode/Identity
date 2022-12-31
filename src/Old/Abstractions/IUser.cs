/*
 * IUser.cs
 *
 *   Created: 2022-11-13-03:32:35
 *   Modified: 2022-11-14-11:13:44
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;

public interface IUser : IIdentifiable<long>, IHaveAWritableId<long>
{
    int AccessFailedCount { get; set; }
    bool IsLockoutEnabled { get; set; }
    bool IsEmailConfirmed { get; set; }
    bool IsPhoneNumberConfirmed { get; set; }
    bool IsTwoFactorEnabled { get; set; }
    bool IsLockedOut { get; }
    string Email { get; set; }
    string UserName { get; set; }
    string PhoneNumber { get; set; }
    IEnumerable<IRole> Roles { get; }
    IEnumerable<IUserLogin> Logins { get; }
    IEnumerable<IUserToken> Tokens { get; }
    IEnumerable<IUserClaim> Claims { get; }
}
