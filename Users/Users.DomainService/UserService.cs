using Users.Repository;

namespace Users.DomainService
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public int AddUser(Users.Domain.Entities.Users user)
        {
            return userRepository.AddUser(user);
        }
    }
}