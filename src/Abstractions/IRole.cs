namespace JustinWritesCode.Identity.Abstractions;

public interface IRole : IHaveAWritableId<long>
{
    string Name { get; set; }
    uri? Uri { get; set; }
    ICollection<IUser> Users { get; set; }
}
