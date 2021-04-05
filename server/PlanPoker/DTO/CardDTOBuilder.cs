using DataService.Models;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Конструктор DTO карты.
    /// </summary>
    public class CardDTOBuilder
    {
        /// <summary>
        /// Создать DTO карты.
        /// </summary>
        /// <param name="card">Карта.</param>
        /// <returns>DTO карты.</returns>
        public CardDTO Builder(Card card)
        {
            var cardDTO = new CardDTO();
            cardDTO.Id = card.Id;
            cardDTO.Name = card.Name;
            cardDTO.Value = card.Value;
            return cardDTO;
        }
    }
}
