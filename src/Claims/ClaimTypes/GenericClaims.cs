/*
 * GenericUriStrings.cs
 *
 *   Created: 2022-12-17-07:06:21
 *   Modified: 2022-12-17-07:06:21
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;

public static partial class ClaimTypes
{
    /// <summary>The URI for an unknown user login provider</summary>
    /// <value>urn:users:login:provider:none</value>
    public const string UnknownLoginProvider = "urn:users:login:provider:none";

    /// <summary>The URI for a login provider</summary>
    /// <value>urn:users:login:provider:{provider}</value>
    public const string LoginProviderPattern = "urn:users:login:provider:{provider}";

    /// <summary>The URI for a security stamp</summary>
    /// <value>urn:identity:securitystamp</value>
    public const string SecurityStamp = "urn:identity:securitystamp";

    /// <summary>The URI for a generic claim type</summary>
    /// <value>urn:identity:claim:generic:{0}</value>
    public const string GenericClaimTypePattern = "urn:identity:claim:custom:{0}";

    /// <summary>The URI for a generic claims issuer</summary>
    /// <value>urn:identity:claim:issuer:generic:{0}</value>
    public const string GenericClaimsIssuerTypePattern = "urn:identity:claim:issuer:custom:{0}";

    /// <summary>The URI for a generic claims value type</summary>
    /// <value>urn:identity:claim:custom</value>
    public const string Custom = "urn:identity:claim:custom";

    /// <summary>The URI for a generic claims value type</summary>
    /// <value>urn:identity:claim:unknown</value>
    public const string Unknown = "urn:identity:claim:unknown";
}
