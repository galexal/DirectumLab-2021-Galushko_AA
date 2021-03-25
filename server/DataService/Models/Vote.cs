using System;

namespace DataService.Models
{
    /// <summary>
    /// Оценка.
    /// </summary>
    public class Vote
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public CardValues Value { get; set; }

        /// <summary>
        /// Идентификатор участника.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="value">Значение.</param>
        /// <param name="userId">Идентификатор участника.</param>
        public Vote(string name, CardValues value, Guid userId)
        {
            this.Name = name;
            this.Value = value;
            this.UserId = userId;
        }
    }

    /// <summary>
    /// Значения всех карт в колоде.
    /// </summary>
    public enum CardValues
    {
        /// <summary>
        /// Значение карты.
        /// </summary>
        one = 1,

        /// <summary>
        /// Значение карты.
        /// </summary>
        two,

        /// <summary>
        /// Значение карты.
        /// </summary>
        three
    }
}
