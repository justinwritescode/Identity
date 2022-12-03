namespace JustinWritesCode.Identity.Abstractions;

public interface IUserClaim : IUserAssociatedEntity, IHaveAWritableId<long>
{
    uri ClaimType { get; set; }
    string ClaimValue { get; set; }
}
