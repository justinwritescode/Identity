/*
 * ClaimTypes.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com"
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

#pragma warning disable
namespace JustinWritesCode.Identity;
using System.ComponentModel.DataAnnotations;
using SysSecCt = System.Security.Claims.ClaimTypes;
using SysSeVt = System.Security.Claims.ClaimValueTypes;

/// <summary>Defines constants for the well-known claim types that can be assigned to a subject. This class cannot be inherited.</summary>
/// <remarks>These constants define URIs for well-known claim types.</remarks>
public static partial class ClaimTypes
{
    /// <summary><The URI for a claim that specifies the actor></summary>
    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor/</value>
    public const string Actor ="http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor";


    /// <summary>The URI for a claim that specifies the anonymous user</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous</value>
    public const string Anonymous ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous";


    /// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.</value>
    public const string Authentication ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated";


    /// <summary>The URI for a claim that specifies the instant at which an entity was authenticated</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.</value>
    public const string AuthenticationInstant ="http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant";

    /// <summary>The URI for a claim that specifies the method with which an entity was authenticated</summary>
    ///
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.</value>
    public const string AuthenticationMethod ="http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod";


    /// <summary>The URI for a claim that specifies an authorization decision on an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision</value>
    public const string AuthorizationDecision ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision";



    /// <summary>The URI for a claim that specifies the cookie path</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath</value>
    public const string CookiePath ="http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath";



    /// <summary>The URI for a claim that specifies the country/region in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.</value>
    public const string Country ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country";



    /// <summary>The URI for a claim that specifies the date of birth of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.</value>
    public const string DateOfBirth ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth";



    /// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. </value>
    public const string DenyOnlyPrimaryGroupSid ="http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid.";


    /// <summary>The URI for a claim that specifies the deny-only primary SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid.</value>
    public const string DenyOnlyPrimarySid ="http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid";


    /// <summary>The URI for a claim that specifies a deny-only security identifier (SID) for an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denie</value>
    public const string DenyOnlySid ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid";


    /// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup</value>
    public const string DenyOnlyWindowsDeviceGroup ="http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegrou";


    /// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.</value>
    public const string Dns ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</value>
    public const string Dsa ="http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa";


    /// <summary>The URI for a claim that specifies the email address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.</value>
    public const string Email ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</value>
    public const string Expiration ="http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</value>
    public const string Expired ="http://schemas.microsoft.com/ws/2008/06/identity/claims/expired";


    /// <summary>The URI for a claim that specifies the gender of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender</value>
    public const string Gender ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender";


    /// <summary>The URI for a claim that specifies the given name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.</value>
    public const string GivenName ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname";


    /// <summary>The URI for a claim that specifies the SID for the group of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.</value>
    public const string GroupSid ="http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid";


    /// <summary>The URI for a claim that specifies a hash value</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/cl</value>
    public const string Hash ="http://schemas.xmlsoap.org/ws/2005/05/identity/c";


    /// <summary>The URI for a claim that specifies the home phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.</value>
    public const string HomePhone ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</value>
    public const string IsPersistent ="http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent";


    /// <summary>The URI for a claim that specifies the locale in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.</value>
    public const string Locality ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality";


    /// <summary>The URI for a claim that specifies the mobile phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.</value>
    public const string MobilePhone ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone";


    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name</value>
    public const string Name ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";


    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier</value>
    public const string NameIdentifier ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";


    /// <summary>The URI for a claim that specifies the alternative phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.</value>
    public const string OtherPhone ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone";


    /// <summary>The URI for a claim that specifies the postal code of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.</value>
    public const string PostalCode ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode";


    /// <summary>The URI for a claim that specifies the primary group SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid</value>
    public const string PrimaryGroupSid ="http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid";


    /// <summary>The URI for a claim that specifies the primary SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid</value>
    public const string PrimarySid ="http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid";


    /// <summary>The URI for a claim that specifies the role of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/role</value>
    public const string Role ="http://schemas.microsoft.com/ws/2008/06/identity/claims/role";


    /// <summary>The URI for a claim that specifies an RSA key</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/</value>
    public const string Rsa ="http://schemas.xmlsoap.org/ws/2005/05/identity";


    /// <summary>The URI for a claim that specifies a serial number</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber</value>
    public const string SerialNumber ="http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber";


    /// <summary>The URI for a claim that specifies a security identifier (SID)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.</value>
    public const string Sid ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid";


    /// <summary>The URI for a claim that specifies a service principal name (SPN) claim</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.</value>
    public const string Spn ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn";


    /// <summary>The URI for a claim that specifies the state or province in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.</value>
    public const string StateOrProvince ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince";


    /// <summary>The URI for a claim that specifies the street address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.</value>
    public const string StreetAddress ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress";


    /// <summary>The URI for a claim that specifies the surname of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname</value>
    public const string Surname ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname";


    /// <summary>The URI for a claim that identifies the system entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system</value>
    public const string System ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system";




    /// <summary>The URI for a claim that specifies a thumbprint</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint</value>
    public const string Thumbprint ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint";


    /// <summary>The URI for a claim that specifies a user principal name (UPN)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.</value>
    public const string Upn ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn";


    /// <summary>The URI for a claim that specifies a URI</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri</value>
    public const string Uri ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri";


    /// <summary>The URI for a claim that specifies the user data</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/userdatac</value>
    public const string UserData ="http://schemas.microsoft.com/ws/2008/06/identity/claims/userdatac";


    /// <summary>The URI for a claim that specifies the version</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/caims/version</value>
    public const string Version ="http://schemas.microsoft.com/ws/2008/06/identity/caims/version";


    /// <summary>The URI for a claim that specifies the webpage of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage</value>
    public const string Webpage ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage";


    /// <summary>The URI for a claim that specifies the Windows domain account name of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.</value>
    public const string WindowsAccountName ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</value>
    public const string WindowsDeviceClaim ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim";


    /// <summary>The URI for a claim that specifies the Windows group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup</value>
    public const string WindowsDeviceGroup ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</value>
    public const string WindowsFqbnVersion ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</value>
    public const string WindowsSubAuthority ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority";


    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</value>
    public const string WindowsUserClaim ="http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim";


    /// <summary>The URI for an X.500 distinguished name claim, such as the subject of an X.509 Public Key Certificate or an entry identifier in a directory services Directory Information Tree</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.</value>
    public const string X500DistinguishedName ="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname";
}

// [GenerateEnumerationClass"ClaimType")]
// public enum ClaimTypesEnum
// {
//     [Uri"http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor")]
//     [Display(Name ="Acto")]
//     Actor,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous")]
//     [Display(Name ="Anonymou")]
//     Anonymous,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated")]
//     [Display(Name ="Authenticatio")]
//     Authentication,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant")]
//     [Display(Name ="AuthenticationInstan")]
//     AuthenticationInstant,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod")]
//     [Display(Name ="AuthenticationMetho")]
//     AuthenticationMethod,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision")]
//     [Display(Name ="AuthorizationDecisio")]
//     AuthorizationDecision,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath")]
//     [Display(Name ="CookiePat")]
//     CookiePath,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country")]
//     [Display(Name ="Countr")]
//     Country,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth")]
//     [Display(Name ="DateOfBirt")]
//     DateOfBirth,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object")]
//     [Display(Name ="DenyOnlyPrimaryGroupSi")]
//     DenyOnlyPrimaryGroupSid,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object")]
//     [Display(Name ="DenyOnlyPrimarySi")]
//     DenyOnlyPrimarySid,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object")]
//     [Display(Name ="DenyOnlySi")]
//     DenyOnlySid,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup")]
//     [Display(Name ="DenyOnlyWindowsDeviceGrou")]
//     DenyOnlyWindowsDeviceGroup,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns")]
//     [Display(Name ="Dn")]
//     Dns,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa")]
//     [Display(Name ="Ds")]
//     Dsa,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")]
//     [Display(Name ="Emai")]
//     Email,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration")]
//     [Display(Name ="Expiratio")]
//     Expiration,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/expired")]
//     [Display(Name ="Expire")]
//     Expired,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender")]
//     [Display(Name ="Gende")]
//     Gender,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")]
//     [Display(Name ="GivenNam")]
//     GivenName,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid")]
//     [Display(Name ="GroupSi")]
//     GroupSid,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash")]
//     [Display(Name ="Has")]
//     Hash,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone")]
//     [Display(Name ="HomePhon")]
//     HomePhone,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent")]
//     [Display(Name ="IsPersisten")]
//     IsPersistent,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality")]
//     [Display(Name ="Localit")]
//     Locality,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone")]
//     [Display(Name ="MobilePhon")]
//     MobilePhone,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")]
//     [Display(Name ="Nam")]
//     NameType,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")]
//     [Display(Name ="NameIdentifie")]
//     NameIdentifier,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone")]
//     [Display(Name ="OtherPhon")]
//     OtherPhone,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode")]
//     [Display(Name ="PostalCod")]
//     PostalCode,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid")]
//     [Display(Name ="PrimaryGroupSi")]
//     PrimaryGroupSid,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid")]
//     [Display(Name ="PrimarySi")]
//     PrimarySid,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/role")]
//     [Display(Name ="Rol")]
//     Role,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa")]
//     [Display(Name ="Rs")]
//     Rsa,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber")]
//     [Display(Name ="SerialNumbe")]
//     SerialNumber,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid")]
//     [Display(Name ="Si")]
//     Sid,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn")]
//     [Display(Name ="Sp")]
//     Spn,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince")]
//     [Display(Name ="StateOrProvinc")]
//     StateOrProvince,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress")]
//     [Display(Name ="StreetAddres")]
//     StreetAddress,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")]
//     [Display(Name ="Surnam")]
//     Surname,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system")]
//     [Display(Name ="Syste")]
//     SystemType,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate")]
//     [Display(Name ="Thumbprin")]
//     Thumbprint,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn")]
//     [Display(Name ="Up")]
//     Upn,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri")]
//     [Display(Name ="Ur")]
//     Uri,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata")]
//     [Display(Name ="UserDat")]
//     UserData,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/version")]
//     [Display(Name ="Versio")]
//     Version,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage")]
//     [Display(Name ="Webpag")]
//     Webpage,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname")]
//     [Display(Name ="WindowsAccountNam")]
//     WindowsAccountName,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim")]
//     [Display(Name ="WindowsDeviceClai")]
//     WindowsDeviceClaim,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup")]
//     [Display(Name ="WindowsDeviceGrou")]
//     WindowsDeviceGroup,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion")]
//     [Display(Name ="WindowsFqbnVersio")]
//     WindowsFqbnVersion,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority")]
//     [Display(Name ="WindowsSubAuthorit")]
//     WindowsSubAuthority,

//     [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim")]
//     [Display(Name ="WindowsUserClai")]
//     WindowsUserClaim,

//     [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname")]
//     [Display(Name ="X500DistinguishedNam")]
//     X500DistinguishedName

//         /// <summary>
// //         /// This is the base type for all Backroom claims.  <inheritdoc cref"Strings.BackroomBaseUriStrin"/"
// //         /// </summary>
// //         public static readonly ClaimType BackroomBaseClaimType = (Uris.BackroomBaseUri,"This is the Backroom root UR");
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant", DateTimeClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://backroom.app/identity/fakeUser")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://backroom.app/identity/fakeUser", BooleanClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid", SidClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/role")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/role", UriClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// //         /// <summary>
// //         /// The URI for a claim that specifies the "common name" of an entity, <inheritdoc cref"Strings.CommonNameClaimTypeStrin" /"
// //         /// </summary>
// //         public static readonly ClaimType CommonNameClaimType = (Uris.CommonNameClaimTypeUri,"The URI for a claim that specifies the "common name" of an entity," + Strings.CommonNameClaimTypeString, StringClaimValueType);
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", EmailClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri", UriClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// //         /// <summary>
// //         /// <inheritdoc cref"NameIdentifierClaimTyp"/"
// //         /// </summary>
// //         public static readonly ClaimType UserIdClaimType = NameIdentifierClaimType;
// //         /// <summary>
// //         /// <inheritdoc cref"NameClaimTyp"/"
// //         /// </summary>
// //         public static readonly ClaimType UsernameClaimType = NameClaimType;
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage", UriClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone", PhoneNumberClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone", PhoneNumberClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone", PhoneNumberClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress", JsonClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata", JsonClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth", DateClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
// //         /// </summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous")]
// [Display(Name ="//         /// <summary>)]
// //         /// <summary>
// [Uri"http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous", StringClaimValueType);)]
// [Display(Name ="//         /// </summary>)]
//         /// </summary>

// #pragma warning disable CS1591
//         /// <summary><inheritdoc cref"AuthenticationInstantClaimTyp"/></summary>
//         public class AuthenticationInstantClaim : C { public AuthenticationInstantClaim(DateTime value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.AuthenticationInstant, value.ToString(), DateTimeClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"AuthenticationMethodClaimTyp"/></summary>
//         public class AuthenticationMethodClaim : C { public AuthenticationMethodClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.AuthenticationMethod, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"SidClaimTyp"/></summary>
//         public class SidClaim : C { public SidClaim(Guid value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Sid, value.ToString(), SidClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"NameClaimTyp"/></summary>
//         public class NameClaim : C { public NameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Name, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"RoleClaimTyp"/></summary>
//         public class RoleClaim : C { public RoleClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Role, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"CommonNameClaimTyp"/></summary>
//         public class CommonNameClaim : C { public CommonNameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(Strings.CommonNameClaimTypeString, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"EmailClaimTyp"/></summary>
//         public class EmailClaim : C { public EmailClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Email, value, EmailClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"GivenNameClaimTyp"/></summary>
//         public class GivenNameClaim : C { public GivenNameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.GivenName, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"SurnameClaimTyp"/></summary>
//         public class SurnameClaim : C { public SurnameClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Surname, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"UriClaimTyp"/></summary>
//         public class UriClaim : C { public UriClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.uri, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"UserIdClaimTyp"/></summary>
// #if USE_INT32_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), Integer32ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_UINT32_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), UnsignedInteger32ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_INT64_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), Integer64ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #elif USE_UINT64_FOR_IDS
//         public class UserIdClaim : C { public UserIdClaim(BackroomKey value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.NameIdentifier, value.ToString(), UnsignedInteger64ClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
// #endif
//         /// <summary><inheritdoc cref"WebpageClaimTyp"/></summary>
//         public class WebpageClaim : C { public WebpageClaim(uri value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Webpage, value.ToString(), UriClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"HomePhoneClaimTyp"/>, <inheritdoc cref"MobilePhoneClaimTyp"/>, or <inheritdoc cref"OtherPhoneClaimTyp"/></summary>
//         public class PhoneNumberClaim : C { public PhoneNumberClaim(string value, uri phoneNumberType = default, uri issuer = default, uri originalIssuer = default) : base((phoneNumberType ?? new uri(SysSecCt.HomePhone)).ToString(), value.ToString(), PhoneNumberClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"StateOrProvinceClaimTyp"/></summary>
//         public class StateOrProvinceClaim : Claim { public StateOrProvinceClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.StateOrProvince, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"PostalCodeClaimTyp"/></summary>
//         public class PostalCodeClaim : C { public PostalCodeClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.PostalCode, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"CountryClaimTyp"/></summary>
//         public class CountryClaim : C { public CountryClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.Country, value, StringClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"DateOfBirthClaimTyp" /> </summary>
//         public class DateOfBirthClaim : C { public DateOfBirthClaim(string value, uri issuer = default, uri originalIssuer = default) : base(SysSecCt.DateOfBirth, value, DateClaimValueType, issuer?.ToString(), originalIssuer?.ToString()) { } }
//         /// <summary><inheritdoc cref"AnonymousClaimTyp"/></summary>
//         public class AnonymousClaim : C { public AnonymousClaim() : base(SysSecCt.Anonymous, default, StringClaimValueType) { } }
// }
