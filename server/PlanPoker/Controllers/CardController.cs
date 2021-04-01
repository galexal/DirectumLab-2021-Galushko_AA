using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using PlanPoker.Services;
using System;
using System.Collections.Generic;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CardController : ControllerBase
    {
        private readonly CardService cardService;


        public CardController(CardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet]
        public List<Card> CreateDeck()
        {
            return this.cardService.CreateDeck();
        }
    }
}
