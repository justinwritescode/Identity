/*
 * FindBotsExtensions.cs
 *
 *   Created: 2022-12-13-07:58:43
 *   Modified: 2022-12-13-07:58:43
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;
using Telegram.Bot.Types;

namespace JustinWritesCode.Identity;

public static class FindBotsExtensions
{
    public static async Task<Bot?> FindBotAsync(this IQueryable<Bot> bots, object identifier)
    {
        if (identifier is null)
            throw new ArgumentNullException(nameof(identifier));

        if (identifier is int id)
            return await bots.FirstOrDefaultAsync(b => b.Id == id);

        if (identifier is string username)
            return await bots.FirstOrDefaultAsync(b => b.TelegramUsername == username);

        if (identifier is ObjectId sendPulseId)
            return await bots.FirstOrDefaultAsync(b => b.SendPulseId == sendPulseId);

        if (identifier is BotApiToken apiToken)
            return await bots.FirstOrDefaultAsync(b => b.ApiToken == apiToken);

        if (identifier is string @string && ObjectId.TryParse(@string, out sendPulseId))
            return await bots.FirstOrDefaultAsync(b => b.SendPulseId == sendPulseId);

        if (identifier is string @string2 && BotApiToken.TryParse(@string2, out var apiToken2))
            return await bots.FirstOrDefaultAsync(b => b.ApiToken == apiToken2);

        throw new ArgumentException($"Cannot find bot with identifier of type {identifier.GetType().Name}", nameof(identifier));
    }
}
