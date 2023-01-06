/*
 * IBot.cs
 *
 *   Created: 2022-12-28-05:38:13
 *   Modified: 2022-12-28-05:38:14
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;
using Telegram.Bot.Types;

public interface IBot
{
    int Id { get; set; }
    long TelegramId { get; set; }
    string TelegramUsername { get; set; }
    string Name { get; set; }
    ObjectId SendPulseId { get; set; }
    BotApiToken ApiToken { get; set; }
}
