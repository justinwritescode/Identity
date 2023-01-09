/*
 * UserContactId.cs
 *
 *   Created: 2022-12-10-09:51:26
 *   Modified: 2022-12-10-09:51:27
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;
using System;
using JustinWritesCode.Identity.Abstractions;

/// <summary>A join entity between <see cref="Models.User" />s and <see cref="Models.Bot" />s</summary>
public record UserContactId : IUserContactId
{
    [Key, DbGen(DbGen.Identity)]
    public virtual int Id { get; set; }

    [Hashids]
    public virtual int UserId { get; set; }
    [Hashids]
    public virtual int BotId { get; set; }
    public virtual ObjectId ContactId { get; set; }

    public virtual Bot? Bot { get; set; }
    public virtual User? User { get; set; }
}

public record UserContactIdInsertDto
{
    /// <summary>Gets or sets the user identifier.</summary>
    [Hashids]
    public int UserId { get; set; }
    /// <summary>Gets or sets the bot's identifier.</summary>
    [Hashids]
    public int BotId { get; set; }
    /// <summary>Gets or sets the users <see cref="ObjectId" /> unique to that <see cref="Models.Bot" />.</summary>
    public ObjectId ContactId { get; set; }
}
