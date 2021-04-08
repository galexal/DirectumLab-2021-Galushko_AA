using PlanPoker.ValueObject;
using System;
using System.Collections.Generic;

namespace DataService.Models
{
    /// <summary>
    /// Сущность обсуждение.
    /// </summary>
    public class Discussion : Entity
    {
        /// <summary>
        /// Имя обсуждения.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Время начала обсуждения.
        /// </summary>
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Время окончания обсуждения.
        /// </summary>
        public DateTime EndAt { get; set; }

        /// <summary>
        /// Оценки.
        /// </summary>
        public ICollection<Vote> Votes { get; }

        /// <summary>
        /// Конструктор обсуждения.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        public Discussion(string name) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.StartAt = DateTime.Now;
            this.Votes = new List<Vote>();
        }
    }
}
