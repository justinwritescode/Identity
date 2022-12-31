using System.Threading.Tasks;
/*
 * User.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-03-11:30:01
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using System.Text.Json.Serialization;

namespace JustinWritesCode.Identity.Models;
using System.Collections.ObjectModel;
using System.Domain;
using System.Net.Mail;
using System.Xml.Serialization;
using Humanizer;
using JustinWritesCode.Abstractions;
using JustinWritesCode.Identity.Abstractions;
using static System.Guid;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

[Table(tbl_User, Schema = IdSchema), DebuggerDisplay("User ({UserName} - {Email})")/*, AutoGenerateBuilder*/]
public class User : IdentityUser<int>, IIdentifiable<int>, IUser//, IHaveTimestamps
{
    public const string DefaultPassword = "Just1n is really fuckin sexy!";

    public User() { }

    /// <summary>The user's ID unique to The JustinWritesCode family of apps and bots.</summary>
    [Hashids, DbGen(DbGenO.Identity)]
    public override int Id { get => base.Id; set => base.Id = value; }
    /// <summary>Gets or sets the user's Telegram username</summary>
    /// <example>sleazytucker69</example>
    public virtual string? TelegramUsername { get; set; }
    /// <summary>Gets or sets the user's Telegram ID 64, a-bit signed integer</summary>
    /// <example>1234567</example>
    public virtual long TelegramId { get; set; }

    /// <summary>Gets or sets the user's given/first name </summary>
    /// <example>Justin</example>
    public virtual string? GivenName { get; set; } = null;
    /// <inheritdoc cref="IBasicUserInfo.Surname" />
    public virtual string? Surname { get; set; } = null;
    /// <summary>Gets or sets the user's "go-by" name, or what he'd like to be called.</summary>
    /// <example>God of Telegram</example>
    public virtual string? GoByName { get; set; } = null;

