/*
 * UserClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-03-01:07:46
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
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
    [Key, DbGen(DbGen.None), Hashids, Column(nameof(Id)), Required]
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

    /// <summary>The value of the claim</summary>
    /// <example>Justin</example>
    /// <remarks>See <see href="https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claim.value?view=net-7.0">Claim.Value</see> for more information.</remarks>
    /// <default />
    public string Value { get; set; } = string.Empty;
    /// <summary>The type of the claim</summary>
    /// <example>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name</example>
    /// <remarks>See <see href="https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claimtypes?view=net-7.0">ClaimTypes</see> for more information.</remarks>
    /// <default>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name</default>
    public uri? Type { get; set; } = JwcCt.Unknown;
    /// <summary>The issuer of the claim</summary>
    /// <example>https://justinwritescode.com</example>
    /// <remarks>See <see href="https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claim.issuer?view=net-7.0">Claim.Issuer</see> for more information.</remarks>
    /// <default>https://justinwritescode.com</default>
    public uri? Issuer { get; set; } = JwcCt.BaseUri;
    /// <summary>The type of the claim's value</summary>
    /// <example>http://www.w3.org/2001/XMLSchema#string</example>
    /// <remarks>See <see href="https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claimvaluetype?view=net-7.0">ClaimValueType</see> for more information.</remarks>
    /// <default>http://www.w3.org/2001/XMLSchema#string</default>
    public uri? ValueType { get; set; } = JwcCvt.String;
}
