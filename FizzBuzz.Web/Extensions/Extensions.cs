using FizzBuzz.Web.Repositories;
using FizzBuzz.Web.Builders;
using FizzBuzz.Web.ViewModels;

namespace FizzBuzz.Core.Extensions;

public static class ServiceExtensions
{
    public static void RegisterRepos(this IServiceCollection collection)
    {
        collection.AddTransient<IUserRepository, UserRepository>();
        collection.AddTransient<IUserBuilder, UserBuilder>();
        collection.AddTransient<IUserViewModel, UserViewModel>();
        collection.AddTransient<IUserBuilder, UserBuilder>();
    }

    public static void SetupDbContext(this IServiceCollection collection)
    {
        //collection.AddDbContext<FBDb
    }

    public static void RegisterLogging(this IServiceCollection collection)
    {
        //Register logging
    }

    public static void RegisterAuth(this IServiceCollection collection)
    {
        //Register authentication services.
    }
}