    /// <summary>The number of times the user tried and failed to authenticate.</summary>
    [DefaultValue(0)]
    public override int AccessFailedCount { get; set; } = 0;
    /// <summary>Gets or sets a flag indicating if the user can be locked out.</summary>
    /// <value><pre><b>True</b></pre> if the user <b><b>can</b></b> be locked out, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(true), Column("Is" + nameof(LockoutEnabled))]
    public virtual bool LockoutEnabled { get; set; } = true;
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="Email"/> address in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(EmailConfirmed))]
    public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone address.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="PhoneNumber"/> in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(PhoneNumberConfirmed))]
    public virtual bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
    /// <summary>Gets or sets a flag indicating if a user has two-factor authentication set up.</summary>
    /// <value><pre><b>True</b></pre> if the user has two-factor authentication set up,  <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(TwoFactorEnabled))]
    public virtual bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
    /// <summary>Gets or sets a flag indicating whether the user has been locked out (either deliberately be an administrator or by exhausting the number of attempts allowed to authenticate.</summary>
    /// <value><pre>True</pre> if the user <b><i>is locked out</i></b> right now, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(LockedOut))]
    public virtual bool LockedOut => LockoutEnabled && LockoutEnd > Now;
    /// <summary>Gets or sets the user's email address as a string.</summary>
    [Column("EmailAddress", TypeName = DbTypeNVarChar), JIgnore, XmlIgnore]
    public override string? Email { get => base.Email; set { base.Email = value; base.NormalizedEmail = value?.Normalize(); } }
    /// <summary>Gets or sets the normalized email address for this user as a string.</summary>
    [Column(nameof(NormalizedEmailAddress)), JIgnore, XmlIgnore]
    public override string NormalizedEmail  { get => base.NormalizedEmail; set { base.NormalizedEmail = value; } }
    /// <summary>Gets or sets the user's username (usually the same as the <see cref="TelegramUsername" />)</summary>
    /// <example>justinwritescode</example>
    [JsonPropertyName("username")]
    public override string? UserName { get => base.UserName; set { base.UserName = value; base.NormalizedUserName = value?.Normalize(); } }

    /// <inheritdoc cref="IBasicUserInfo.PhoneNumber" />
    /// <example>+19185256012</example>
    [NotMapped]
    public override string? PhoneNumber { get; set; }

    /// <inheritdoc cref="IUser.ConcurrencyStamp" />
    [Timestamp, Column(nameof(ConcurrencyStamp), TypeName = DbTypeRowVersion), DbGen(DbGenO.Computed), JsonIgnore]
    public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }

    /// <summary>A hashed and salted representation of the user's password.</summary>
    [JsonIgnore]
    public override string PasswordHash { get; set; } = "*** PASSWORD NOT SET ***";
    /// <summary>A random value that must change whenever a users credentials change (password changed, login removed)</summary>

    [Timestamp, Column(nameof(SecurityStamp), TypeName = DbTypeNVarChar)]
    public override string? SecurityStamp { get; set; } = NewGuid().ToString();
    /// <summary>Gets or sets the normalized email address for this user as a data structure.</summary>
    [NotMapped]
    public virtual EmailAddress? NormalizedEmailAddress { get => NormalizedEmail; set => NormalizedEmail = value; }
    /// <summary>Gets or sets the the user's email address as a data structure.</summary>
    public virtual EmailAddress? EmailAddress { get => Email; set => Email = value; }
    [NotMapped]
    public virtual PhoneNumber? Phone { get => PhoneNumber; set => PhoneNumber = value; }
    /// <summary>Gets or sets the user's phone number as a data structure in E.164 format</summary>
    /// <example>+19185256012</example>
    PhoneNumber? IBasicUserInfo.PhoneNumber { get => Phone; set => Phone = value; }

    /// <summary>The roles to which the user belongs</summary>
    public virtual Collection<Role> Roles { get; set; } = new Collection<Role>();
    /// <summary>The user's logins for various federated providers</summary>
    public virtual Collection<UserLogin> Logins { get; set; } = new Collection<UserLogin>();
    /// <summary>The user's tokens</summary>
    public virtual Collection<UserToken> Tokens { get; set; } = new Collection<UserToken>();
    /// <summary>The user's claims</summary>
    public virtual Collection<UserClaim> Claims { get; set; } = new Collection<UserClaim>();
    /// <summary>The user's bots by <see cref="UserContactId.UserContactId" /></summary>
    public virtual Collection<Bot> Bots { get; set; } = new Collection<Bot>();
    /// <summary>A join entity between <see cref="User" />s and <see cref="Bot" />s</summary>
    public virtual Collection<UserContactId> ContactIds { get; set; } = new Collection<UserContactId>();
    /// <summary>A join entity between <see cref="User" />s and <see cref="Role" />s</summary>
    public virtual Collection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
    public virtual Collection<ClaimType> ClaimTypes { get; set; } = new Collection<ClaimType>();
    //public virtual ICollection<BackroomUserRole> UserRoles { get; set; } = new ObservableCollection<BackroomUserRole>();
}

public record class UserInsertDto : UserDto, IBasicUserInfo
{
    /// <summary>Gets or sets the user's password.</summary>
    /// <example>My$3cre1Pa$$w0rd!</example>
    public string? Password { get; set; } = User.DefaultPassword;
}

public record class UserDto : IBasicUserInfo
{
    public virtual string? UserName { get; set; }
    public virtual string? GivenName { get; set; }
    public virtual string? Surname { get; set; }
    public virtual string? GoByName { get; set; }
    public virtual PhoneNumber? PhoneNumber { get; set; }
    public virtual string? TelegramUsername { get; set; }
    public virtual long TelegramId { get; set; }
    public EmailAddress? EmailAddress { get; set; }
}

// //[AutoGenerateBuilder(typeof(BackroomUser))]
// //public partial class BackroomUserBuilder { }
