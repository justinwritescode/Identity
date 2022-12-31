/*
 * RoleStore.cs
 *
 *   Created: 2022-12-30-11:08:42
 *   Modified: 2022-12-30-11:08:43
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;

using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Identity;

public class RoleStore : Microsoft.AspNetCore.Identity.EntityFrameworkCore.RoleStore<Role, IdentityDbContext, int, UserRole, RoleClaim>
{
    public RoleStore(IdentityDbContext context, IdentityErrorDescriber? describer = null) : base(context, describer)
    {
    }
}
