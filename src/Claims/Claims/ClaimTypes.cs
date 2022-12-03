/*
 * ClaimTypes.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace JustinWritescode.Identity.Claims;
using System.ComponentModel.DataAnnotations;
using SysSecCt = System.Security.Claims.ClaimTypes;
using SysSeVt = System.Security.Claims.ClaimValueTypes;

[GenerateEnumerationClass("ClaimTypes")]
public enum ClaimTypesEnum
{
    [Uri("http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor.")]
    [Display(Name = "Actor")]
    Actor,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.")]
    [Display(Name = "Anonymous")]
    Anonymous,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.")]
    [Display(Name = "Authentication")]
    Authentication,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.")]
    [Display(Name = "AuthenticationInstant")]
    AuthenticationInstant,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.")]
    [Display(Name = "AuthenticationMethod")]
    AuthenticationMethod,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.")]
    [Display(Name = "AuthorizationDecision")]
    AuthorizationDecision,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.")]
    [Display(Name = "CookiePath")]
    CookiePath,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.")]
    [Display(Name = "Country")]
    Country,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.")]
    [Display(Name = "DateOfBirth")]
    DateOfBirth,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object.")]
    [Display(Name = "DenyOnlyPrimaryGroupSid")]
    DenyOnlyPrimaryGroupSid,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object.")]
    [Display(Name = "DenyOnlyPrimarySid")]
    DenyOnlyPrimarySid,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object.")]
    [Display(Name = "DenyOnlySid")]
    DenyOnlySid,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.")]
    [Display(Name = "DenyOnlyWindowsDeviceGroup")]
    DenyOnlyWindowsDeviceGroup,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.")]
    [Display(Name = "Dns")]
    Dns,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.")]
    [Display(Name = "Dsa")]
    Dsa,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.")]
    [Display(Name = "Email")]
    Email,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.")]
    [Display(Name = "Expiration")]
    Expiration,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.")]
    [Display(Name = "Expired")]
    Expired,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.")]
    [Display(Name = "Gender")]
    Gender,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.")]
    [Display(Name = "GivenName")]
    GivenName,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.")]
    [Display(Name = "GroupSid")]
    GroupSid,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.")]
    [Display(Name = "Hash")]
    Hash,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.")]
    [Display(Name = "HomePhone")]
    HomePhone,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.")]
    [Display(Name = "IsPersistent")]
    IsPersistent,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.")]
    [Display(Name = "Locality")]
    Locality,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.")]
    [Display(Name = "MobilePhone")]
    MobilePhone,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.")]
    [Display(Name = "Name")]
    NameType,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.")]
    [Display(Name = "NameIdentifier")]
    NameIdentifier,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.")]
    [Display(Name = "OtherPhone")]
    OtherPhone,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.")]
    [Display(Name = "PostalCode")]
    PostalCode,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.")]
    [Display(Name = "PrimaryGroupSid")]
    PrimaryGroupSid,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.")]
    [Display(Name = "PrimarySid")]
    PrimarySid,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/role.")]
    [Display(Name = "Role")]
    Role,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.")]
    [Display(Name = "Rsa")]
    Rsa,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.")]
    [Display(Name = "SerialNumber")]
    SerialNumber,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.")]
    [Display(Name = "Sid")]
    Sid,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.")]
    [Display(Name = "Spn")]
    Spn,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.")]
    [Display(Name = "StateOrProvince")]
    StateOrProvince,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.")]
    [Display(Name = "StreetAddress")]
    StreetAddress,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.")]
    [Display(Name = "Surname")]
    Surname,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.")]
    [Display(Name = "System")]
    SystemType,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate.")]
    [Display(Name = "Thumbprint")]
    Thumbprint,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.")]
    [Display(Name = "Upn")]
    Upn,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.")]
    [Display(Name = "Uri")]
    Uri,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.")]
    [Display(Name = "UserData")]
    UserData,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/version.")]
    [Display(Name = "Version")]
    Version,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.")]
    [Display(Name = "Webpage")]
    Webpage,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.")]
    [Display(Name = "WindowsAccountName")]
    WindowsAccountName,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.")]
    [Display(Name = "WindowsDeviceClaim")]
    WindowsDeviceClaim,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.")]
    [Display(Name = "WindowsDeviceGroup")]
    WindowsDeviceGroup,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.")]
    [Display(Name = "WindowsFqbnVersion")]
    WindowsFqbnVersion,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.")]
    [Display(Name = "WindowsSubAuthority")]
    WindowsSubAuthority,

    [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.")]
    [Display(Name = "WindowsUserClaim")]
    WindowsUserClaim,

    [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.")]
    [Display(Name = "X500DistinguishedName")]
    X500DistinguishedName,

//         /// <summary>
// //         /// This is the base type for all Backroom claims.  <inheritdoc cref="Strings.BackroomBaseUriString"/>
// //         /// </summary>
// //         public static readonly ClaimType BackroomBaseClaimType = (Uris.BackroomBaseUri, "This is the Backroom root URI");
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.", DateTimeClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://backroom.app/identity/fakeUser.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://backroom.app/identity/fakeUser.", BooleanClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.", SidClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/role.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/role.", UriClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// //         /// <summary>
// //         /// The URI for a claim that specifies the \"common name\" of an entity, <inheritdoc cref="Strings.CommonNameClaimTypeString" />
// //         /// </summary>
// //         public static readonly ClaimType CommonNameClaimType = (Uris.CommonNameClaimTypeUri, "The URI for a claim that specifies the \"common name\" of an entity, " + Strings.CommonNameClaimTypeString, StringClaimValueType);
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.", EmailClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.", UriClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// //         /// <summary>
// //         /// <inheritdoc cref="NameIdentifierClaimType"/>
// //         /// </summary>
// //         public static readonly ClaimType UserIdClaimType = NameIdentifierClaimType;
// //         /// <summary>
// //         /// <inheritdoc cref="NameClaimType"/>
// //         /// </summary>
// //         public static readonly ClaimType UsernameClaimType = NameClaimType;
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage."")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.", UriClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.", PhoneNumberClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone."")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.", PhoneNumberClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.", PhoneNumberClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.", JsonClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.", JsonClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.", DateClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
// //         /// </summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.")]
// [Display(Name = "//         /// <summary>")]
// //         /// <summary>
// [Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.", StringClaimValueType);")]
// [Display(Name = "//         /// </summary>")]
//         /// </summary>

// #pragma warning disable CS1591
//         /// <summary><inheritdoc cref="AuthenticationInstantClaimType"/></summary>
//         public class AuthenticationInstantClaim : C { public AuthenticationInstantClaim(DateTime value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.AuthenticationInstant, value.ToString(), DateTimeClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="AuthenticationMethodClaimType"/></summary>
//         public class AuthenticationMethodClaim : C { public AuthenticationMethodClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.AuthenticationMethod, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="SidClaimType"/></summary>
//         public class SidClaim : C { public SidClaim(Guid value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Sid, value.ToString(), SidClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="NameClaimType"/></summary>
//         public class NameClaim : C { public NameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Name, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="RoleClaimType"/></summary>
//         public class RoleClaim : C { public RoleClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Role, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="CommonNameClaimType"/></summary>
//         public class CommonNameClaim : C { public CommonNameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(Strings.CommonNameClaimTypeString, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="EmailClaimType"/></summary>
//         public class EmailClaim : C { public EmailClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Email, value, EmailClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="GivenNameClaimType"/></summary>
//         public class GivenNameClaim : C { public GivenNameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.GivenName, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="SurnameClaimType"/></summary>
//         public class SurnameClaim : C { public SurnameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Surname, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="UriClaimType"/></summary>
//         public class UriClaim : C { public UriClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.uri, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="UserIdClaimType"/></summary>
// #if USE_INT32_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), Integer32ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_UINT32_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), UnsignedInteger32ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_INT64_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), Integer64ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_UINT64_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), UnsignedInteger64ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #endif
//         /// <summary><inheritdoc cref="WebpageClaimType"/></summary>
//         public class WebpageClaim : C { public WebpageClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Webpage, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="HomePhoneClaimType"/>, <inheritdoc cref="MobilePhoneClaimType"/>, or <inheritdoc cref="OtherPhoneClaimType"/></summary>
//         public class PhoneNumberClaim : C { public PhoneNumberClaim(string value, uri phoneNumberType = default, uri issuer = default, uri originalIssuer = default) : base((phoneNumberType ?? new uri(SysSecCt.HomePhone)).ToString(), value.ToString(), PhoneNumberClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="StateOrProvinceClaimType"/></summary>
//         public class StateOrProvinceClaim : Claim { public StateOrProvinceClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.StateOrProvince, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="PostalCodeClaimType"/></summary>
//         public class PostalCodeClaim : C { public PostalCodeClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.PostalCode, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="CountryClaimType"/></summary>
//         public class CountryClaim : C { public CountryClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Country, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="DateOfBirthClaimType" /> </summary>
//         public class DateOfBirthClaim : C { public DateOfBirthClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.DateOfBirth, value, DateClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref="AnonymousClaimType"/></summary>
//         public class AnonymousClaim : C { public AnonymousClaim() : base(SysSecCt.Anonymous, default, StringClaimValueType) { } }
}
