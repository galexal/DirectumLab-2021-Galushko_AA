using System;

namespace PlanPoker.ValueObject
{
    /// <summary>
    /// Оценка.
    /// </summary>
    public class Vote
    {
        /// <summary>
        /// Значение.
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// Идентификатор участника.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="userId">Идентификатор участника.</param>
        public Vote(Guid cardId, Guid userId)
        {
            this.CardId = cardId;
            this.UserId = userId;
        }
    }
}
