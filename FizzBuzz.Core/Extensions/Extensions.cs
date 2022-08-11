using FizzBuzz.Core.Models;
using FizzBuzz.Core.Repositories;
using FizzBuzz.Core.Services;
using FizzBuzz.Core.Repositories.EntityFramework;


namespace FizzBuzz.Core.Extensions;

public static class ServiceExtensions
{
    public static void RegisterRepos(this IServiceCollection collection)
    {
        collection.AddTransient<IRepository, EFRepository>();

        //Add other repositories
        collection.AddSingleton<IDbServices, DbServices>();
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