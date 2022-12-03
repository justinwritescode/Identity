/*
 * RoleClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-05:35:10
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

// namespace Backroom.Identity.Models;
// using Abstractions;

// [Table(tbl_RoleClaim, Schema = IdSchema), DebuggerDisplay("Role Claim ({Id} Role ID: {RoleId}, {Type}: {Value})")]
// public class BackroomRoleClaim : IdentityRoleClaim<BackroomKey>, IHaveAnId<BackroomKey>, IEntityClaim//, IHaveTimestamps
// {
//     private IStringDictionary _properties = new StringDictionary { { nameof(RoleId), null }, { ColId, NewId().ToString() } };

//     [Key, DatabaseGenerated(DbGenO.None), Column(ColId, Order = 0, TypeName = TInt), Hashid]
//     public virtual new BackroomKey Id { get; set; } //= NewId;

//     [Column(ColClaimType), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri Type { get => ClaimType.ToUri()!; set => ClaimType = value.ToString(); }

//     [Column(ColValueType), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri ValueType { get => _valueType!.ToUri()!; set => _valueType = value?.ToString(); }
//     private string? _valueType = default;

//     [Column(ColClaimValue), StringLength(256)]
//     public virtual string? Value { get => ClaimValue; set => ClaimValue = value; }

//     [Column(nameof(Issuer), TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri Issuer { get => _issuer!.ToUri()!; set => _issuer = value?.ToString(); }
//     private string? _issuer = default;

//     [Column(nameof(OriginalIssuer), TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri OriginalIssuer { get => _originalIssuer!.ToUri()!; set => _originalIssuer = value?.ToString(); }
//     private string? _originalIssuer = default;

//     //[Column(nameof(Properties), TypeName = TypNvarchar), StringLength(4096)]
//     //public virtual IDictionary<string, string> Properties
//     //{
//     //    get => _properties ??= _properties ?? new Dictionary<string, string>();
//     //    set => _properties = new Dictionary<string, string>(value?.Where(kvp => !(_properties?.Keys.Contains(kvp.Key) ?? false)) ?? new Dictionary<string, string>());
//     //}

//     [/*Column(nameof(Properties),*/NotMapped/*, Order = 9, TypeName = TypNvarchar), StringLength(4096)*/]
//     public virtual IDictionary<string, string> Properties
//     {
//         get => new JsonStringDictionary<string, string>(() => PropertiesJson, json => PropertiesJson = json);
//         set => PropertiesJson = JsonSerializer.Serialize(value);
//     }

//     [Column(nameof(Properties), Order = 7, TypeName = TNVarChar), StringLength(2048)]
//     public virtual string PropertiesJson { get; set; } = $"{{ {{ {nameof(RoleId)}: {default(BackroomKey)} }}, {{ {nameof(Id)}: {default(BackroomKey)} }} }}";

//     BackroomKey IEntityClaim.EntityId { get => RoleId; set => RoleId = value; }

//     public override void InitializeFromClaim(Claim claim)
//     {
//         base.InitializeFromClaim(claim);
//         Type = claim.Type.ToUri()!;
//         Value = claim.Value;
//         Issuer = claim.Issuer.ToUri()!;
//         OriginalIssuer = claim.OriginalIssuer.ToUri()!;
//         Properties = claim.Properties;
//         ValueType = claim.ValueType.ToUri()!;
//         RoleId = claim.Properties.ContainsKey(nameof(RoleId)) ? BackroomKey.Parse(claim.Properties[nameof(RoleId)]) : default;
//         Id = claim.Properties.ContainsKey(nameof(Id)) ? BackroomKey.Parse(claim.Properties[nameof(Id)]) : NewId();
//     }

//     public override C ToClaim()
//     {
//         var claim = new C(Type.ToString(),
//            Value,
//            ValueType?.ToString(),
//            Issuer.ToString(),
//            OriginalIssuer.ToString());
//         claim.Properties[nameof(RoleId)] = RoleId.ToString();
//         claim.Properties[nameof(Id)] = Id.ToString();
//         return claim;
//     }

//     public static BackroomUserClaim FromClaim(BackroomKey userId, Claim c)
//     {
//         var backroomUserClaim = new BackroomUserClaim();
//         backroomUserClaim.InitializeFromClaim(c);
//         backroomUserClaim.UserId = userId;
//         return backroomUserClaim;
//     }

//     //public static implicit operator BackroomUserClaim((BackroomKey, Uri, string, Uri, Uri, Uri) tuple)
//     //    => (BackroomUserClaim)(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, new Dictionary<string, string>());

//     public static implicit operator C(BackroomRoleClaim backroomClaim) => backroomClaim.ToClaim();

//     public static implicit operator BackroomRoleClaim(C claim)
//     {
//         var backroomClaim = new BackroomRoleClaim();
//         backroomClaim.InitializeFromClaim(claim);
//         return backroomClaim;
//     }


//     [JsonIgnore, NotMapped]
//     public override string? ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }

//     [JsonIgnore, NotMapped]
//     public override string? ClaimType { get => base.ClaimType; set => base.ClaimType = value; }

//     //         public Timestamp Created { get; set; }
//     //         public Timestamp LastUpdated { get; set; }
//     //         public Timestamp? Deleted { get; set; }
// }
