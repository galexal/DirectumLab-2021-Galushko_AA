using System;
using System.Collections.Generic;

namespace DataService.Models
{
    /// <summary>
    /// Обсуждение.
    /// </summary>
    public class Discussion
    {
        /// <summary>
        /// Идентификатор обсуждения.
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

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
        public List<Vote> Votes { get; set; }

        /// <summary>
        /// Конструктор обсуждения.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        public Discussion(string name)
        {
            this.Name = name;
            this.StartAt = DateTime.Now;
        }
    }
}
