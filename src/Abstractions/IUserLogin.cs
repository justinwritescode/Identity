namespace JustinWritesCode.Identity.Abstractions;

public interface IUserLogin : IUserAssociatedEntity
{
    int ProviderId { get; set; }
}
