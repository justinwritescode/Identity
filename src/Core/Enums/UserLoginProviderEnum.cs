
namespace JustinWritesCode.Identity.Enums
{
    /// <summary>
    /// This is an enum of all possible login providers.  Currently only the <see cref="UserLoginProviderEnum.Telegram"/> is supported.
    /// </summary>
    [GenerateEnumerationClass("UserLoginProvider", "JustinWritesCode.Identity.Models")]
    public enum UserLoginProviderEnum : byte
    {
        /// <summary>Placeholder for any nonsupported login provider</summary>
        None = 0,
        /// <summary>For users who log in through the Telegram Bot API</summary>
        Telegram = 1,
        /// <summary>For users who log in through Google OAuth</summary>
        Google = 2,
        /// <summary>For users who log in through Microsoft OAuth</summary>
        Microsoft = 3,
        /// <summary>For users who log in through Twitter OAuth</summary>
        Twitter = 4,
        /// <summary>For users who log in through Facebook OAuth</summary>
        Facebook = 5
    }
}
