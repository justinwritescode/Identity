/*
 * UserValidator.cs
 *
 *   Created: 2022-12-13-08:56:44
 *   Modified: 2022-12-13-08:56:44
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace JustinWritesCode.Identity;

public class UserValidator : UserValidator<User>
{
    public UserValidator(IdentityErrorDescriber? errors = null) : base(errors)
    {
    }
}
