/*
 * IUserClaim.cs
 *
 *   Created: 2022-12-23-06:21:08
 *   Modified: 2022-12-23-06:21:09
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;

using Microsoft.EntityFrameworkCore.Query;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
public interface IUserClaim : IEntityClaim<IUserClaim>, IUserAssociatedEntity
{
#if NET6_0_OR_GREATER
    public int UserId { get => EntityId; set => EntityId = value; }
#else
    public int UserId { get; set; }
#endif
}
