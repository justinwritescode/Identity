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

public static partial class ClaimTypes
{
    public static class Uris
    {
        /// <inheritdoc cref="Strings.JustinWritesCodeBaseUriString" />
        public static readonly uri JustinWritesCodeBaseUri = new(Strings.JustinWritesCodeBaseUriString);

        /// <inheritdoc cref="Strings.JustinWritesCodeIdentityBaseUriString" />
        public static readonly uri JustinWritesCodeIdentityBaseUri = new(Strings.JustinWritesCodeIdentityBaseUriString);


        /// <summary>
        /// <inheritdoc cref="Strings.CommonNameClaimTypeUriString" />
        /// </summary>
        public static readonly uri CommonNameClaimTypeClaimTypeUri = new(Strings.CommonNameClaimTypeUriString);

        /// <inheritdoc cref="Strings.ActorClaimTypeUriString" />
        public static readonly uri ActorClaimTypeUri = new(Strings.ActorClaimTypeUriString);

        /// <inheritdoc cref="Strings.AnonymousClaimTypeUriString" />
        public static readonly uri AnonymousClaimTypeUri = new(Strings.AnonymousClaimTypeUriString);

        /// <inheritdoc cref="Strings.AuthenticationClaimTypeUriString" />
        public static readonly uri AuthenticationClaimTypeUri = new(Strings.AuthenticationClaimTypeUriString);

        /// <inheritdoc cref="Strings.AuthenticationInstantClaimTypeUriString" />
        public static readonly uri AuthenticationInstantClaimTypeUri = new(Strings.AuthenticationInstantClaimTypeUriString);

        /// <inheritdoc cref="Strings.AuthenticationMethodClaimTypeUriString" />
        public static readonly uri AuthenticationMethodClaimTypeUri = new(Strings.AuthenticationMethodClaimTypeUriString);

        /// <inheritdoc cref="Strings.AuthorizationDecisionClaimTypeUriString" />
        public static readonly uri AuthorizationDecisionClaimTypeUri = new(Strings.AuthorizationDecisionClaimTypeUriString);

        /// <inheritdoc cref="Strings.CookiePathClaimTypeUriString" />
        public static readonly uri CookiePathClaimTypeUri = new(Strings.CookiePathClaimTypeUriString);

        /// <inheritdoc cref="Strings.CountryClaimTypeUriString" />
        public static readonly uri CountryClaimTypeUri = new(Strings.CountryClaimTypeUriString);

        /// <inheritdoc cref="Strings.DateOfBirthClaimTypeUriString" />
        public static readonly uri DateOfBirthClaimTypeUri = new(Strings.DateOfBirthClaimTypeUriString);

        /// <inheritdoc cref="Strings.DenyOnlyPrimaryGroupSidClaimTypeUriString" />
        public static readonly uri DenyOnlyPrimaryGroupSidClaimTypeUri = new(Strings.DenyOnlyPrimaryGroupSidClaimTypeUriString);

        /// <inheritdoc cref="Strings.DenyOnlyPrimarySidClaimTypeUriString" />
        public static readonly uri DenyOnlyPrimarySidClaimTypeUri = new(Strings.DenyOnlyPrimarySidClaimTypeUriString);

        /// <inheritdoc cref="Strings.DenyOnlySidClaimTypeUriString" />
        public static readonly uri DenyOnlySidClaimTypeUri = new(Strings.DenyOnlySidClaimTypeUriString);

        /// <inheritdoc cref="Strings.DenyOnlyWindowsDeviceGroupClaimTypeUriString" />
        public static readonly uri DenyOnlyWindowsDeviceGroupClaimTypeUri = new(Strings.DenyOnlyWindowsDeviceGroupClaimTypeUriString);

        /// <inheritdoc cref="Strings.DnsClaimTypeUriString" />
        public static readonly uri DnsClaimTypeUri = new(Strings.DnsClaimTypeUriString);

