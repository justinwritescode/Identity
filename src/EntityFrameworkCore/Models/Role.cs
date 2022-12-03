/*
 * BackroomRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-04:59:07
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity.Models;

[Table(tbl_Role, Schema = IdSchema), DebuggerDisplay("Role ({Id} - {Name} {Uri})")]
public class Role : IdentityRole<long>, IIdentifiable<long>
{
    [Key, DatabaseGenerated(DbGenO.Identity)]
    public override long Id { get; set; } //= NewId;

    [Bindable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string NormalizedName { get => base.Name.ToUpper(); set { } }

    [Column(nameof(ConcurrencyStamp), TypeName = DbTypeRowVersion), DatabaseGenerated(DbGenO.Computed)]
    public override string? ConcurrencyStamp { get; set; } = NewGuid().ToString();

    [StringLength(UriMaxLength)]
    public override string? Name { get => base.Name ??= Uri?.ToString(); set { base.Name = value; Uri = value.ToUri(); NormalizedName = value.ToUpper(); } }

    [StringLength(UriMaxLength)]
    public override string? NormalizedName { get => base.NormalizedName = base.Name?.ToUpper(); set => base.NormalizedName = value?.ToUpper(); }

    private Uri? _uri;
    [Column(nameof(Uri)), StringLength(256)]
    public virtual Uri? Uri { get => _uri ??= Uri.TryCreate(Name, UriKind.RelativeOrAbsolute, out _uri) ? _uri : default; set => _uri = value; }

    // public virtual ICollection<IUser> Users { get; set; } = new List<BackroomUser>();

    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }   }
}
