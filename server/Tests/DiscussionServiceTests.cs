using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;
using System;

namespace Tests
{
    public class DiscussionServiceTests
    {
        private DiscussionRepository discussionRepository;
        private DiscussionService discussionService;
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
            this.discussionRepository = new DiscussionRepository();
            this.discussionService = new DiscussionService(this.discussionRepository, this.roomRepository, this.userRepository);
        }

        [Test]
        [TestCase("DiscussionName", "DiscussionName")]
        public void StartDiscussion(string discussionName, string expectedResult)
        {
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var discussion = this.discussionService.Start(discussionName, room.Id, owner.Token);
            Assert.AreEqual(expectedResult, discussion.Name);
        }
    }
}
