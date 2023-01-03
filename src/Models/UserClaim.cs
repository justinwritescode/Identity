/*
 * UserClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-03-01:07:46
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using AutoMapper;
using JustinWritesCode.Abstractions;
using JustinWritesCode.Identity.Abstractions;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;
namespace JustinWritesCode.Identity.Models;
using JwcCt = JustinWritesCode.Identity.ClaimTypes;
using JwcCvt = JustinWritesCode.Identity.ClaimValueTypes;


[Table(tbl_UserClaim, Schema = IdSchema), DebuggerDisplay("User Claim ({Id} - User ID: {UserId}, {Type}: {Value})")]
[JSerializable(typeof(UserClaim))]
public class UserClaim : IdentityUserClaim<int>, IIdentifiable<int>//, IEntityClaim//, IUserAssociatedEntity//, IHaveTimestamps
{
    public UserClaim() { }
    public UserClaim(int userId, string claimTypeName, string claimValue, uri? claimType = null, uri? claimValueType = null, uri? issuer = null, uri? originalIssuer = null, IDictionary<string, string>? properties = null)
    {
        Properties = (properties ?? new StringDictionary()).Concat(new StringDictionary { [nameof(Id)] = default(int).ToString(), [nameof(UserId)] = UserId.ToString() }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        UserId = userId;
        Type = claimType ?? claimTypeName.CreateUri(JwcCt.GenericClaimTypePattern);
        ClaimValue = claimValue;
        ValueType = claimValueType ?? uri.From(JwcCvt.String);
        Issuer = issuer ?? uri.From(JwcCt.BaseUri);
        OriginalIssuer = originalIssuer ?? issuer ?? uri.From(JwcCt.BaseUri);
    }

    /// <summary>The ID of the claim</summary>
    [Key, DbGen(DbGenO.None), Hashids, Column(nameof(Id)), Required]
    public override int Id
    {
        get => this.Id = base.Id != default ? base.Id : Properties.TryGetValue(nameof(Id), out var id) ? int.Parse(id) : default;
        set => base.Id = int.Parse(Properties[nameof(Id)] = value.ToString());
    }

    /// <summary>The ID of the user who is getting the claim</summart>
    /// <example>12</example>
    [Column(nameof(UserId)), Hashids, Required(AllowEmptyStrings = false, ErrorMessage = "User ID must be specified.")]
    public override int UserId
    {
        get => UserId = base.UserId != default ? base.UserId : Properties.TryGetValue(nameof(UserId), out var userId) ? int.Parse(userId) : default;
        set => base.UserId = int.Parse(Properties[nameof(UserId)] = value.ToString());
    }

    // [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

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
        UserId = claim.Properties.ContainsKey(nameof(UserId)) ? int.Parse(claim.Properties[nameof(UserId)]) : default;
        Id = claim.Properties.ContainsKey(nameof(Id)) ? int.Parse(claim.Properties[nameof(Id)]) : default;
    }

    public override C ToClaim()
    {
        var claim = new C(Type.ToString(),
           ClaimValue,
           ValueType?.ToString(),
           Issuer.ToString(),
           OriginalIssuer.ToString());
        claim.Properties[nameof(UserId)] = UserId.ToString();
        claim.Properties[nameof(Id)] = Id.ToString();
        return claim;
    }

    public static UserClaim FromClaim(int userId, C c)
    {
        var userClaim = new UserClaim();
        userClaim.InitializeFromClaim(c);
        userClaim.UserId = userId;
        return userClaim;
    }

    public static implicit operator C(UserClaim claim) => claim.ToClaim();

    public static implicit operator UserClaim(C claim)
    {
        var newClaim = new UserClaim();
        newClaim.InitializeFromClaim(claim);
        return newClaim;
    }
}


public record struct ClaimCreateDto
{
    public ClaimCreateDto()
    {
        Type = JwcCt.Unknown;
        Issuer = JwcCt.BaseUri;
        ValueType = JwcCvt.Unknown;
        Value = string.Empty;
    }

    public string Value { get; set; }
    public uri? Type { get; set; }
    public uri? Issuer { get; set; }
    public uri? ValueType { get; set; }
}
