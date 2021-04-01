using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервис пользователя.
    /// </summary>
    public class CardService
    {
        public readonly IRepository<Card> repository;

        public CardService(IRepository<Card> repository)
        {
            this.repository = repository;
        }

        public List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                var card = new Card(i.ToString(),i);
                this.repository.Save(card);
                deck.Add(card);
            }
            return deck;
        }
    }
}
