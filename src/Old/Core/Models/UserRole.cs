namespace JustinWritesCode.Identity.Models;
using Abstractions;

[DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")]
public class UserRole : IdentityUserRole<long>, IUserAssociatedEntity
{
    public virtual int Id { get; set; }
    // public override long RoleId { get => base.RoleId; set => base.RoleId = value; }
    // public override long UserId { get => base.UserId; set => base.UserId = value; }
    public User? User { get; set; }
    IUser? IUserAssociatedEntity.User { get => User; set => User = value as User; }
}
