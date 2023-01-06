/*
 * BackroomRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-04:59:07
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;
using System;
using System.Collections.ObjectModel;
using JustinWritesCode.Abstractions;
using Microsoft.AspNetCore;
using static System.Guid;
using static JustinWritesCode.EntityFrameworkCore.Constants.Schemas;

[Table(tbl_Role, Schema = IdSchema), DebuggerDisplay("Role ({Id} - {Name} {Uri})")]
[JSerializable(typeof(Role))]
public class Role : IdentityRole<int>, IIdentifiable<int>
{
    public const string RoleUriDefaultFormatString = "urn:role:{0}";

    [Key, DbGen(DbGenO.Identity), Hashids]
    public override int Id { get; set; } //= NewId;

    [Column(nameof(ConcurrencyStamp), TypeName = DbTypeRowVersion), DbGen(DbGenO.Computed)]
    public override string? ConcurrencyStamp { get; set; } = NewGuid().ToString();

    [StringLength(UriMaxLength)]
    public override string? Name { get => base.Name ??= Uri?.ToString(); set { base.Name = value; Uri = value.ToUri(); NormalizedName = value.Normalize(); } }

    [StringLength(UriMaxLength)]
    public override string? NormalizedName { get => base.NormalizedName = base.Name.Normalize(); set => base.NormalizedName = value.Normalize(); }
    public string Description { get; set; } = string.Empty;

    private uri? _uri;
    [Column(nameof(Uri)), StringLength(UriMaxLength)]
    public virtual uri? Uri { get => _uri ??= Name.ToUri() ?? uri.From(Format(RoleUriDefaultFormatString, Name)); set => _uri = value; }

    public virtual Collection<User> Users { get; set; } = new Collection<User>();
    public virtual Collection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
}

public struct RoleInsertDto
{
    public RoleInsertDto() : this(string.Empty, string.Empty) { }
    public RoleInsertDto(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
