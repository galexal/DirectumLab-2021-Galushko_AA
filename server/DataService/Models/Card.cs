using System;

namespace DataService.Models
{
    public class Card : Entity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="value">Значение.</param>
        /// <param name="userId">Идентификатор участника.</param>
        public Card(string name, double? value) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
