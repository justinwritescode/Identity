/*
 * Roles.cs
 *
 *   Created: 2022-12-16-04:49:57
 *   Modified: 2022-12-16-04:49:57
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;

public static class Roles
{
    /// <summary>The base URI for roles</summary>
    /// <value>urn:identity:role</value>
    public const string BaseUri = "urn:identity:role";

    /// <summary>The URI for the <inheritdoc cref="Names.Admin" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Admin" path="/value" /></value>
    public const string Admin = $"{BaseUri}:{Names.Admin}";
    /// <summary>The URI for the <inheritdoc cref="Names.Administrator" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Administrator" path="/value" /></value>
    public const string Administrator = $"{BaseUri}:{Names.Administrator}";
    /// <summary>The URI for the <inheritdoc cref="Names.GroupAdministrator" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
    public const string GroupAdministrator = $"{BaseUri}:{Names.GroupAdministrator}";
    /// <summary>The URI for the <inheritdoc cref="Names.Owner" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Owner" path="/value" /></value>
    public const string Owner = $"{BaseUri}:{Names.Owner}";
    /// <summary>The URI for the <inheritdoc cref="Names.User" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.User" path="/value" /></value>
    public const string User = $"{BaseUri}:{Names.User}";
    /// <summary>The URI for the <inheritdoc cref="Names.GroupMember" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.GroupMember" path="/value" /></value>
    public const string GroupMember = $"{BaseUri}:{Names.GroupMember}";
    /// <summary>The URI for the <inheritdoc cref="Names.Voter" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Voter" path="/value" /></value>
    public const string Voter = $"{BaseUri}:{Names.Voter}";
    /// <summary>The URI for the <inheritdoc cref="Names.Contestant" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Contestant" path="/value" /></value>
    public const string Contestant = $"{BaseUri}:{Names.Contestant}";
    /// <summary>The URI for the <inheritdoc cref="Names.AnonymousUser" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.AnonymousUser" path="/value" /></value>
    public const string AnonymousUser = $"{BaseUri}:{Names.AnonymousUser}";

    public static class Names
    {
        /// <summary>The name of the <inheritdoc cref="Admin" path="/value" /> role</summary>
        /// <value>admin</value>
        public const string Admin = Administrator;
        /// <summary>The name of the <inheritdoc cref="Administrator" path="/value" /> role</summary>
        /// <value>administrator</value>
        public const string Administrator = "administrator";
        /// <summary>The name of the <inheritdoc cref="GroupAdministrator" path="/value" /> role</summary>
        /// <value>group_administrator</value>
        public const string GroupAdministrator = "group_administrator";
        /// <summary>The name of the <inheritdoc cref="Owner" path="/value" /> role</summary>
        /// <value>owner</value>
        public const string Owner = "owner";
        /// <summary>The name of the <inheritdoc cref="User" path="/value" /> role</summary>
        /// <value>user</value>
        public const string User = "user";
        /// <summary>The name of the <inheritdoc cref="GroupMember" path="/value" /> role</summary>
        /// <value>group_member</value>
        public const string GroupMember = "group_member";
        /// <summary>The name of the <inheritdoc cref="Voter" path="/value" /> role</summary>
        /// <value>voter</value>
        public const string Voter = "voter";
        /// <summary>The name of the <inheritdoc cref="Contestant" path="/value" /> role</summary>
        /// <value>contestant</value>
        public const string Contestant = "contestant";

        /// <summary>The name of the <inheritdoc cref="AnonymousUser" path="/value" /> role.  Members of this role may log in "anonymously" and access basic API features.</summary>
        /// <value><c>anonymous_user</c></value>
        public const string AnonymousUser = "anonymous_user";
    }

    public static class Uris
    {
        /// <inheritdoc cref="JwcR.Admin" />
        public static readonly uri Admin = uri.From(JwcR.Admin);

        /// <inheritdoc cref="JwcR.Administrator" />
        public static readonly uri Administrator = uri.From(JwcR.Administrator);

        /// <inheritdoc cref="JwcR.GroupAdministrator" />
        public static readonly uri GroupAdministrator = uri.From(JwcR.GroupAdministrator);

        /// <inheritdoc cref="JwcR.Owner" />
        public static readonly uri Owner = uri.From(JwcR.Owner);

        /// <inheritdoc cref="JwcR.User" />
        public static readonly uri User = uri.From(JwcR.User);

        /// <inheritdoc cref="JwcR.GroupMember" />
        public static readonly uri GroupMember = uri.From(JwcR.GroupMember);

        /// <inheritdoc cref="JwcR.Voter" />
        public static readonly uri Voter = uri.From(JwcR.Voter);

        /// <inheritdoc cref="JwcR.Contestant" />
        public static readonly uri Contestant = uri.From(JwcR.Contestant);
    }
}
