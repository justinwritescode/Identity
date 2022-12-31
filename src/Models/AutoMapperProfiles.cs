/*
 * AutoMapperProfiles.cs
 *
 *   Created: 2022-12-15-08:17:45
 *   Modified: 2022-12-15-08:17:45
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JustinWritesCode.Identity.AutoMapper;

public class AutoMapperProfile : global::AutoMapper.Profile
{
    public AutoMapperProfile(/*IPasswordHasher<User> passwordHasher*/)
    {
        // this.CreateMap<SendPulse.Telegram.WebhookMessage, User>()
        //     .ForMember(u => u.PasswordHash, mcex => mcex.MapFrom((msg, u) => passwordHasher.HashPassword(u, User.DefaultPassword)))
        //     .ForMember(u => u.TelegramId, mcex => mcex.MapFrom(msg => msg.Contact.LastMessageData.ChatId!.Value))
        //     .ForMember(u => u.FirstName, mcex => mcex.MapFrom((msg, u) => u.FirstName ?? msg.Contact.Name))
        //     .ForMember(u => u.TelegramUsername, mcex => mcex.MapFrom((msg, u) => u.TelegramUsername ?? msg.Contact.Username));

        _ = this.CreateMap<User, UserDto>()
            .ForMember(dto => dto.PhoneNumber, mcex => mcex.MapFrom(u => u.Phone))
            .ForMember(dto => dto.EmailAddress, mcex => mcex.MapFrom(u => u.EmailAddress))
            .ReverseMap();
        _ = this.CreateMap<UserInsertDto, User>()
            .ForMember(u => u.Phone, mcex => mcex.MapFrom(dto => dto.PhoneNumber))
            .ForMember(u => u.EmailAddress, mcex => mcex.MapFrom(dto => dto.EmailAddress))
            .ReverseMap();
        this.CreateMap<UserClaim, C>()
            .ConvertUsing(uc => uc.ToClaim());
        this.CreateMap<C, UserClaim>()
            .ConvertUsing(c => c.ToUserClaim());
        _ = this.CreateMap<RoleInsertDto, Role>().ReverseMap();
    }
}