        /// <inheritdoc cref="Strings.DsaClaimTypeUriString" />
        public static readonly uri DsaClaimTypeUri = new(Strings.DsaClaimTypeUriString);

        /// <inheritdoc cref="Strings.EmailClaimTypeUriString" />
        public static readonly uri EmailClaimTypeUri = new(Strings.EmailClaimTypeUriString);

        /// <inheritdoc cref="Strings.ExpirationClaimTypeUriString" />
        public static readonly uri ExpirationClaimTypeUri = new(Strings.ExpirationClaimTypeUriString);

        /// <inheritdoc cref="Strings.ExpiredClaimTypeUriString" />
        public static readonly uri ExpiredClaimTypeUri = new(Strings.ExpiredClaimTypeUriString);

        /// <inheritdoc cref="Strings.GenderClaimTypeUriString" />
        public static readonly uri GenderClaimTypeUri = new(Strings.GenderClaimTypeUriString);

        /// <inheritdoc cref="Strings.GivenNameClaimTypeUriString" />
        public static readonly uri GivenNameClaimTypeUri = new(Strings.GivenNameClaimTypeUriString);

        /// <inheritdoc cref="Strings.GroupSidClaimTypeUriString" />
        public static readonly uri GroupSidClaimTypeUri = new(Strings.GroupSidClaimTypeUriString);

        /// <inheritdoc cref="Strings.HashClaimTypeUriString" />
        public static readonly uri HashClaimTypeUri = new(Strings.HashClaimTypeUriString);

        /// <inheritdoc cref="Strings.HomePhoneClaimTypeUriString" />
        public static readonly uri HomePhoneClaimTypeUri = new(Strings.HomePhoneClaimTypeUriString);

        /// <inheritdoc cref="Strings.IsPersistentClaimTypeUriString" />
        public static readonly uri IsPersistentClaimTypeUri = new(Strings.IsPersistentClaimTypeUriString);

        /// <inheritdoc cref="Strings.LocalityClaimTypeUriString" />
        public static readonly uri LocalityClaimTypeUri = new(Strings.LocalityClaimTypeUriString);

        /// <inheritdoc cref="Strings.MobilePhoneClaimTypeUriString" />
        public static readonly uri MobilePhoneClaimTypeUri = new(Strings.MobilePhoneClaimTypeUriString);

        /// <inheritdoc cref="Strings.NameClaimTypeUriString" />
        public static readonly uri NameClaimTypeUri = new(Strings.NameClaimTypeUriString);

        /// <inheritdoc cref="Strings.NameIdentifierClaimTypeUriString" />
        public static readonly uri NameIdentifierClaimTypeUri = new(Strings.NameIdentifierClaimTypeUriString);

        /// <inheritdoc cref="Strings.OtherPhoneClaimTypeUriString" />
        public static readonly uri OtherPhoneClaimTypeUri = new(Strings.OtherPhoneClaimTypeUriString);

        /// <inheritdoc cref="Strings.PostalCodeClaimTypeUriString" />
        public static readonly uri PostalCodeClaimTypeUri = new(Strings.PostalCodeClaimTypeUriString);

        /// <inheritdoc cref="Strings.PrimaryGroupSidClaimTypeUriString" />
        public static readonly uri PrimaryGroupSidClaimTypeUri = new(Strings.PrimaryGroupSidClaimTypeUriString);

        /// <inheritdoc cref="Strings.PrimarySidClaimTypeUriString" />
        public static readonly uri PrimarySidClaimTypeUri = new(Strings.PrimarySidClaimTypeUriString);

        /// <inheritdoc cref="Strings.RoleClaimTypeUriString" />
        public static readonly uri RoleClaimTypeUri = new(Strings.RoleClaimTypeUriString);

        /// <inheritdoc cref="Strings.RsaClaimTypeUriString" />
        public static readonly uri RsaClaimTypeUri = new(Strings.RsaClaimTypeUriString);

