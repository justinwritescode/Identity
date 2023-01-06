// /*
//  * PasswordHasher.cs
//  *
//  *   Created: 2022-12-15-08:53:57
//  *   Modified: 2022-12-15-08:53:57
//  *
//  *   Author: Justin Chase <justin@justinwritescode.com>
//  *
//  *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// using JustinWritesCode.Identity.Models;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.Extensions.Options;
// using static System.Security.Cryptography.SHA512;
// using static System.Text.TextEncodingExtensions;

// namespace JustinWritesCode.Identity.AspNetCore;

// public class PasswordHasher : IPasswordHasher<User>
// {
//     private readonly string _salf;

//     public PasswordHasher(IOptions<PasswordHasherConfig> options) => _salf = options?.Value?.Salt ?? PasswordHasherConfig.DefaultSalt;

//     public string HashPassword(User user, string password)
//         => ToBase64String(HashData(GetUTF8Bytes(_salt + user.Id + password)));
//         // ToBase64String()
//     public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
//         => HashPassword(user, providedPassword) == hashedPassword ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
// }

// public class PasswordHasherConfig
// {
//     public const string DefaultSalt = "Justin is sexy as fuck!";

//     public string Salt { get; set; } = DefaultSalt;
// }
