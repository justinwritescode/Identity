using System.ComponentModel.DataAnnotations;
/*
 * IBackroomUser.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:50
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Abstractions;
using System.Domain;
using System.Net.Mail;
using JustinWritesCode.Abstractions;

public interface IUser : IIdentifiable<int>, IBasicUserInfo
{
    /// <summary>Gets or sets a flag indicating if the user can be locked out.</summary>
    /// <value><pre><b>True</b></pre> if the user <b><b>can</b></b> be locked out, <pre><b>false</b></pre> otherwise.</value>    int AccessFailedCount { get; set; }
    bool LockoutEnabled { get; set; }
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="Email"/> address in his profile, <pre><b>false</b></pre> otherwise.</value>
    bool EmailConfirmed { get; set; }
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="PhoneNumber"/> in his profile, <pre><b>false</b></pre> otherwise.</value>
    bool PhoneNumberConfirmed { get; set; }
    /// <summary>Gets or sets a flag indicating if a user has two-factor authentication set up.</summary>
    /// <value><pre><b>True</b></pre> if the user has two-factor authentication set up,  <pre><b>false</b></pre> otherwise.</value>
    bool TwoFactorEnabled { get; set; }
    /// <summary>Gets or sets a flag indicating whether the user has been locked out (either deliberately be an administrator or by exhausting the number of attempts allowed to authenticate.</summary>
    /// <value><pre>True</pre> if the user <b><i>is locked out</i></b> right now, <pre><b>false</b></pre> otherwise.</value>
    bool LockedOut { get; }
    /// <summary>A random value that must change whenever a user is persisted to the store</summary>
    string ConcurrencyStamp { get; set; }
    /// <summary>A hashed and salted representation of the user's password.</summary>
    string PasswordHash { get; set; }
    /// <summary>A random value that must change whenever a users credentials change (password changed, login removed)</summary>
    string SecurityStamp { get; set; }
    /// <summary>Gets or sets the normalized email address for this user.</summary>
    [EmailAddress]
    EmailAddress? NormalizedEmailAddress { get; set; }
    /// <summary>Gets or sets the normalized usernamw for this user.</summary>
    string NormalizedUserName { get; set; }
    /// <summary>Gets or sets the user's email address as a string.</summary>
    string Email  { get; set; }
}

/// <summary>An interface for holding the basic vital information for a user</summary>
public interface IBasicUserInfo
{
    /// <summary>Gets or sets the user's email addres as a data structure</summary>
    /// <example>justin@justinwritescode.com</example>
    [JProp("emailAddress")]
    [EmailAddress]
    EmailAddress? EmailAddress { get; set; }
    /// <summary>Gets or sets the user's username (usually the same as the <see cref="TelegramUsername" />)</summary>
    /// <example>justinwritescode</example>
    [JProp("username")]
    string UserName { get; set; }
    /// <summary>Gets or sets the user's first name</summary>
    /// <example>Justin</example>
    [JProp("givenName")]
    string GivenName { get; set; }
    /// <summary>Gets or sets the user's surname</summary>
    /// <example>Chase</example>
    string Surname { get; set; }
    /// <summary>Gets or sets the name the user "goes by" or wat he'd like to be called.</summary>
    /// <example>God of Telegram</example>
    string? GoByName { get; set; }
    /// <summary>Gets or sets the user's phone number as a data structure</summary>
    /// <example>+19185256012</example>
    [Phone, Column(TypeName = DbTypeVarChar), StringLength(20)]
    PhoneNumber? PhoneNumber { get; set; }
    /// <summary>Gets or sets the user's Telegram username</summary>
    /// <example>justinwritescode</example>
    string? TelegramUsername { get; set; }
    /// <summary>Gets or sets the user's Telegram ID 64, a-bit signed integer</summary>
    /// <example>123456789</example>
    long TelegramId { get; set; }
}
