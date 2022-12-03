namespace JustinWritesCode.Identity.Models;
using Abstractions;
using JustinWritesCode.Abstractions;

[DebuggerDisplay("User Login (Id} - {LoginProvider}: {ProviderKey})")]
public class UserLogin : IdentityUserLogin<long>, IUserAssociatedEntity, IUserLoginThing, IUserLogin
{
    public virtual int Id { get; set; }
    public virtual UserLoginProvider Provider
    {
        get => UserLoginProvider.Parse<UserLoginProvider>(base.LoginProvider);
        set => base.LoginProvider = value.Name;
    }

    public virtual string ProviderName
    {
        get => base.LoginProvider;
        set => base.LoginProvider = value;
    }

    public override string ProviderDisplayName { get => Provider.DisplayName; set => Provider = UserLoginProvider.Parse<UserLoginProvider>(value); }

    public virtual int ProviderId
    {
        get => Provider;
        set => Provider = UserLoginProvider.FromValue<UserLoginProvider>(value);
    }

    public virtual User? User { get; set; }

    // public override long UserId { get => base.UserId; set => base.UserId = value; }
    IUser? IUserAssociatedEntity.User { get => User; set => User = value as User; }
    // long IHaveAWritableId<long>.Id { get => Id; set => Id = value; }
}
