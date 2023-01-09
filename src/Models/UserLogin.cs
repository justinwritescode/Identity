/*
 * UserLogin.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-05-06:32:13
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

#pragma warning disable
namespace JustinWritesCode.Identity.Models;
using Abstractions;
using JustinWritesCode.Abstractions;
using Microsoft.AspNetCore.Identity;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

[Table(tbl_UserLogin, Schema = IdSchema), DebuggerDisplay("User Login (Id} - {LoginProvider}: {ProviderKey})")]
[JSerializable(typeof(UserLogin))]
public class UserLogin : IdentityUserLogin<int>, IIdentifiable<int>, IUserAssociatedEntity, IUserLoginThing//, IHaveTimestamps
{
    [Key, DbGen(DbGen.Identity), Column(nameof(Id), TypeName = DbTypeInt), Required]
    public virtual int Id { get; set; }

    [NotMapped]
    public virtual string ProviderName
    {
        get => base.LoginProvider;
        set => base.LoginProvider = value;
    }

    public override string ProviderKey { get => base.ProviderKey; set => base.ProviderKey = value; }

    [NotMapped]
    public override string ProviderDisplayName { get => Provider.DisplayName; set { } }

    [JIgnore, Newtonsoft.Json.JsonIgnore]
    public virtual UserLoginProvider Provider { get => UserLoginProvider.Parse(ProviderName, null); set => ProviderName = value.Name; }

    public virtual int ProviderId
    {
        get => Provider.Id;
        set
        {
            Provider = UserLoginProvider.FromId(value);
            ProviderName = Provider.Name;
            ProviderDisplayName = Provider.DisplayName;
        }
    }

    public virtual User User { get; set; }

    [Hashids]
    public override int UserId { get => base.UserId; set => base.UserId = value; }

    public virtual DateTime Created { get; set; } = UtcNow;
}

// public class TelegramUserLogin : BackroomUserLogin
// {
//     public override byte ProviderId { get => ProviderId = (byte)TelegramLoginProvider; set => base.ProviderId = (byte)TelegramLoginProvider; }
//     [NotMapped]
//     public long TelegramId { get => long.Parse(base.ProviderKey); set => base.ProviderKey = value.ToString(); }
// }

public struct UserLoginInsertDto
{
    public string ProviderName { get; set; }
    public string ProviderKey { get; set; }
    public string ProviderDisplayName { get; set; }
    public long UserId { get; set; }
}
