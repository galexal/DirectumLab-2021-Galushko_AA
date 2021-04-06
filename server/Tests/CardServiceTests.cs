using DataService.Repositories;
using NUnit.Framework;
using PlanPoker.Services;
using System.Linq;

namespace Tests
{
    public class CardServiceTests
    {
        private CardService cardService;
        private CardRepository cardRepository;

        [OneTimeSetUp]
        public void CreateServiceAndRepository()
        {
            this.cardRepository = new CardRepository();
            this.cardService = new CardService(this.cardRepository);
        }

        [Test]
        public void GetCard()
        {
            var cards = this.cardRepository.GetAll();
            var card = cards.FirstOrDefault(c => c.Name == "Coffee");
            Assert.AreEqual(card, this.cardService.GetCard(card.Id));
        }
    }
}
