/*
 * IdentityResult.cs
 *
 *   Created: 2022-12-13-10:55:26
 *   Modified: 2022-12-13-10:55:26
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net;
using System.Xml.Serialization;
using JustinWritesCode.Payloads;
using Microsoft.AspNetCore.Identity;
using static System.Net.HttpStatusCode;
using HttpStatus = System.Net.HttpStatusCode;
using MSIDR = Microsoft.AspNetCore.Identity.IdentityResult;
using SC = System.Net.HttpStatusCode;

namespace JustinWritesCode.Identity;

public class IdentityResultTuple<TValue> : Tuple<MSIDR, TValue>
{
    public IdentityResultTuple(MSIDR msidr, TValue value) : base(msidr, value) { }
 }

public class IdentityResult : ResponsePayload<IdentityResultTuple<object>>
{
    public IdentityResult(MSIDR result, object? value = default, string? message = null, HttpStatus statusCode = SC.InternalServerError)
        : base(new IdentityResultTuple<object>(result, value), stringValue: value?.ToString() ?? message, message: message, statusCode: result != null && result.Succeeded ? OK : result != null ? statusCode! : throw new ArgumentNullException(nameof(result)))
    {
    }

    [JProp("result"), JIgnore(Condition = JIgnoreCond.WhenWritingNull), XmlAttribute("value")]
    public virtual MSIDR Result => base.Value.Item1;

    [JProp("value"), JIgnore(Condition = JIgnoreCond.WhenWritingNull), XmlAttribute("value")]
    public new virtual object Value => base.Value.Item2;

    public static IdentityResult Failed(HttpStatus statusCode = SC.InternalServerError, params IdentityError[] errors) => new(MSIDR.Failed(errors), statusCode: statusCode);
    public static IdentityResult Failed(HttpStatus statusCode = SC.InternalServerError, params string[] errors) => new(MSIDR.Failed(errors.Select(e => new IdentityError { Description = e }).ToArray()), statusCode: statusCode);
    public static IdentityResult Failed(IdentityError error, HttpStatus statusCode = SC.InternalServerError) => new(MSIDR.Failed(error), statusCode: statusCode);
    public static IdentityResult Failed(string error, HttpStatus statusCode = SC.InternalServerError) => new(MSIDR.Failed(new IdentityError { Description = error }), statusCode: statusCode);
    public static IdentityResult Failed(MSIDR result, HttpStatus statusCode = SC.InternalServerError) => new(result, statusCode: statusCode);
    public static IdentityResult Failed(HttpStatus statusCode = SC.InternalServerError) => new(MSIDR.Failed(), statusCode: statusCode);

    public static IdentityResult Success(string message = "Success", HttpStatus statusCode = OK) => new(MSIDR.Success, message: message, statusCode: statusCode);

    public static implicit operator IdentityResult(MSIDR result) => new(result);
    public static implicit operator MSIDR?(IdentityResult result) => result?.Result;
}

public class IdentityResult<TValue> : IdentityResult
{
    public IdentityResult(MSIDR result,TValue value, string? message = null, HttpStatus statusCode = SC.InternalServerError) : base(result, value, message, statusCode) { }
    public static implicit operator IdentityResult<TValue>(MSIDR result) => new(result, default);

    public new TValue Value => (TValue)base.Value;
}
