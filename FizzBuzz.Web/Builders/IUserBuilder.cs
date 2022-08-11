using FizzBuzz.Web.Models;
using FizzBuzz.Web.Repositories;

namespace FizzBuzz.Web.Builders
{
    public interface IUserBuilder
    {
        User Build();
        UserBuilder SetFirstName(int userId);
        UserBuilder SetLastName(int userId);
        UserBuilder SetAge(int userId);

    }
}