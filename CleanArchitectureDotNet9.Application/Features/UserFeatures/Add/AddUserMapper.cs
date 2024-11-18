using AutoMapper;
using CleanArchitectureDotNet9.Domain.Entities;

namespace CleanArchitectureDotNet9.Application.Features.UserFeatures.Add
{
    public sealed class AddUserMapper : Profile
    {
        public AddUserMapper()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();
        }
    }
}