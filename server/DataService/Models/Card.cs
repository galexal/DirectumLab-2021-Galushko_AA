using System;

namespace DataService.Models
{
    /// <summary>
    /// Сущность карта.
    /// </summary>
    public class Card : Entity
    {
        /// <summary>
        /// Имя карты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение карты.
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Конструктор карты.
        /// </summary>
        /// <param name="name">Имя карты.</param>
        /// <param name="value">Значение карты.</param>
        public Card(string name, double? value) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
