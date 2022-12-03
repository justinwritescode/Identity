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
using System.Text.Json.Serialization;

// namespace Backroom.Identity.Models;
// using Abstractions;

// [Table(TblUser, Schema = SchId), DebuggerDisplay("User ({UserName} - {Email})")/*, AutoGenerateBuilder*/]
// public class BackroomUser : IdentityUser<BackroomKey>, IHaveAnId<BackroomKey>, IBackroomUser//, IHaveTimestamps
// {
//     /// <summary>The user's ID unique to The Backroom family of apps and bots.</summary>
//     [Hashid, Column(ColId, Order = 0, TypeName = TInt), DatabaseGenerated(DbGenO.None)]
//     public override BackroomKey Id { get; set; } = NewId();
//     /// <summary>The number of times the user tried and failed to authenticate.</summary>
//     [DefaultValue(0)]
//     public override int AccessFailedCount { get; set; } = 0;
//     /// <summary>Gets or sets a flag indicating if the user can be locked out.</summary>
//     /// <value><pre><b>True</b></pre> if the user <b><b>can</b></b> be locked out, <pre><b>false</b></pre> otherwise.</value>
//     [DefaultValue(true), Column(ColIsLockoutEnabled)]
//     public virtual bool IsLockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }
//     /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
//     /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="Email"/> address in his profile, <pre><b>false</b></pre> otherwise.</value>
//     [DefaultValue(false), Column(ColIsEmailConfirmed)]
//     public virtual bool IsEmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
//     /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone address.</summary>
//     /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="PhoneNumber"/> in his profile, <pre><b>false</b></pre> otherwise.</value>
//     [DefaultValue(false), Column(ColIsPhoneNumberConfirmed)]
//     public virtual bool IsPhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
//     /// <summary>Gets or sets a flag indicating if a user has two-factor authentication set up.</summary>
//     /// <value><pre><b>True</b></pre> if the user has two-factor authentication set up,  <pre><b>false</b></pre> otherwise.</value>
//     [DefaultValue(false), Column(ColIsTwoFactorEnabled)]
//     public virtual bool IsTwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
//     /// <summary>Gets or sets a flag indicating whether the user has been locked out (either deliberately be an administrator or by exhausting the number of attempts allowed to authenticate.</summary>
//     /// <value><pre>True</pre> if the user <b><i>is locked out</i></b> right now, <pre><b>false</b></pre> otherwise.</value>
//     [DatabaseGenerated(Computed)]
//     public virtual bool IsLockedOut => IsLockoutEnabled && LockoutEnd > Now;
//     public override string? Email { get => base.Email; set { base.Email = value; base.NormalizedEmail = value?.ToUpper(); } }
//     [JsonPropertyName("username")]
//     public override string? UserName { get => base.UserName; set { base.UserName = value; base.NormalizedUserName = value?.ToUpper(); } }

//     [MaybeNull]
//     public override string? PhoneNumber
//     {
//         get => (string)((PhoneNumber)base.PhoneNumber);
//         set => base.PhoneNumber = (PhoneNumber)value;
//     }

//     /// <summary>A random value that must change whenever a user is persisted to the store</summary>
//     [Timestamp, Column(nameof(ConcurrencyStamp), TypeName = TRowVersion), DatabaseGenerated(Computed), JsonIgnore]
//     public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }

//     [JsonIgnore]
//     public override string PasswordHash { get; set; } = "*** PASSWORD NOT SET ***";

//     [JsonIgnore]
//     public override string SecurityStamp { get; set; } = NewGuid().ToString();

//     private ObservableCollection<BackroomRole> _roles;
//     [NotMapped]
//     public virtual ICollection<BackroomRole> Roles { get; set; } = new List<BackroomRole>();
//     //{
//     //    get => _roles ??= new ActionedObservableCollection<BackroomRole>((UserRoles ?? Array.Empty<BackroomUserRole>()).Select(ur => ur.Role),
//     //        RolesAdded, RolesRemoved);
//     //}

//     public virtual ICollection<BackroomUserLogin> Logins { get; set; } = new ObservableCollection<BackroomUserLogin>();
//     public virtual ICollection<BackroomUserToken> Tokens { get; set; } = new ObservableCollection<BackroomUserToken>();
//     public virtual ICollection<BackroomUserClaim> Claims { get; set; } = new ObservableCollection<BackroomUserClaim>();
//     //public virtual ICollection<BackroomUserRole> UserRoles { get; set; } = new ObservableCollection<BackroomUserRole>();

//     [JsonIgnore]
//     public override string NormalizedEmail { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
//     [JsonIgnore]
//     public override string NormalizedUserName { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
//     [JsonIgnore, NotMapped]
//     public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
//     [JsonIgnore, NotMapped]
//     public override bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
//     [JsonIgnore, NotMapped]
//     public override bool LockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }
//     [JsonIgnore, NotMapped]
//     public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
// }

// //[AutoGenerateBuilder(typeof(BackroomUser))]
// //public partial class BackroomUserBuilder { }
