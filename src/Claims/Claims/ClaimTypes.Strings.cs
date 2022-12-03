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

namespace JustinWritesCode.Identity.Claims;
using NS = JustinWritesCode.Identity.Claims.ClaimTypes.Namespaces;
public static partial class ClaimTypes
{
    public static class Strings
    {
        /// <summary>The base URI for claims in the <inheritdoc cref="JustinWritesCodeBaseUriString" /> namespace</summary>
        /// <value>https://justinwritescode.com/</value>
        public const string JustinWritesCodeBaseUriString = "https://justinwritescode.com/";

        /// <summary>The base URI for claims in the <inheritdoc cref="JustinWritesCodeIdentityBaseUriString" /> namespace</summary>
        /// <value><inheritdoc cref="JustinWritesCodeBaseUriString" /><inheritdoc cref="NS.Identity" /></value>
        public const string JustinWritesCodeIdentityBaseUriString = JustinWritesCodeBaseUriString + NS.Identity;

        /// <summary>The base URI for claims in the <inheritdoc cref="SchemasXmlSoapUriBaseString" path="/value/node()" /> namespace.</summary>
        /// <value><c>http://schemas.xmlsoap.org/</c></value>
        public const string SchemasXmlSoapUriBaseString = "http://schemas.xmlsoap.org/";

        /// <summary>The base URI for identity claims.</summary>
        /// <value><inheritdoc cref="SchemasXmlSoapUriBaseString" path="/value/node()"/><inheritdoc cref="NS.Ws200505" path="/value/node()"/><inheritdoc cref="NS.Identity" path="/value/node()"/></value>
        public const string IdentityClaimBaseUriString = SchemasXmlSoapUriBaseString + NS.Ws200505 + NS.Identity;

        /// <summary>A URI for a claim type representing a user's "common name." <inheritdoc cref="IdentityClaimBaseUriString" path="/value/node()" /><inheritdoc cref="NS.CommonName"/></summary>
        /// <value><inheritdoc cref="IdentityClaimBaseUriString" path="/value/node()" /><inheritdoc cref="NS.CommonName"/></value>
        public const string CommonNameClaimTypeUriString = IdentityClaimBaseUriString + NS.Identity + NS.CommonName;

        /// <inheritdoc cref="System.Security.Claims.ClaimTypes.Actor" />
        public const string ActorClaimTypeUriString = System.Security.Claims.ClaimTypes.Actor;

        /// <summary>The URI for a claim that specifies the anonymous user;  <inheritdoc cref="AnonymousClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.</value>
        public const string AnonymousClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.";

        /// <summary>The URI for a claim that specifies details about whether an identity is authenticated,  <inheritdoc cref="AuthenticationClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.</value>
        public const string AuthenticationClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.";

        /// <summary>The URI for a claim that specifies the instant at which an entity was authenticated;  <inheritdoc cref="AuthenticationInstantClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.</value>
        public const string AuthenticationInstantClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.";

        /// <summary>The URI for a claim that specifies the method with which an entity was authenticated;  <inheritdoc cref="AuthenticationMethodClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.</value>
        public const string AuthenticationMethodClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.";

        /// <summary>The URI for a claim that specifies an authorization decision on an entity;  <inheritdoc cref="AuthorizationDecisionClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.</value>
        public const string AuthorizationDecisionClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.";

        /// <summary>The URI for a claim that specifies the cookie path;  <inheritdoc cref="CookiePathClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.</value>
        public const string CookiePathClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.";

        /// <summary>The URI for a claim that specifies the country/region in which an entity resides,  <inheritdoc cref="CountryClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.</value>
        public const string CountryClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.";

        /// <summary>The URI for a claim that specifies the date of birth of an entity,  <inheritdoc cref="DateOfBirthClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.</value>
        public const string DateOfBirthClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.";

        /// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity;  <inheritdoc cref="DenyOnlyPrimaryGroupSidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object.</value>
        public const string DenyOnlyPrimaryGroupSidClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object.";

        /// <summary>The URI for a claim that specifies the deny-only primary SID on an entity;  <inheritdoc cref="DenyOnlyPrimarySidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object.</value>
        public const string DenyOnlyPrimarySidClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object.";

        /// <summary>The URI for a claim that specifies a deny-only security identifier(SID) for an entity,  <inheritdoc cref="DenyOnlySidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object.</value>
        public const string DenyOnlySidClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object.";

        /// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device,  <inheritdoc cref="DenyOnlyWindowsDeviceGroupClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.</value>
        public const string DenyOnlyWindowsDeviceGroupClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.";

        /// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate,  <inheritdoc cref="DnsClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.</value>
        public const string DnsClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.";

        /// <summary> <inheritdoc cref="DsaClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</value>
        public const string DsaClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.";

        /// <summary>The URI for a claim that specifies the email address of an entity,  <inheritdoc cref="EmailClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.</value>
        public const string EmailClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.";

        /// <summary> <inheritdoc cref="ExpirationClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</value>
        public const string ExpirationClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.";

        /// <summary> <inheritdoc cref="ExpiredClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</value>
        public const string ExpiredClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.";

        /// <summary>The URI for a claim that specifies the gender of an entity,  <inheritdoc cref="GenderClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.</value>
        public const string GenderClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.";

        /// <summary>The URI for a claim that specifies the given name of an entity,  <inheritdoc cref="GivenNameClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.</value>
        public const string GivenNameClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.";

        /// <summary>The URI for a claim that specifies the SID for the group of an entity,  <inheritdoc cref="GroupSidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.</value>
        public const string GroupSidClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.";

