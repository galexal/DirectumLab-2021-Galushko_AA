using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;
using System;

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
        public void CreateUser()
        {
            var user = this.userService.Create("UserName");
            Assert.AreEqual("UserName", user.Name);
        }

        [Test]
        public void ChangeUserName()
        {
            var user = this.userService.Create("UserName");
            var userId = user.Id;
            var token = user.Token;
            user = this.userService.ChangeName("newUserName", userId, token);
            Assert.AreEqual("newUserName", user.Name);
        }

        [Test]
        public void ThrowException()
        {
            var user = this.userService.Create("UserName");
            Assert.Multiple(() =>
            {
                Assert.Throws<FormatException>(() => this.userService.Create(string.Empty));
                Assert.Throws<FormatException>(() => this.userService.ChangeName(string.Empty, user.Id, user.Token));
                Assert.Throws<UnauthorizedAccessException>(() => this.userService.ChangeName("NewUserName", Guid.NewGuid(), user.Token));
                Assert.Throws<UnauthorizedAccessException>(() => this.userService.ChangeName("NewUserName", user.Id, "token"));
            });
        }
    }
}
