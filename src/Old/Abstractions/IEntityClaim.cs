/*
 * IEntityClaim.cs
 *
 *   Created: 2022-11-13-03:32:35
 *   Modified: 2022-11-14-11:14:55
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;
public interface IEntityClaim : IIdentifiable<int>, IHaveAWritableId<int>
{
    long EntityId { get; set; }
    uri ValueType { get; set; }
    uri Type { get; set; }
    string Value { get; set; }
    uri Issuer { get; set; }
    uri OriginalIssuer { get; set; }

    IStringDictionary Properties { get; set; }
}
