using DataService;
using DataService.Models;
using PlanPoker.DTO;
using System.Collections.Generic;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервис карт.
    /// </summary>
    public class CardService
    {
        /// <summary>
        /// Репозиторий карт.
        /// </summary>
        private readonly IRepository<Card> repository;

        /// <summary>
        /// Конструктор сервиса карт.
        /// </summary>
        /// <param name="repository">Репозиторий карт.</param>
        public CardService(IRepository<Card> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Создать деку.
        /// </summary>
        /// <returns>Список DTO карт.</returns>
        public IEnumerable<CardDTO> CreateDeck()
        {
            var deckDTO = new List<CardDTO>();
            for (int i = 0; i < 10; i++)
            {
                var card = new Card(i.ToString(), i);
                this.repository.Save(card);
                var cardDTO = new CardDTOBuilder();
                deckDTO.Add(cardDTO.Builder(card));
            }

            return deckDTO;
        }
    }
}
