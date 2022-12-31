/* 
 * IUserClaim.cs
 * 
 *   Created: 2022-12-23-06:21:08
 *   Modified: 2022-12-23-06:21:09
 * 
 *   Author: Justin Chase <justin@justinwritescode.com>
 *   
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;
using static JustinWritesCode.EntityFrameworkCore.Constants.DbTypeNames;
public interface IEntityClaim<TEntityClaimType>
    where TEntityClaimType : IEntityClaim<TEntityClaimType>
{
    int Id { get; set; }
    int EntityId { get; set; }
    string? ClaimValue { get; set; }
    string? ClaimType { get; set; }
    uri? Type { get; set; }
    uri? ValueType { get; set; }
    uri? Issuer { get; set; }
    uri? OriginalIssuer { get; set; }
    IStringDictionary Properties { get; set; }

    void InitializeFromClaim(C claim);
    C ToClaim();
}
