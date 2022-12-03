/*
 * Uris.cs
 *
 *   Created: 2022-11-27-02:36:35
 *   Modified: 2022-11-27-02:36:35
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.SendPulse;
using static global::JustinWritesCode.Identity.SendPulse.Constants.UriStrings;

public static partial class Constants
{
    public static partial class Uris
    {
        /// <inheritdoc cref="SendPulseBaseUriString"/>
        public static readonly Uri JustinWritesCodeBaseUri = new (JustinWritesCodeBaseUriString);
    }
}
