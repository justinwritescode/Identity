namespace JustinWritesCode.Identity.Abstractions;
public interface IUserLoginThing : IIdentifiable<int>, IUserAssociatedEntity
{
    int ProviderId { get; set; }
}
