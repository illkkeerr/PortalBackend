using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //User
        CreateMap<RegisterDto, User>();
        CreateMap<CreateUserDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<ChangePasswordDto, User>();

        //Message
        CreateMap<CreateMessageDto, Message>();
        CreateMap<Message,MessageInfoDto>();
        CreateMap<MessageUpdateDto, Message>();

        //AccountHistory
        CreateMap<CreateAccountHistoryDto, AccountHistory>();
        CreateMap<AccountHistory,AccountHistoryInfoDto>();
        CreateMap<AccountHistoryUpdateDto, AccountHistory>();
    }
}