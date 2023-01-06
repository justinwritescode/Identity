/*
 * Bot.cs
 *
 *   Created: 2022-12-03-07:51:18
 *   Modified: 2022-12-03-07:51:18
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;
using System.Collections.ObjectModel;
using global::Telegram.Bot.Types;
using JustinWritesCode.Identity.Abstractions;


[Table("tbl_" + nameof(Bot))]
[JSerializable(typeof(Bot))]
public class Bot //: IBot
{
    [Hashids]
    public int Id { get; set; }
    public long TelegramId { get; set; }
    public string TelegramUsername { get; set; } = default!;
    public string Name { get; set; } = default!;
    public ObjectId SendPulseId { get; set; } = ObjectId.Empty;
    public BotApiToken ApiToken { get; set; } = BotApiToken.Empty;

    public virtual Collection<User> Contacts { get; set; } = new Collection<User>();

    public virtual Collection<UserContactId> ContactIds { get; set; } = new Collection<UserContactId>();
}

public record struct BotDto
{
    public long TelegramId { get; set; }
    public string TelegramUsername { get; set; }
    public string Name { get; set; }
    public ObjectId SendPulseId { get; set; }
    public BotApiToken ApiToken { get; set; }
}
