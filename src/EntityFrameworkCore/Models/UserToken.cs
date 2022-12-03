//
//  TelegramUser.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 2022 Justin Chase
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
namespace Backroom.Identity.Models;
// using Abstractions;

// [Table(TblUserToken, Schema = SchId), DebuggerDisplay("User Token ({UserId} - {LoginProvider}, Created: {DateTimeCreated})")]
// public class BackroomUserToken : IdentityUserToken<BackroomKey>, IHaveAnId<BackroomKey>, IUserAssociatedEntity, IUserLoginThing//, IHaveTimestamps
// {
//     [Key, DatabaseGenerated(DbGenO.None), Column(ColId, Order = 0, TypeName = TInt)]
//     public virtual BackroomKey Id { get; set; } //= NewId;

//     //[Column(ColUserId, Order = 1, TypeName = TInt)]
//     public override BackroomKey UserId { get => base.UserId; set => base.UserId = value; }

//     //[ForeignKey(ColUserId)]
//     public virtual BackroomUser User { get; set; }

//     //[Column(nameof(LoginProvider))]
//     public virtual string ProviderName
//     {
//         get => base.LoginProvider;
//         set => base.LoginProvider = value;
//     }

//     //[ForeignKey(nameof(ProviderId)), BackingField("_provider")]
//     public virtual MUserLoginProvider Provider
//     {
//         get => Enum.Parse<UserLoginProviderEnum>(base.LoginProvider + "LoginProvider");
//         set => base.LoginProvider = value.ToString().Replace("LoginProvider", "");
//     }
//     private MUserLoginProvider _provider;

//     //[Column(nameof(ProviderId), TypeName = TByte), Required]
//     public virtual byte ProviderId
//     {
//         get => Provider;
//         set
//         {
//             Provider = value;
//             ProviderName = Provider;
//         }
//     }

//     //[Column(nameof(Name), Order = 3, TypeName = TNVarChar), StringLength(64)]
//     public override string Name { get => base.Name; set => base.Name = value; }

//     //[Column(nameof(Value), Order = 4, TypeName = TNVarChar), StringLength(256)]
//     public override string Value { get => base.Value; set => base.Value = value; }

//     //[Column(nameof(DateTimeCreated), Order = 5, TypeName = TDateTime)]
//     public virtual DateTime Created { get; set; } = Now;

//     //         public Timestamp Created { get; set; }
//     //         public Timestamp LastUpdated { get; set; }
//     //         public Timestamp? Deleted { get; set; }
// }

// public class TelegramUserToken : BackroomUserToken
// {
//     public override byte ProviderId { get => ProviderId = (byte)TelegramLoginProvider; set => ProviderId = (byte)TelegramLoginProvider; }
// }
