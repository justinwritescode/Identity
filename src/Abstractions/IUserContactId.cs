namespace JustinWritesCode.Identity.Abstractions;

public interface IUserContactId : IUserAssociatedEntity
{
    int BotId { get; set; }
    ObjectId ContactId { get; set; }
}
