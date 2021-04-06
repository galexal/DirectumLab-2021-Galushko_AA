using Microsoft.AspNetCore.Mvc;
using PlanPoker.DTO;
using PlanPoker.Services;
using System;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер карт.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CardController : ControllerBase
    {
        /// <summary>
        /// Сервис карт.
        /// </summary>
        private readonly CardService cardService;

        /// <summary>
        /// Конструктор контроллера карт.
        /// </summary>
        /// <param name="cardService">Сервис карт.</param>
        public CardController(CardService cardService)
        {
            this.cardService = cardService;
        }

        /// <summary>
        /// Получить карту.
        /// </summary>
        /// <param name="cardId">Ид карты.</param>
        /// <returns>Карта.</returns>
        [HttpGet]
        public CardDTO GetCard(Guid cardId)
        {
            var card = this.cardService.GetCard(cardId);
            return new CardDTOBuilder().Builder(card);
        }
    }
}
