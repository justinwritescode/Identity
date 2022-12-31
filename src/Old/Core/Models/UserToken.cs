namespace JustinWritesCode.Identity.Models;
using Abstractions;

[DebuggerDisplay("User Token ({UserId} - {LoginProvider}, Created: {DateTimeCreated})")]
public class UserToken : IdentityUserToken<long>, IIdentifiable<int>, IUserAssociatedEntity, IUserLoginThing//, IHaveTimestamps
{
    public virtual int Id { get; set; }

    public override long UserId  { get; set; }

    public virtual User User { get; set; }

    public virtual int ProviderId { get; set; }
    public override string Value { get; set; }
    IUser? IUserAssociatedEntity.User { get => User; set => User = value as User; }
}
