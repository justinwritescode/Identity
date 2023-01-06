/*
 * UserLoginProviderEnum.cs
 *
 *   Created: 2022-12-03-11:03:25
 *   Modified: 2022-12-03-11:03:25
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;

[GenerateEnumerationRecordClass("UserLoginProvider", "JustinWritesCode.Identity.Models")]
public enum UserLoginProviderEnum
{
    [Uri(JwcCt.UnknownLoginProvider)]
    None = 0,
    [Uri(JwcCt.UnknownLoginProvider)]
    Any = -1,
    [Uri(TelegramID.BaseUri)]
    Telegram = 1,
    [Uri(SendPulseId.BaseUri)]
    SendPulse = 2,
    [Uri("https://google.com/")]
    Google = 3,
    [Uri("https://facebook.com/")]
    Facebook = 4,
    [Uri("https://twitter.com/")]
    Twitter = 5,
    [Uri("https://microsoft.com/")]
    Microsoft = 6,
    [Uri("https://apple.com/")]
    Apple = 7,
    [Uri("https://github.com/")]
    GitHub = 8,
    [Uri("https://linkedin.com/")]
    LinkedIn = 9,
    [Uri("https://instagram.com/")]
    Instagram = 10,
    [Uri("https://discord.com/")]
    Discord = 11,
    [Uri("https://twitch.com/")]
    Twitch = 12,
    [Uri("https://yahoo.com/")]
    Yahoo = 13,
    [Uri("https://amazon.com/")]
    Amazon = 14,
    [Uri("https://spotify.com/")]
    Spotify = 15,
    [Uri("https://reddit.com/")]
    Reddit = 16,
    [Uri("https://stackoverflow.com/")]
    StackOverflow = 17,
    [Uri("https://paypal.com/")]
    PayPal = 18,
    [Uri("https://stripe.com/")]
    Stripe = 19
}
