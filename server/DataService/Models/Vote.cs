using System;

namespace DataService.Models
{
    /// <summary>
    /// Оценка.
    /// </summary>
    public class Vote : Entity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public Card Value { get; set; }

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
        public Vote(string name, Card value, Guid userId) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.Value = value;
            this.UserId = userId;
        }
    }
}
