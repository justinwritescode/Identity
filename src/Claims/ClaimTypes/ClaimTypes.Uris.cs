/*
 * ClaimTypes.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org" licenses" MIT)
 */
 #pragma warning disable
 namespace JustinWritesCode.Identity;

public static partial class ClaimTypes
{

    /// <inheritdoc cref="ClaimTypes" />
    public static class Uris
    {
        /// <inheritdoc cref="ClaimTypes.UnknownLoginProvider" />
        public static readonly uri UnknownLoginProviderUri = uri.From(ClaimTypes.UnknownLoginProvider);
        /// <inheritdoc cref="ClaimTypes.SecurityStamp" />
        public static readonly uri SecurityStampUri = uri.From(ClaimTypes.SecurityStamp);
        /// <inheritdoc cref="ClaimTypes.BaseUri" />
        public static readonly uri JustinWritesCodeBaseUri = uri.From(ClaimTypes.BaseUri);
        /// <inheritdoc cref="ClaimTypes.Identity" />
        public static readonly uri JustinWritesCodeIdentityBaseUri = uri.From(ClaimTypes.Identity);
        /// <inheritdoc cref="ClaimTypes.Actor" path="/summary/node()" />
        public static readonly uri Actor = uri.From(ClaimTypes.Actor);
        /// <inheritdoc cref="ClaimTypes.Anonymous" >
        public static readonly uri Anonymous = uri.From(ClaimTypes.Anonymous);
        /// <inheritdoc cref="ClaimTypes.Authentication" />

        public static readonly uri Authentication = uri.From(ClaimTypes.Authentication);
        /// <inheritdoc cref="ClaimTypes.AuthenticationInstant" />

        public static readonly uri AuthenticationInstant = uri.From(ClaimTypes.AuthenticationInstant);
        /// <inheritdoc cref="ClaimTypes.AuthenticationMethod" />

        public static readonly uri AuthenticationMethod = uri.From(ClaimTypes.AuthenticationMethod);
        /// <inheritdoc cref="ClaimTypes.AuthorizationDecision" />

        public static readonly uri AuthorizationDecision = uri.From(ClaimTypes.AuthorizationDecision);
        /// <inheritdoc cref="ClaimTypes.CookiePath" />

        public static readonly uri CookiePath = uri.From(ClaimTypes.CookiePath);
        /// <inheritdoc cref="ClaimTypes.Country" />

        public static readonly uri Country = uri.From(ClaimTypes.Country);
        /// <inheritdoc cref="ClaimTypes.DateOfBirth" />

        public static readonly uri DateOfBirth = uri.From(ClaimTypes.DateOfBirth);
        /// <inheritdoc cref="ClaimTypes.DenyOnlyPrimaryGroupSid" />

        public static readonly uri DenyOnlyPrimaryGroupSid = uri.From(ClaimTypes.DenyOnlyPrimaryGroupSid);
        /// <inheritdoc cref="ClaimTypes.DenyOnlyPrimarySid" />

        public static readonly uri DenyOnlyPrimarySid = uri.From(ClaimTypes.DenyOnlyPrimarySid);
        /// <inheritdoc cref="ClaimTypes.DenyOnlySid" />

        public static readonly uri DenyOnlySid = uri.From(ClaimTypes.DenyOnlySid);
        /// <inheritdoc cref="ClaimTypes.DenyOnlyWindowsDeviceGroup" />

        public static readonly uri DenyOnlyWindowsDeviceGroup = uri.From(ClaimTypes.DenyOnlyWindowsDeviceGroup);
        /// <inheritdoc cref="ClaimTypes.Dns" />

        public static readonly uri Dns = uri.From(ClaimTypes.Dns);
        /// <inheritdoc cref="ClaimTypes.Dsa" />

        public static readonly uri Dsa = uri.From(ClaimTypes.Dsa);
        /// <inheritdoc cref="ClaimTypes.Email" />

        public static readonly uri Email = uri.From(ClaimTypes.Email);
        /// <inheritdoc cref="ClaimTypes.Expiration" />

        public static readonly uri Expiration = uri.From(ClaimTypes.Expiration);
        /// <inheritdoc cref="ClaimTypes.Expired" />
        public static readonly uri Expired = uri.From(ClaimTypes.Expired);
        /// <inheritdoc cref="ClaimTypes.Gender" />

        public static readonly uri Gender = uri.From(ClaimTypes.Gender);
        /// <inheritdoc cref="ClaimTypes.GivenName" />

        public static readonly uri GivenName = uri.From(ClaimTypes.GivenName);
        /// <inheritdoc cref="ClaimTypes.GroupSid" />

        public static readonly uri GroupSid = uri.From(ClaimTypes.GroupSid);
        /// <inheritdoc cref="ClaimTypes.Hash" />

        public static readonly uri Hash = uri.From(ClaimTypes.Hash);
        /// <inheritdoc cref="ClaimTypes.HomePhone" />

        public static readonly uri HomePhone = uri.From(ClaimTypes.HomePhone);
        /// <inheritdoc cref="ClaimTypes.IsPersistent" />

