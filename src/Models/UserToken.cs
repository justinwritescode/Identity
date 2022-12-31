/*
 * UserToken.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-04-11:54:26
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace JustinWritesCode.Identity.Models;
using JustinWritesCode.Identity.Abstractions;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

[Table(tbl_UserToken, Schema = IdSchema), DebuggerDisplay("User Token ({UserId} - {LoginProvider}, Created: {DateTimeCreated})")]
[JSerializable(typeof(UserToken))]
public class UserToken : IdentityUserToken<int>, IIdentifiable<int>//, IUserAssociatedEntity//, IUserLoginThing//, IHaveTimestamps
{
    [Key, DbGen(DbGenO.Identity)/*, Column(ColId, Order = 0, TypeName = TInt)*/]
    public virtual int Id { get; set; } //= NewId;

    [Column(nameof(UserId))]
    public override int UserId { get => base.UserId; set => base.UserId = value; }

    //[ForeignKey(ColUserId)]
    public virtual User User { get; set; }

    [Column("ProviderName")]
    public override string LoginProvider { get => base.LoginProvider; set => base.LoginProvider = value; }

    //[ForeignKey(nameof(ProviderId)), BackingField("_provider")]
    protected virtual UserLoginProvider Provider
    {
        get => UserLoginProvider.Parse<UserLoginProvider>(LoginProvider);
        set => base.LoginProvider = value.DisplayName;
    }

    [Column(nameof(Name)), StringLength(64)]
    public override string Name { get => base.Name; set => base.Name = value; }

    [Column(nameof(Value)), StringLength(256)]
    public override string Value { get => base.Value; set => base.Value = value; }

    [Column(nameof(Created))]
    public virtual DateTime Created { get; set; } = Now;

    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }

}

// public class TelegramUserToken : BackroomUserToken
// {
//     public override byte ProviderId { get => ProviderId = (byte)TelegramLoginProvider; set => ProviderId = (byte)TelegramLoginProvider; }
// }
