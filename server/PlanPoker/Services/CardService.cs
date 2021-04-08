using DataService;
using DataService.Models;
using System;

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
        /// Получить карту.
        /// </summary>
        /// <param name="cardId">Ид карты.</param>
        /// <returns>Карта.</returns>
        public Card GetCard(Guid cardId)
        {
            return this.repository.Get(cardId);
        }
    }
}
