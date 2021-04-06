using DataService.Models;
using System.Collections.Generic;

namespace DataService.Repositories
{
    /// <summary>
    /// Репозиторий для карт.
    /// </summary>
    public class CardRepository : InMemoryRepository<Card> 
    {
        /// <summary>
        /// Конструктор репозитория карт.
        /// </summary>
        public CardRepository()
        {
            var cardRepository = new CardRepository();
            for (int i = 0; i < 10; i++)
            {
                var card = new Card(i.ToString(), i);
                cardRepository.Save(card);
            }
        }
    }
}
