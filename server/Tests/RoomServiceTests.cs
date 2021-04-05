using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;
using System;

namespace Tests
{
    public class RoomServiceTests
    {
        private UserRepository userRepository;
        private UserService userService;
        private RoomRepository roomRepository;
        private RoomService roomService;

        [OneTimeSetUp]
        public void CreateServiceAndRepository()
        {
            this.userRepository = new UserRepository();
            this.userService = new UserService(this.userRepository);
            this.roomRepository = new RoomRepository();
            this.roomService = new RoomService(this.roomRepository, this.userRepository);
        }

        [Test]
        [TestCase("RoomName", "fb7b906e-4191-4e08-98b2-f65ca94cba05")]
        public void CreateRoom(string name, Guid ownerId)
        {
            var room = this.roomService.Create(name, ownerId);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(name, room.Name);
                Assert.AreEqual(ownerId, room.OwnerId);
            });
        }

        [Test]
        public void AddUserToRoom()
        {
            var roomOwner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", roomOwner.Id);
            var newUser = this.userService.Create("NewUserName");
            this.roomService.AddUser(newUser.Id, room.Id, roomOwner.Token);
            Assert.AreEqual(true, room.Participants.Contains(newUser.Id));
        }
    }
}
