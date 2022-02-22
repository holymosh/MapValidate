using AutoMapper;
using Users.Domain.Entities;
using Users.Logic.DTO;
using Users.Logic.Validators;

namespace Users.Logic.MappingsDTO
{
    public static class UserDtoMapper
    {
        public static IMapperConfigurationExpression AddUserMap(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<UserDto, User>()
                .AfterMap<AfterMapValidation<UserDto,User>>()
                .ReverseMap();
            return cfg;
        }
    }
}