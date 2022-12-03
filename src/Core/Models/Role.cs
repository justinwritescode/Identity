namespace JustinWritesCode.Identity.Models;

public class Role : Microsoft.AspNetCore.Identity.IdentityRole<long>, IRole
{
    public override long Id { get; set; }

    public override string? ConcurrencyStamp { get; set; }

    [StringLength(UriMaxLength)]
    public override string? Name { get => base.Name ??= Uri?.ToString(); set { base.Name = value; Uri = value.ToUri(); NormalizedName = value.ToUpper(); } }

    [StringLength(UriMaxLength)]
    public override string? NormalizedName { get => base.NormalizedName = base.Name?.ToUpper(); set => base.NormalizedName = value?.ToUpper(); }

    public virtual Uri? Uri { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    ICollection<IUser> IRole.Users { get => Users.ToArray(); set => Users.AddRange(value.OfType<User>()); }
}