        /// <inheritdoc cref="Strings.SerialNumberClaimTypeUriString" />
        public static readonly uri SerialNumberClaimTypeUri = new(Strings.SerialNumberClaimTypeUriString);

        /// <inheritdoc cref="Strings.SidClaimTypeUriString" />
        public static readonly uri SidClaimTypeUri = new(Strings.SidClaimTypeUriString);

        /// <inheritdoc cref="Strings.SpnClaimTypeUriString" />
        public static readonly uri SpnClaimTypeUri = new(Strings.SpnClaimTypeUriString);

        /// <inheritdoc cref="Strings.StateOrProvinceClaimTypeUriString" />
        public static readonly uri StateOrProvinceClaimTypeUri = new(Strings.StateOrProvinceClaimTypeUriString);

        /// <inheritdoc cref="Strings.StreetAddressClaimTypeUriString" />
        public static readonly uri StreetAddressClaimTypeUri = new(Strings.StreetAddressClaimTypeUriString);

        /// <inheritdoc cref="Strings.SurnameClaimTypeUriString" />
        public static readonly uri SurnameClaimTypeUri = new(Strings.SurnameClaimTypeUriString);

        /// <inheritdoc cref="Strings.SystemClaimTypeUriString" />
        public static readonly uri SystemClaimTypeUri = new(Strings.SystemClaimTypeUriString);

        /// <inheritdoc cref="Strings.ThumbprintClaimTypeUriString" />
        public static readonly uri ThumbprintClaimTypeUri = new(Strings.ThumbprintClaimTypeUriString);

        /// <inheritdoc cref="Strings.UpnClaimTypeUriString" />
        public static readonly uri UpnClaimTypeUri = new(Strings.UpnClaimTypeUriString);

        /// <inheritdoc cref="Strings.ClaimTypeUriClaimTypeUriString" />
        public static readonly uri ClaimTypeUriClaimTypeUri = new(Strings.ClaimTypeUriClaimTypeUriString);

        /// <inheritdoc cref="Strings.UserDataClaimTypeUriString" />
        public static readonly uri UserDataClaimTypeUri = new(Strings.UserDataClaimTypeUriString);

        /// <inheritdoc cref="Strings.VersionClaimTypeUriString" />
        public static readonly uri VersionClaimTypeUri = new(Strings.VersionClaimTypeUriString);

        /// <inheritdoc cref="Strings.WebpageClaimTypeUriString" />
        public static readonly uri WebpageClaimTypeUri = new(Strings.WebpageClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsAccountNameClaimTypeUriString" />
        public static readonly uri WindowsAccountNameClaimTypeUri = new(Strings.WindowsAccountNameClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsDeviceClaimClaimTypeUriString" />
        public static readonly uri WindowsDeviceClaimClaimTypeUri = new(Strings.WindowsDeviceClaimClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsDeviceGroupClaimTypeUriString" />
        public static readonly uri WindowsDeviceGroupClaimTypeUri = new(Strings.WindowsDeviceGroupClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsFqbnVersionClaimTypeUriString" />
        public static readonly uri WindowsFqbnVersionClaimTypeUri = new(Strings.WindowsFqbnVersionClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsSubAuthorityClaimTypeUriString" />
        public static readonly uri WindowsSubAuthorityClaimTypeUri = new(Strings.WindowsSubAuthorityClaimTypeUriString);

        /// <inheritdoc cref="Strings.WindowsUserClaimClaimTypeUriString" />
        public static readonly uri WindowsUserClaimClaimTypeUri = new(Strings.WindowsUserClaimClaimTypeUriString);

        /// <inheritdoc cref="Strings.X500DistinguishedNameClaimTypeUriString" />
        public static readonly uri X500DistinguishedNameClaimTypeUri = new(Strings.X500DistinguishedNameClaimTypeUriString);
    }
}
