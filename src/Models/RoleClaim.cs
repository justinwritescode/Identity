/*
 * RoleClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-05:35:10
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using JustinWritesCode.Abstractions;
using Microsoft.AspNetCore;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

[Table(tbl_RoleClaim, Schema = IdSchema), DebuggerDisplay("Role Claim ({Id} Role ID: {RoleId}, {Type}: {Value})")]
[JSerializable(typeof(RoleClaim))]
public class RoleClaim : IdentityRoleClaim<int>, IIdentifiable<int>//, IEntityClaim//, IHaveTimestamps
{
    [Key, DbGen(DbGenO.None), Column(nameof(Id), Order = 0, TypeName = DbTypeBigInt), Hashids]
    public override int Id { get; set; } //= NewId;

    [Hashids]
    public override int RoleId { get => base.RoleId; set => base.RoleId = value; }

    [JProp("value"), Column("value", TypeName = DbTypeNVarChar), Url, StringLength(1024), Required(AllowEmptyStrings = false, ErrorMessage = "A value must be specified.")]
    public override string? ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }

    [JProp("typeName"), Column("typeName"), StringLength(1024), Required(AllowEmptyStrings = false, ErrorMessage = "A claim type name must be specified.")]
    public override string? ClaimType { get => base.ClaimType; set => base.ClaimType = value; }

    [Column(nameof(Type), TypeName = DbTypeNVarChar), Url, StringLength(UriMaxLength), Required]
    public virtual uri? Type { get; set; } = System.uri.From(JwcCt.Unknown);

    [Column(nameof(ValueType), TypeName = DbTypeNVarChar), Url, StringLength(UriMaxLength), Required]
    public virtual uri? ValueType { get; set; } = System.uri.From(JwcCvt.Unknown);

    [Column(nameof(Issuer), TypeName = DbTypeNVarChar), Url, StringLength(UriMaxLength), Required]
    public virtual uri? Issuer { get; set; } = System.uri.From(JwcCt.BaseUri);

    [Column(nameof(OriginalIssuer), TypeName = DbTypeNVarChar), Url, StringLength(UriMaxLength), Required]
    public virtual uri? OriginalIssuer { get; set; } = System.uri.From(JwcCt.BaseUri);

    [Column(nameof(Properties), TypeName = DbTypeNVarChar), StringLength(UriMaxLength), XmlIgnore]
    public virtual IStringDictionary Properties { get; set; } = new StringDictionary();

    public virtual Role? Role { get; set; }

    // int IEntityClaim.EntityId { get => UserId; set => UserId = value; }

    public override void InitializeFromClaim(C claim)
    {
        base.InitializeFromClaim(claim);
        Type = claim.Type.CreateUri(JwcCt.GenericClaimTypePattern)!;
        ClaimValue = claim.Value;
        Issuer = claim.Issuer.CreateUri(JwcCt.GenericClaimsIssuerTypePattern)!;
        OriginalIssuer = claim.OriginalIssuer.CreateUri(JwcCt.GenericClaimsIssuerTypePattern)!;
        Properties = claim.Properties;
        ValueType = claim.ValueType.CreateUri(JwcCvt.GenericClaimTypePattern)!;
        RoleId = claim.Properties.ContainsKey(nameof(RoleId)) ? int.Parse(claim.Properties[nameof(RoleId)]) : default;
        Id = claim.Properties.ContainsKey(nameof(Id)) ? int.Parse(claim.Properties[nameof(Id)]) : default;
    }

    public override C ToClaim()
    {
        var claim = new C(Type.ToString(),
           ClaimValue,
           ValueType?.ToString(),
           Issuer.ToString(),
           OriginalIssuer.ToString());
        claim.Properties[nameof(RoleId)] = RoleId.ToString();
        claim.Properties[nameof(Id)] = Id.ToString();
        return claim;
    }

    public static RoleClaim FromClaim(int roleId, C c)
    {
        var userClaim = new RoleClaim();
        userClaim.InitializeFromClaim(c);
        userClaim.RoleId = roleId;
        return userClaim;
    }

    public static implicit operator C(RoleClaim claim) => claim.ToClaim();

    public static implicit operator RoleClaim(C claim)
    {
        var newClaim = new RoleClaim();
        newClaim.InitializeFromClaim(claim);
        return newClaim;
    }

    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public struct RoleClaimInsertDto
{
    public RoleClaimInsertDto() => Properties = new StringDictionary();

    [Required, Url, StringLength(UriMaxLength)]
    public Uri Type { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri ValueType { get; set; }

    [StringLength(256)]
    public string? Value { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri Issuer { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri OriginalIssuer { get; set; }

    [Required]
    public StringDictionary Properties { get; set; } = new StringDictionary();
}
