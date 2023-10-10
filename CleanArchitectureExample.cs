using System;

namespace CleanArchitectureExample
{
    // Domain Layer
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IUserRepository
    {
        User GetUserById(int id);
    }

    // Application Layer
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }

    // Infrastructure Layer
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int id)
        {
            // Simulate DB call
            return new User { Id = id, Name = "John Doe" };
        }
    }

    // Presentation Layer
    public class UserController
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public void GetUserDetails(int id)
        {
            var user = _userService.GetUser(id);
            Console.WriteLine($"User ID: {user.Id}, User Name: {user.Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Dependency Injection (manual for simplicity)
            IUserRepository userRepository = new UserRepository();
            UserService userService = new UserService(userRepository);
            UserController userController = new UserController(userService);

            // Fetch user details
            userController.GetUserDetails(1);
        }
    }
}
