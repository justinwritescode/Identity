/*
 * UserRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-05-03:50:21
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace JustinWritesCode.Identity.Models;
using Abstractions;
using JustinWritesCode.Abstractions;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

/// <summary>A join entity between <see cref="User" />s and <see cref="Role" />s</summary>
[Table(tbl_UserRole, Schema = IdSchema), DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")]
[JSerializable(typeof(UserRole))]
public class UserRole : IdentityUserRole<int>, IIdentifiable<int>//, IUserAssociatedEntity//, IHaveTimestamps
{
    [Key, DbGen(DbGenO.None), Column(nameof(Id), TypeName = DbTypeBigInt)]
    public virtual int Id { get; set; } //= NewId;

    [Column(nameof(RoleId), Order = 2, TypeName = DbTypeBigInt)]
    public override int RoleId { get => base.RoleId; set => base.RoleId = value; }

    [Column(nameof(UserId), Order = 1, TypeName = DbTypeBigInt)]
    public override int UserId { get => base.UserId; set => base.UserId = value; }

    public User User { get; set; }
    public Role Role { get; set; }

    //[ForeignKey(ColUserId)]
    //public virtual BackroomUser User { get; set; }

    //[ForeignKey(nameof(RoleId))]
    //public virtual BackroomRole Role { get; set; }


    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public struct UserRoleInsertDto
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
}
