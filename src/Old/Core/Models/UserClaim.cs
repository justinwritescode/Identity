namespace JustinWritesCode.Identity.Models;
using Abstractions;

[DebuggerDisplay("User Claim ({Id} - User ID: {UserId}, {Type}: {Value})")]
public class UserClaim : IdentityUserClaim<long>, IIdentifiable<int>, IEntityClaim, IUserAssociatedEntity
{
    public UserClaim() { }
    public UserClaim(C claim) { InitializeFromClaim(claim); }
    public UserClaim(long userId, Uri claimType, string claimValue, Uri? claimValueType = null, Uri? issuer = null, Uri? originalIssuer = null, IDictionary<string, string>? properties = null)
    {
        Properties = properties ?? new StringDictionary { { nameof(Id), "0" }, { nameof(UserId), userId.ToString() } };
        UserId = userId;
        Type = claimType;
        Value = claimValue;
        ValueType = claimValueType;
        Issuer = issuer ?? JustinWritesCode.Identity.Claims.ClaimTypes.Uris.JustinWritesCodeBaseUri;
        OriginalIssuer = originalIssuer ?? Issuer ?? JustinWritesCode.Identity.Claims.ClaimTypes.Uris.JustinWritesCodeBaseUri;
    }

    [Hashid, Required]
    public override int Id { get; set; }

    [Hashid, Required(AllowEmptyStrings = false, ErrorMessage = "User ID must be specified.")]
    public override long UserId { get; set; }

    public virtual User? User { get; set; }

    public virtual uri Type { get; set; }
    public virtual uri ValueType { get; set; }
    public virtual string? Value { get; set; }
    public virtual uri Issuer { get; set; }
    public virtual uri OriginalIssuer { get; set; }
    public virtual IStringDictionary Properties { get; set; } = new StringDictionary();
    long IEntityClaim.EntityId { get => UserId; set => UserId = value; }
    long IUserAssociatedEntity.UserId { get => UserId; set => UserId = value; }
    IUser? IUserAssociatedEntity.User { get => User; set => User = value as User; }
    // long IHaveAWritableId<int>.Id { get => Id; set => Id = value; }

    // long IIdentifiable<long>.Id => Id;
    public override void InitializeFromClaim(C claim)
    {
        base.InitializeFromClaim(claim);
        Type = claim.Type.ToUri()!;
        Value = claim.Value;
        Issuer = claim.Issuer.ToUri()!;
        OriginalIssuer = claim.OriginalIssuer.ToUri()!;
        Properties = claim.Properties;
        ValueType = claim.ValueType.ToUri()!;
        UserId = claim.Properties.ContainsKey(nameof(UserId)) ? int.Parse(claim.Properties[nameof(UserId)]) : default;
        Id = claim.Properties.ContainsKey(nameof(Id)) ? int.Parse(claim.Properties[nameof(Id)]) : default;
    }

    public virtual C ToClaim()
    {
        var claim = new C(Type.ToString(),
           Value,
           ValueType?.ToString(),
           Issuer.ToString(),
           OriginalIssuer.ToString());
        claim.Properties[nameof(UserId)] = UserId.ToString();
        claim.Properties[nameof(Id)] = Id.ToString();
        return claim;
    }

    public static UserClaim FromClaim(long userId, C c)
    {
        var backroomUserClaim = new UserClaim();
        backroomUserClaim.InitializeFromClaim(c);
        backroomUserClaim.UserId = userId;
        return backroomUserClaim;
    }

    public static implicit operator C(UserClaim claim) => claim.ToClaim();

    public static implicit operator UserClaim(C claim)
    {
        var backroomClaim = new UserClaim();
        backroomClaim.InitializeFromClaim(claim);
        return backroomClaim;
    }
}
