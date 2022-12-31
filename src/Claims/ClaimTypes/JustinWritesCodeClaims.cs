/*
 * JustinWritesCodeClaims.cs
 *
 *   Created: 2022-12-17-06:58:00
 *   Modified: 2022-12-17-06:58:00
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;
using NS = JustinWritesCode.Identity.ClaimTypes.Namespaces;

public static partial class ClaimTypes
{
    /// <summary>The base URI for claims in the <inheritdoc cref="BaseUri" /> namespace</summary>
    /// <value>https://justinwritescode.com/</value>
    public const string BaseUri = "https://justinwritescode.com/";

    /// <summary>The base URI for claims in the <inheritdoc cref="Identity" /> namespace</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="NS.Identity" /></value>
    public const string Identity = BaseUri + NS.Identity;
}
