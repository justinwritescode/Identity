/*
 * IUserAssociatedEntity.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:05
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;
using JustinWritesCode.Abstractions;

namespace JustinWritesCode.Identity.Abstractions
{
    public interface IUserAssociatedEntity : IIdentifiable<int>
    {
        int UserId { get; set; }
    }
}
