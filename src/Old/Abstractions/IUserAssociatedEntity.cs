using System;

namespace JustinWritesCode.Identity.Abstractions
{
    public interface IUserAssociatedEntity : IIdentifiable<int>, IHaveAWritableId<int>
    {
        long UserId { get; set; }
        IUser? User { get; set; }
    }
}
