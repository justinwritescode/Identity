namespace JustinWritesCode.Identity.Abstractions;

public interface IUserToken : IUserAssociatedEntity
{
    int ProviderId { get; set; }
    string Value { get; set; }
}
