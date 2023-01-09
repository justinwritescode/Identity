/*
 * ClaimsPrincipalExtensions.cs
 *
 *   Created: 2023-01-08-02:38:24
 *   Modified: 2023-01-08-02:38:24
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Security.Claims;

public static class ClaimsPrincipalExtensions
{
    // public static string? FindFirstValue(this ClaimsPrincipal principal, string claimType)
    //     => principal.FindFirst(claimType)?.Value;
    public static IEnumerable<string> FindAllValues(this ClaimsPrincipal principal, string claimType)
        => principal.FindAll(c => c.Type == claimType).Select(c => c.Value);
    public static int GetUserId(this ClaimsPrincipal principal)
        => int.Parse(principal.FindFirstValue(Ct.NameIdentifier));
    public static string? GetName(this ClaimsPrincipal principal)
        => principal.FindFirstValue(Ct.Name);
    public static string? GetEmail(this ClaimsPrincipal principal)
        => principal.FindFirstValue(Ct.Email);
    public static string? GetPhoneNumber(this ClaimsPrincipal principal)
        => principal.FindFirstValue(Ct.MobilePhone) ?? principal.FindFirstValue(Ct.HomePhone) ?? principal.FindFirstValue(Ct.OtherPhone);
    public static IEnumerable<string> GetRoles(this ClaimsPrincipal principal)
        => principal.FindAllValues(Ct.Role);
    public static bool IsInRole(this ClaimsPrincipal principal, string role)
        => principal.GetRoles().Contains(role, StringComparer.OrdinalIgnoreCase);
    public static bool IsInAnyRole(this ClaimsPrincipal principal, params string[] roles)
        => roles.Any(principal.IsInRole);
    public static bool IsInAllRoles(this ClaimsPrincipal principal, params string[] roles)
        => roles.All(principal.IsInRole);
    public static string GetDisplayName(this ClaimsPrincipal principal)
    {
        return principal.FindFirstValue(JwcCt.CommonName) ??
            principal.FindFirstValue(Ct.GivenName) ??
            principal.FindFirstValue(Ct.Name) ??
            principal.FindFirstValue(Ct.Email) ??
            principal.FindFirstValue(Ct.NameIdentifier) ??
            "Unknown";
    }
}
