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

extern alias JwcCm;
namespace JustinWritesCode.Identity.Models;

[GenerateEnumerationRecordClass("UserLoginProvider", "JustinWritesCode.Identity.Models")]
public enum UserLoginProviderEnum
{
    [JwcCm.System.ComponentModel.DataAnnotations.Uri(JwcCt.UnknownLoginProvider)]
    None = 0,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute(JwcCt.UnknownLoginProvider)]
    Any = -1,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute(TelegramID.BaseUri)]
    Telegram = 1,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute(SendPulseId.BaseUri)]
    SendPulse = 2,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://google.com/")]
    Google = 3,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://facebook.com/")]
    Facebook = 4,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://twitter.com/")]
    Twitter = 5,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://microsoft.com/")]
    Microsoft = 6,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://apple.com/")]
    Apple = 7,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://github.com/")]
    GitHub = 8,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://linkedin.com/")]
    LinkedIn = 9,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://instagram.com/")]
    Instagram = 10,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://discord.com/")]
    Discord = 11,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://twitch.com/")]
    Twitch = 12,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://yahoo.com/")]
    Yahoo = 13,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://amazon.com/")]
    Amazon = 14,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://spotify.com/")]
    Spotify = 15,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://reddit.com/")]
    Reddit = 16,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://stackoverflow.com/")]
    StackOverflow = 17,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://paypal.com/")]
    PayPal = 18,
    [JwcCm.System.ComponentModel.DataAnnotations.UriAttribute("https://stripe.com/")]
    Stripe = 19
}
