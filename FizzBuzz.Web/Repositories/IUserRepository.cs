using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Repositories
{
    public interface IUserRepository 
    {
        string GetFirstName(int userId);
        string GetLastName(int userId);
        int GetAge(int userId);
        IList<User> GetAllUsers();
    }
}
