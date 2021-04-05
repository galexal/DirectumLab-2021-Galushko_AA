using Microsoft.AspNetCore.Mvc;
using PlanPoker.DTO;
using PlanPoker.Services;
using System.Collections.Generic;

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
        /// Создание деки.
        /// </summary>
        /// <returns>Список карт.</returns>
        [HttpGet]
        public IEnumerable<CardDTO> CreateDeck()
        {
            return this.cardService.CreateDeck();
        }
    }
}
