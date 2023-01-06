/*
 * FindBotsExtensions.cs
 *
 *   Created: 2022-12-13-07:58:43
 *   Modified: 2022-12-13-07:58:43
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;
using Telegram.Bot.Types;
using System.Linq;

namespace JustinWritesCode.Identity;

public static class FindBotsExtensions
{
    public static async Task<Bot?> FindBotAsync(this IQueryable<Bot> bots, object identifier)
    {
        return identifier is null
            ? throw new ArgumentNullException(nameof(identifier))
            : identifier is int id
            ? await bots.FirstOrDefaultAsync(b => b.Id == id)
            : identifier is string username
            ? await bots.FirstOrDefaultAsync(b => b.TelegramUsername == username)
            : identifier is ObjectId sendPulseId
            ? await bots.FirstOrDefaultAsync(b => b.SendPulseId == sendPulseId)
            : identifier is BotApiToken apiToken
            ? await bots.FirstOrDefaultAsync(b => b.ApiToken == apiToken)
            : identifier is string @string && ObjectId.TryParse(@string, out sendPulseId)
            ? await bots.FirstOrDefaultAsync(b => b.SendPulseId == sendPulseId)
            : identifier is string @string2 && BotApiToken.TryParse(@string2, out var apiToken2)
            ? await bots.FirstOrDefaultAsync(b => b.ApiToken == apiToken2)
            : throw new ArgumentException($"Cannot find bot with identifier of type {identifier.GetType().Name}", nameof(identifier));
    }
}
