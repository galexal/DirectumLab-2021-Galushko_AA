using System;

namespace PlanPoker.ValueObject
{
    /// <summary>
    /// Оценка (объект-значение).
    /// </summary>
    public struct Vote : IEquatable<Vote>
    {
        /// <summary>
        /// Ид карты.
        /// </summary>
        public Guid CardId { get; }

        /// <summary>
        /// Ид пользователя.
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Конструктор оценки.
        /// </summary>
        /// <param name="cardId">Ид карты.</param>
        /// <param name="userId">Ид пользователя.</param>
        public Vote(Guid cardId, Guid userId)
        {
            this.CardId = cardId;
            this.UserId = userId;
        }

        /// <summary>
        /// Сравнение оценок.
        /// </summary>
        /// <param name="other">Сравниваемая оценка.</param>
        /// <returns>Результат сравнения.</returns>
        public bool Equals(Vote other)
        {
            return this.CardId.Equals(other.CardId) && this.UserId.Equals(other.UserId);
        }
    }
}
