using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Seed
{
    public static class SeedUsers
    {

        public static IList<User> Seed()
        {
            return new List<User>()
            {
                new User(){ Id = 1, FirstName = "John", LastName = "Bonham", Age = 32},
                new User(){ Id = 2, FirstName = "Jimmy", LastName = "Page", Age = 78},
                new User(){ Id = 3, FirstName = "John", LastName = "Paul Jones", Age = 76},
                new User(){ Id = 4, FirstName = "Robert", LastName = "Plant", Age = 74}
            };
        }
    }
}
