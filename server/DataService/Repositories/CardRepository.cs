using DataService.Models;

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
            double[] cardValues = { 0, 0.5, 1, 2, 3, 5, 8, 13, 20, 40, 100 };
            for (int i = 0; i < cardValues.Length; i++)
            {
                var card = new Card(cardValues[i].ToString(), cardValues[i]);
                this.Save(card);
            }

            this.Save(new Card("Question", null));
            this.Save(new Card("Coffee", null));
        }
    }
}
