using FizzBuzz.Web.Models;
using FizzBuzz.Web.Seed;

namespace FizzBuzz.Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        public T Get<T>()
        {
            throw new NotImplementedException();
        }

        public int GetAge(int userId)
        {
            var user = SeedUsers.Seed().FirstOrDefault(x => x.Id == userId);
            if (user == null) return 0;
            else return user.Age;
        }

        public IList<User> GetAllUsers()
        {
            return SeedUsers.Seed();
        }

        public string GetFirstName(int userId)
        {
            var user = SeedUsers.Seed().FirstOrDefault(x => x.Id == userId);
            if (user == null) return "";
            else return user.FirstName ?? "";
        }

        public string GetLastName(int userId)
        {
            var user = SeedUsers.Seed().FirstOrDefault(x => x.Id == userId);
            if (user == null) return "";
            else return user.LastName ?? "";
        }
    }
}