        /// <summary>The URI for a claim that specifies a hash value,  <inheritdoc cref="HashClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.</value>
        public const string HashClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.";

        /// <summary>The URI for a claim that specifies the home phone number of an entity,  <inheritdoc cref="HomePhoneClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.</value>
        public const string HomePhoneClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.";

        /// <summary> <inheritdoc cref="IsPersistentClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</value>
        public const string IsPersistentClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.";

        /// <summary>The URI for a claim that specifies the locale in which an entity resides,  <inheritdoc cref="LocalityClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.</value>
        public const string LocalityClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.";

        /// <summary>The URI for a claim that specifies the mobile phone number of an entity,  <inheritdoc cref="MobilePhoneClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.</value>
        public const string MobilePhoneClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.";

        /// <summary>The URI for a claim that specifies the name of an entity,  <inheritdoc cref="NameClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.</value>
        public const string NameClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.";

        /// <summary>The URI for a claim that specifies the name of an entity,  <inheritdoc cref="NameIdentifierClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.</value>
        public const string NameIdentifierClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.";

        /// <summary>The URI for a claim that specifies the alternative phone number of an entity,  <inheritdoc cref="OtherPhoneClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.</value>
        public const string OtherPhoneClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.";

        /// <summary>The URI for a claim that specifies the postal code of an entity,  <inheritdoc cref="PostalCodeClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.</value>
        public const string PostalCodeClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.";

        /// <summary>The URI for a claim that specifies the primary group SID of an entity,  <inheritdoc cref="PrimaryGroupSidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.</value>
        public const string PrimaryGroupSidClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.";

        /// <summary>The URI for a claim that specifies the primary SID of an entity,  <inheritdoc cref="PrimarySidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.</value>
        public const string PrimarySidClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.";

        /// <summary>The URI for a claim that specifies the role of an entity,  <inheritdoc cref="RoleClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/role.</value>
        public const string RoleClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role.";

        /// <summary>The URI for a claim that specifies an RSA key,  <inheritdoc cref="RsaClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.</value>
        public const string RsaClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.";

        /// <summary>The URI for a claim that specifies a serial number,  <inheritdoc cref="SerialNumberClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.</value>
        public const string SerialNumberClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.";

        /// <summary>The URI for a claim that specifies a security identifier(SID),  <inheritdoc cref="SidClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.</value>
        public const string SidClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.";

        /// <summary>The URI for a claim that specifies a service principal name(SPN) claim,  <inheritdoc cref="SpnClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.</value>
        public const string SpnClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.";

        /// <summary>The URI for a claim that specifies the state or province in which an entity resides,  <inheritdoc cref="StateOrProvinceClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.</value>
        public const string StateOrProvinceClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.";

        /// <summary>The URI for a claim that specifies the street address of an entity,  <inheritdoc cref="StreetAddressClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.</value>
        public const string StreetAddressClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.";

        /// <summary>The URI for a claim that specifies the surname of an entity,  <inheritdoc cref="SurnameClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.</value>
        public const string SurnameClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.";

        /// <summary>The URI for a claim that identifies the system entity,  <inheritdoc cref="SystemClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.</value>
        public const string SystemClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.";

        /// <summary>The URI for a claim that specifies a thumbprint,  <inheritdoc cref="ThumbprintClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate.</value>
        public const string ThumbprintClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate.";

        /// <summary>The URI for a claim that specifies a user principal name(UPN),  <inheritdoc cref="UpnClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.</value>
        public const string UpnClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.";

        /// <summary>The URI for a claim that specifies a URI,  <inheritdoc cref="ClaimTypeUriClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.</value>
        public const string ClaimTypeUriClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.";

        /// <summary>The URI for a claim that specifies the user data,  <inheritdoc cref="UserDataClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.</value>
        public const string UserDataClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.";

        /// <summary>The URI for a claim that specifies the version,  <inheritdoc cref="VersionClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/version.</value>
        public const string VersionClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/version.";

        /// <summary>The URI for a claim that specifies the webpage of an entity,  <inheritdoc cref="WebpageClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.</value>
        public const string WebpageClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.";

        /// <summary>The URI for a claim that specifies the Windows domain account name of an entity,  <inheritdoc cref="WindowsAccountNameClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.</value>
        public const string WindowsAccountNameClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.";

        /// <summary> <inheritdoc cref="WindowsDeviceClaimClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</value>
        public const string WindowsDeviceClaimClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.";

        /// <summary>The URI for a claim that specifies the Windows group SID of the device,  <inheritdoc cref="WindowsDeviceGroupClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.</value>
        public const string WindowsDeviceGroupClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.";

        /// <summary> <inheritdoc cref="WindowsFqbnVersionClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</value>
        public const string WindowsFqbnVersionClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.";

        /// <summary> <inheritdoc cref="WindowsSubAuthorityClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</value>
        public const string WindowsSubAuthorityClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.";

        /// <summary> <inheritdoc cref="WindowsUserClaimClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</value>
        public const string WindowsUserClaimClaimTypeUriString = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.";

        /// <summary>The URI for an X.500 distinguished name claim, such as the subject of an X.509 Public Key Certificate or an entry identifier in a directory services Directory Information Tree;  <inheritdoc cref="X500DistinguishedNameClaimTypeUriString" path="/value/node()" /></summary>
        /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.</value>
        public const string X500DistinguishedNameClaimTypeUriString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.";
    }
}
