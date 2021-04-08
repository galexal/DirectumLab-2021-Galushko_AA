using PlanPoker.ValueObject;
using System;
using System.Collections.Generic;

namespace PlanPoker.DTO
{
    /// <summary>
    /// DTO обсуждения.
    /// </summary>
    public class DiscussionDTO
    {
        /// <summary>
        /// Ид обсуждения.
        /// </summary>
        public Guid Id { get; set; }

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
        public ICollection<Vote> Votes { get; set; }
    }
}
