/*
 * IdentityResult.cs
 *
 *   Created: 2022-12-13-10:55:26
 *   Modified: 2022-12-13-10:55:26
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net;
using JustinWritesCode.Payloads;
using Microsoft.AspNetCore.Identity;
using static System.Net.HttpStatusCode;
using HttpStatus = System.Net.HttpStatusCode;
using MSIDR = Microsoft.AspNetCore.Identity.IdentityResult;

namespace JustinWritesCode.Identity;

public class IdentityResult : ResponsePayload<MSIDR>
{
    public IdentityResult(MSIDR result, object? value = null, string? message = null, HttpStatus statusCode = HttpStatus.BadRequest)
        : base(result, stringValue: value?.ToString() ?? message, message: message, statusCode: result.Succeeded ? OK : statusCode!)
    {
    }

    public static IdentityResult Failed(HttpStatus statusCode = HttpStatus.BadRequest, params MSIDR[] results) => new(MSIDR.Failed(results.Select(r => r.Errors).SelectMany(e => e).ToArray()), statusCode: statusCode);
    public static IdentityResult Failed(HttpStatus statusCode = HttpStatus.BadRequest, params IdentityError[] errors) => new(MSIDR.Failed(errors), statusCode: statusCode);
    public static IdentityResult Failed(HttpStatus statusCode = HttpStatus.BadRequest, params string[] errors) => new(MSIDR.Failed(errors.Select(e => new IdentityError { Description = e }).ToArray()), statusCode: statusCode);
    public static IdentityResult Failed(IdentityError error, HttpStatus statusCode = HttpStatus.BadRequest) => new(MSIDR.Failed(error), statusCode: statusCode);
    public static IdentityResult Failed(string error, HttpStatus statusCode = HttpStatus.BadRequest) => new(MSIDR.Failed(new IdentityError { Description = error }), statusCode: statusCode);
    public static IdentityResult Failed(MSIDR result, HttpStatus statusCode = HttpStatus.BadRequest) => new(result, statusCode: statusCode);
    public static IdentityResult Failed(HttpStatus statusCode = HttpStatus.BadRequest) => new(MSIDR.Failed(), statusCode: statusCode);

    public static IdentityResult Success => new(MSIDR.Success);

    public static implicit operator IdentityResult(MSIDR result) => new(result);
    public static implicit operator MSIDR(IdentityResult result) => result.Value;
}
