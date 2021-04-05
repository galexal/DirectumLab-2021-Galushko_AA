using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;

namespace Tests
{
    public class UserServiceTests
    {
        private UserService userService;
        private UserRepository userRepository;

        [OneTimeSetUp]
        public void CreateServiceAndRepository()
        {
            this.userRepository = new UserRepository();
            this.userService = new UserService(this.userRepository);
        }

        [Test]
        [TestCase("UserName")]
        public void CreateUser(string name)
        {
            var user = this.userService.Create(name);
            Assert.AreEqual(name, user.Name);
        }

        [Test]
        [TestCase("NewUserName")]
        public void ChangeUserName(string newName)
        {
            var user = this.userService.Create("UserName");
            var userId = user.Id;
            var token = user.Token;
            user = this.userService.ChangeName(newName, userId, token);
            Assert.AreEqual(newName, user.Name);
        }
    }
}
