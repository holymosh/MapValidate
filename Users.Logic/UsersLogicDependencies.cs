using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Users.Domain.Entities;
using Users.Logic.MappingsDTO;
using Users.Logic.Validators;

namespace Users.Logic
{
    public static class UsersLogicDependencies
    {
        public static void RegisterUserMappings(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton(typeof(AfterMapValidation<,>));
            serviceCollection.AddSingleton<IValidator<User>, UserValidator>();
            serviceCollection.AddSingleton<MapperConfiguration>(provider =>
                new MapperConfiguration(conf
                    => conf.AddUserMap().ConstructServicesUsing(provider.GetService)));
            serviceCollection.AddSingleton<IMapper, Mapper>(provider => new Mapper(provider.GetService<MapperConfiguration>()));
        }

        public static void RegisterUserLogicPackage(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterUserMappings();
        }
    }
}