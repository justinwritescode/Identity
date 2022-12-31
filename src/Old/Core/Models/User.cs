using System.Text.Json.Serialization;

namespace JustinWritesCode.Identity.Models;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abstractions;
using static System.Guid;


[DebuggerDisplay("User ({UserName} - {Email})")/*, AutoGenerateBuilder*/]
public class User : IdentityUser<long>, IIdentifiable<long>, IUser//, IHaveTimestamps
{
    /// <summary>The user's ID unique to The  family of apps and bots.</summary>
    [Hashid]
    public override long Id { get; set; }
    /// <summary>The number of times the user tried and failed to authenticate.</summary>
    [DefaultValue(0)]
    public override int AccessFailedCount { get; set; } = 0;
    /// <summary>Gets or sets a flag indicating if the user can be locked out.</summary>
    /// <value><pre><b>True</b></pre> if the user <b><b>can</b></b> be locked out, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(true)]
    public virtual bool IsLockoutEnabled { get; set; } = true;
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="Email"/> address in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false)]
    public virtual bool IsEmailConfirmed { get; set; } = false;
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone address.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="PhoneNumber"/> in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false)]
    public virtual bool IsPhoneNumberConfirmed { get; set; } = false;
    /// <summary>Gets or sets a flag indicating if a user has two-factor authentication set up.</summary>
    /// <value><pre><b>True</b></pre> if the user has two-factor authentication set up,  <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false)]
    public virtual bool IsTwoFactorEnabled { get; set; } = false;
    /// <summary>Gets or sets a flag indicating whether the user has been locked out (either deliberately be an administrator or by exhausting the number of attempts allowed to authenticate.</summary>
    /// <value><pre>True</pre> if the user <b><i>is locked out</i></b> right now, <pre><b>false</b></pre> otherwise.</value>
    public virtual bool IsLockedOut => IsLockoutEnabled && LockoutEnd > Now;
    public override string? Email { get; set; }

    [JProp("username")]
    public override string? UserName { get; set; }

    public override string? PhoneNumber { get; set; }

    [Timestamp, JIgnore]
    public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }

    [JIgnore]
    public override string PasswordHash { get; set; } = "*** PASSWORD NOT SET ***";

    [JIgnore]
    public override string SecurityStamp { get; set; } = NewGuid().ToString();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
    public virtual ICollection<UserLogin> Logins { get; set; } = new List<UserLogin>();
    public virtual ICollection<UserToken> Tokens { get; set; } = new List<UserToken>();
    public virtual ICollection<UserClaim> Claims { get; set; } = new List<UserClaim>();
    IEnumerable<IRole> IUser.Roles => Roles;
    IEnumerable<IUserToken> IUser.Tokens => Tokens.OfType<IUserToken>();
    IEnumerable<IUserClaim> IUser.Claims => Claims.OfType<IUserClaim>();
    IEnumerable<IUserLogin> IUser.Logins => Logins.OfType<IUserLogin>();

    // [JsonIgnore]
    // public override string NormalizedEmail { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
    // [JsonIgnore]
    // public override string NormalizedUserName { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
    // [JsonIgnore, NotMapped]
    // public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
    // [JsonIgnore, NotMapped]
    // public override bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
    // [JsonIgnore, NotMapped]
    // public override bool LockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }
    // [JsonIgnore, NotMapped]
    // public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
}
