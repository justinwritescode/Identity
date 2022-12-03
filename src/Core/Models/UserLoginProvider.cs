using System;

namespace JustinWritesCode.Identity.Models
{
    public partial class UserLoginProvider : IIdentifiable<int>
    {
        //public UserLoginProvider(UserLoginProviderEnum id, string name) : base((byte)id, name) { }
        //public UserLoginProvider() : base() { }//this(default, default) { }

        //[Id, Column(ColId)/*, DatabaseGenerated(Computed)*/]
        //public virtual UserLoginProviderEnum Value
        //{
        //    get => (UserLoginProviderEnum)Id;
        //    set => Id = (byte)(object)value;
        //}

        // public static readonly IEnumerable<UserLoginProvider> All = new[] { Telegram, Any, Google, Facebook, Twitter, Microsoft }!;

        // [Id, Column(ColId)]
        //public override byte Id { get => base.Id; protected set => base.Id = value; }

        //public static readonly UserLoginProvider Telegram = new UserLoginProvider(TelegramLoginProvider, nameof(Telegram));
        //public static readonly UserLoginProvider Any = new UserLoginProvider(AnyLoginProvider, nameof(Any));
        //public static readonly UserLoginProvider Google = new UserLoginProvider(GoogleLoginProvider, nameof(Google));
        //public static readonly UserLoginProvider Facebook = new UserLoginProvider(FacebookLoginProvider, nameof(Facebook));
        //public static readonly UserLoginProvider Twitter = new UserLoginProvider(TwitterLoginProvider, nameof(Twitter));
        //public static readonly UserLoginProvider Microsoft = new UserLoginProvider(MicrosoftLoginProvider, nameof(Microsoft));

        //public static implicit operator UserLoginProvider(UserLoginProviderEnum @enum)
        //    => @enum switch
        //    {
        //        AnyLoginProvider => Any,
        //        TelegramLoginProvider => Telegram,
        //        GoogleLoginProvider => Google,
        //        FacebookLoginProvider => Facebook,
        //        TwitterLoginProvider => Twitter,
        //        MicrosoftLoginProvider => Microsoft,
        //        _ => throw new ArgumentException(nameof(@enum), "The value was not recognized.")
        //    };

        //public static implicit operator UserLoginProviderEnum(UserLoginProvider provider) => provider.Value;

        //public static implicit operator UserLoginProvider(string name)
        //    => name switch
        //    {
        //        nameof(Any) => Any,
        //        nameof(Telegram) => Telegram,
        //        nameof(Google) => Google,
        //        nameof(Facebook) => Facebook,
        //        nameof(Twitter) => Twitter,
        //        nameof(Microsoft) => Microsoft,
        //        _ => new UserLoginProvider(byte.MinValue, name)
        //    };

        //public static implicit operator string(UserLoginProvider provider) => provider.Name;

        //public static implicit operator byte(UserLoginProvider provider) => provider.Id;
        //public static implicit operator UserLoginProvider(byte id) => (UserLoginProvider)(UserLoginProviderEnum)(object)id;
    }
}
