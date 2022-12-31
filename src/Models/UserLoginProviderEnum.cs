/*
 * UserLoginProviderEnum.cs
 *
 *   Created: 2022-12-03-11:03:25
 *   Modified: 2022-12-03-11:03:25
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
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
    LinkedIn = 9,
    Instagram = 10,
    Discord = 11,
    Twitch = 12,
    Yahoo = 13,
    Amazon = 14,
    Spotify = 15,
    Reddit = 16,
    StackOverflow = 17,
    PayPal = 18,
    Stripe = 19
}
