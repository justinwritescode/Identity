namespace JustinWritesCode.Identity.Abstractions;

public interface IUserLoginProvider : IIdentifiable<int>
{
    string Name { get; set; }
    string DisplayName { get; set; }
}
