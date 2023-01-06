/*
 * PasswordValidator.cs
 *
 *   Created: 2022-12-13-09:01:57
 *   Modified: 2022-12-13-09:01:57
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace JustinWritesCode.Identity;

public class PasswordValidator : PasswordValidator<User>
{
    public PasswordValidator(JustinsErrorDescriber errors) : base(errors)
    {
    }
}
