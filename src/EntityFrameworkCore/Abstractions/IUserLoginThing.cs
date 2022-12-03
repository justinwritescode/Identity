namespace JustinWritesCode.Identity.Abstractions;

public interface IUserLoginThing : IIdentifiable<BackroomKey>
{
    byte ProviderId { get; set; }
    MUserLoginProvider Provider { get; set; }
    string ProviderName { get; set; }
    BackroomUser User { get; set; }
    BackroomKey UserId { get; set; }
}