        public static readonly uri IsPersistent = uri.From(ClaimTypes.IsPersistent);
        /// <inheritdoc cref="ClaimTypes.Locality" />

        public static readonly uri Locality = uri.From(ClaimTypes.Locality);
        /// <inheritdoc cref="ClaimTypes.MobilePhone" />

        public static readonly uri MobilePhone = uri.From(ClaimTypes.MobilePhone);
        /// <inheritdoc cref="ClaimTypes.Name" />

        public static readonly uri Name = uri.From(ClaimTypes.Name);
        /// <inheritdoc cref="ClaimTypes.NameIdentifier" />

        public static readonly uri NameIdentifier = uri.From(ClaimTypes.NameIdentifier);
        /// <inheritdoc cref="ClaimTypes.OtherPhone" />

        public static readonly uri OtherPhone = uri.From(ClaimTypes.OtherPhone);
        /// <inheritdoc cref="ClaimTypes.PostalCode" />

        public static readonly uri PostalCode = uri.From(ClaimTypes.PostalCode);
        /// <inheritdoc cref="ClaimTypes.PrimaryGroupSid" />

        public static readonly uri PrimaryGroupSid = uri.From(ClaimTypes.PrimaryGroupSid);
        /// <inheritdoc cref="ClaimTypes.PrimarySid" />

        public static readonly uri PrimarySid = uri.From(ClaimTypes.PrimarySid);
        /// <inheritdoc cref="ClaimTypes.Role" />

        public static readonly uri Role = uri.From(ClaimTypes.Role);
        /// <inheritdoc cref="ClaimTypes.Rsa" />

        public static readonly uri Rsa = uri.From(ClaimTypes.Rsa);
        /// <inheritdoc cref="ClaimTypes.SerialNumber" />

        public static readonly uri SerialNumber = uri.From(ClaimTypes.SerialNumber);
        /// <inheritdoc cref="ClaimTypes.Sid" />

        public static readonly uri Sid = uri.From(ClaimTypes.Sid);
        /// <inheritdoc cref="ClaimTypes.Spn" />

        public static readonly uri Spn = uri.From(ClaimTypes.Spn);
        /// <inheritdoc cref="ClaimTypes.StateOrProvince" />

        public static readonly uri StateOrProvince = uri.From(ClaimTypes.StateOrProvince);
        /// <inheritdoc cref="ClaimTypes.StreetAddress" />

        public static readonly uri StreetAddress = uri.From(ClaimTypes.StreetAddress);
        /// <inheritdoc cref="ClaimTypes.Surname" />

        public static readonly uri Surname = uri.From(ClaimTypes.Surname);
        /// <inheritdoc cref="ClaimTypes.System" />

        public static readonly uri System = uri.From(ClaimTypes.System);
        /// <inheritdoc cref="ClaimTypes.Thumbprint" />

        public static readonly uri Thumbprint = uri.From(ClaimTypes.Thumbprint);
        /// <inheritdoc cref="ClaimTypes.Upn" />

        public static readonly uri Upn = uri.From(ClaimTypes.Upn);
        /// <inheritdoc cref="ClaimTypes.uri" />

        public static readonly uri uri = uri.From(ClaimTypes.Uri);
        /// <inheritdoc cref="ClaimTypes.UserData" />

        public static readonly uri UserData = uri.From(ClaimTypes.UserData);
        /// <inheritdoc cref="ClaimTypes.Version" />

        public static readonly uri Version = uri.From(ClaimTypes.Version);
        /// <inheritdoc cref="ClaimTypes.Webpage" />

        public static readonly uri Webpage = uri.From(ClaimTypes.Webpage);
        /// <inheritdoc cref="ClaimTypes.WindowsAccountName" />

        public static readonly uri WindowsAccountName = uri.From(ClaimTypes.WindowsAccountName);
        /// <inheritdoc cref="ClaimTypes.WindowsDeviceClaim" />

        public static readonly uri WindowsDeviceClaim = uri.From(ClaimTypes.WindowsDeviceClaim);
        /// <inheritdoc cref="ClaimTypes.WindowsDeviceGroup" />

        public static readonly uri WindowsDeviceGroup = uri.From(ClaimTypes.WindowsDeviceGroup);
        /// <inheritdoc cref="ClaimTypes.WindowsFqbnVersion" />

        public static readonly uri WindowsFqbnVersion = uri.From(ClaimTypes.WindowsFqbnVersion);
        /// <inheritdoc cref="ClaimTypes.WindowsSubAuthority" />

        public static readonly uri WindowsSubAuthority = uri.From(ClaimTypes.WindowsSubAuthority);
        /// <inheritdoc cref="ClaimTypes.WindowsUserClaim" />

        public static readonly uri WindowsUserClaim = uri.From(ClaimTypes.WindowsUserClaim);
        /// <inheritdoc cref="ClaimTypes.X500DistinguishedName" />

        public static readonly uri X500DistinguishedName = uri.From(ClaimTypes.X500DistinguishedName);
    }
}
