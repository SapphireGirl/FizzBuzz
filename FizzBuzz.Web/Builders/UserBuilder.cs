using FizzBuzz.Web.Models;
using FizzBuzz.Web.Repositories;

namespace FizzBuzz.Web.Builders
{
    public class UserBuilder : IUserBuilder
    {
        private User _user = new User();
        private readonly IUserRepository _userRepository;

        // For DI
        public UserBuilder() { }
        private UserBuilder(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public static UserBuilder Init(IUserRepository userRepository)
        {
            return new UserBuilder(userRepository);
        }

        public User Build() => _user;

        public UserBuilder SetFirstName(int userId)
        {
            _user.FirstName = _userRepository.GetFirstName(userId);
            return this;
        }

        public UserBuilder SetLastName(int userId)
        {
            
            _user.LastName = _userRepository.GetLastName(userId);
            return this;
        }

        public UserBuilder SetAge(int userId)
        {

            _user.Age = _userRepository.GetAge(userId);
            return this;
        }
    }
}
