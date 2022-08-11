using FizzBuzz.Web.Models;
using FizzBuzz.Web.Repositories;
using FizzBuzz.Web.Builders;

namespace FizzBuzz.Web.ViewModels
{
    public class UserViewModel : IUserViewModel
    {
        public IList<User> Users { get; set; } = new List<User>();
        private readonly IUserRepository _userRepository;
        private readonly IUserBuilder _builder;
        public UserViewModel(IUserRepository repo, IUserBuilder builder) 
        {
            _userRepository = repo;
            _builder = builder;
        }

        public void BuildUser()
        {
            // Lets get the third user

            var userId = 3;

            User user = UserBuilder.Init(_userRepository)
                          .SetFirstName(userId)
                          .SetLastName(userId)
                          .SetAge(userId)
                          .Build();

        }

        public void PopulateUsersOnViewModel()
        {
            this.Users = _userRepository.GetAllUsers();
        }
    }
}
