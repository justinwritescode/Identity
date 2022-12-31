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


namespace JustinWritesCode.Identity;

public static partial class ClaimTypes {
    public static class Namespaces
    {
        /// <value><c>ws/2005/05/</c></value>
        public const string Ws200505 = "ws/2005/05/";

        /// <summary>identity/</summary>
        /// <value><c>identity/</c></value>
        public const string Identity = "identity/";

        /// <summary>commonName/</summary>
        /// <value><c>commonName/</c></value>
        public const string CommonName = "commonName/";
    }
}
