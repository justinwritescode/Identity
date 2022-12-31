namespace JustinWritesCode.Identity.Models;
using JustinWritesCode.Identity.Abstractions;
using IStringDictionary = IDictionary<string, string>;
using StringDictionary = Dictionary<string, string>;

[DebuggerDisplay("Role Claim ({Id} Role ID: {RoleId}, {Type}: {Value})")]
public class RoleClaim : IdentityRoleClaim<long>, IIdentifiable<long>, IEntityClaim//, IHaveTimestamps
{
    // private IStringDictionary _properties = new StringDictionary { { nameof(RoleId), null }, { ColId, NewId().ToString() } };

    [Hashid]
    public virtual new long Id { get; set; }

    public virtual uri Type { get => ClaimType.ToUri()!; set => ClaimType = value.ToString(); }

    public virtual uri ValueType { get; set; }

    public virtual string? Value { get => ClaimValue; set => ClaimValue = value; }

    public virtual uri Issuer { get; set; }

    public virtual uri OriginalIssuer { get; set; }

    public virtual IStringDictionary Properties { get; set; } = new StringDictionary();

    // [Column(nameof(Properties), Order = 7, TypeName = TNVarChar), StringLength(2048)]
    // public virtual string PropertiesJson { get; set; } = $"{{ {{ {nameof(RoleId)}: {default(Id)} }}, {{ {nameof(Id)}: {default(Id)} }} }}";

    long IEntityClaim.EntityId { get => RoleId; set => RoleId = value; }

    public override void InitializeFromClaim(Claim claim)
    {
        base.InitializeFromClaim(claim);
        Type = claim.Type.ToUri()!;
        Value = claim.Value;
        Issuer = claim.Issuer.ToUri()!;
        OriginalIssuer = claim.OriginalIssuer.ToUri()!;
        Properties = claim.Properties;
        ValueType = claim.ValueType.ToUri()!;
        RoleId = claim.Properties.ContainsKey(nameof(RoleId)) ? long.Parse(claim.Properties[nameof(RoleId)]) : default;
        Id = claim.Properties.ContainsKey(nameof(Id)) ? long.Parse(claim.Properties[nameof(Id)]) : default;
    }

    public override C ToClaim()
    {
        var claim = new C(
            Type.ToString(),
            Value,
            ValueType?.ToString(),
            Issuer.ToString(),
            OriginalIssuer.ToString());
        claim.Properties[nameof(RoleId)] = RoleId.ToString();
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

    //public static implicit operator UserClaim((Id, Uri, string, Uri, Uri, Uri) tuple)
    //    => (UserClaim)(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, new Dictionary<string, string>());

    public static implicit operator C(RoleClaim backroomClaim) => backroomClaim.ToClaim();

    public static implicit operator RoleClaim(C claim)
    {
        var backroomClaim = new RoleClaim();
        backroomClaim.InitializeFromClaim(claim);
        return backroomClaim;
    }


    [JsonIgnore, NotMapped]
    public override string? ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }

    [JsonIgnore, NotMapped]
    public override string? ClaimType { get => base.ClaimType; set => base.ClaimType = value; }
}
