namespace JustinWritesCode.Identity.Abstractions;

public interface IUserLoginThing : IIdentifiable<int>
{
    int ProviderId { get; set; }
    string ProviderName { get; set; }
    int UserId { get; set; }
}
