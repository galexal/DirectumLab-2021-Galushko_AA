using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;
using PlanPoker.ValueObject;
using System;
using System.Linq;

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
        private CardRepository cardRepository;
        private CardService cardService;

        [OneTimeSetUp]
        public void CreateServiceAndRepository()
        {
            this.cardRepository = new CardRepository();
            this.cardService = new CardService(this.cardRepository);
            this.userRepository = new UserRepository();
            this.userService = new UserService(this.userRepository);
            this.roomRepository = new RoomRepository();
            this.roomService = new RoomService(this.roomRepository, this.userRepository);
            this.discussionRepository = new DiscussionRepository();
            this.discussionService = new DiscussionService(this.discussionRepository, this.roomRepository, this.userRepository);
        }

        [Test]
        public void StartDiscussion()
        {
            var discussionName = "DiscussionName";
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var discussion = this.discussionService.Start(discussionName, room.Id, owner.Token);
            Assert.AreEqual(discussionName, discussion.Name);
        }

        [Test]
        public void CloseDiscussion()
        {
            var discussionName = "DiscussionName";
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var discussion = this.discussionService.Start(discussionName, room.Id, owner.Token);
            this.discussionService.Close(discussion.Id, room.Id, owner.Token);
            Assert.AreEqual(true, discussion.EndAt != default);
        }

        [Test]
        public void Vote()
        {
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var user = this.userService.Create("UserName");
            this.roomService.AddUser(user.Id, room.Id);
            var discussion = this.discussionService.Start("DiscName", room.Id, owner.Token);
            var cards = this.cardRepository.GetAll();
            var card = cards.FirstOrDefault(c => c.Name == "Coffee");
            var vote = new Vote(card.Id, user.Id);
            this.discussionService.Vote(vote, discussion.Id, room.Id, user.Token);
            Assert.AreEqual(true, discussion.Votes.Contains(vote));
        }

        [Test]
        public void GetVotingResults()
        {
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var user = this.userService.Create("UserName");
            this.roomService.AddUser(user.Id, room.Id);
            var discussion = this.discussionService.Start("DiscName", room.Id, owner.Token);
            var cards = this.cardRepository.GetAll();
            var card = cards.FirstOrDefault(c => c.Name == "Coffee");
            var vote = new Vote(card.Id, user.Id);
            this.discussionService.Vote(vote, discussion.Id, room.Id, user.Token);
            var results = this.discussionService.GetResults(discussion.Id);
            Assert.AreEqual(discussion.Votes, results);
        }

        [Test]
        public void ThrowException()
        {
            var owner = this.userService.Create("OwnerName");
            var room = this.roomService.Create("RoomName", owner.Id);
            var user = this.userService.Create("UserName");
            var discussion = this.discussionService.Start("DiscussionName", room.Id, owner.Token);
            var cards = this.cardRepository.GetAll();
            var card = cards.FirstOrDefault(c => c.Name == "Coffee");
            var vote = new Vote(card.Id, user.Id);
            Assert.Multiple(() =>
            {
                Assert.Throws<UnauthorizedAccessException>(() => this.discussionService.Start("DiscName", room.Id, "token"));
                Assert.Throws<FormatException>(() => this.discussionService.Start(string.Empty, room.Id, owner.Token));
                Assert.Throws<UnauthorizedAccessException>(() => this.discussionService.Close(discussion.Id, room.Id, "token"));
                Assert.Throws<UnauthorizedAccessException>(() => this.discussionService.Vote(vote, discussion.Id, room.Id, "token"));
            });
        }
    }
}
