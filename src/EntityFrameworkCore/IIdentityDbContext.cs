/*
 * IIdentityDbContext.cs
 *
 *   Created: 2022-12-30-11:37:53
 *   Modified: 2022-12-30-11:37:54
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;
using Microsoft.EntityFrameworkCore.Abstractions;

[GenerateInterfaceAttribute(typeof(IdentityDbContext))]
public partial interface IIdentityDbContext : IDbContext<IIdentityDbContext>
{

}
