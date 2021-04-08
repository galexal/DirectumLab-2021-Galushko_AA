using System;

namespace PlanPoker.DTO
{
    /// <summary>
    /// DTO карты.
    /// </summary>
    public class CardDTO
    {
        /// <summary>
        /// Ид карты.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя карты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение карты.
        /// </summary>
        public double? Value { get; set; }
    }
}
