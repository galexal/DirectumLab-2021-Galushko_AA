using System;
using System.Collections.Generic;

namespace PlanPoker.DTO
{
    /// <summary>
    /// DTO комнаты.
    /// </summary>
    public class RoomDTO
    {
        /// <summary>
        /// Ид комнаты.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя комнаты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ИД хозяина комнаты.
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Пользователи в комнате.
        /// </summary>
        public ICollection<Guid> Participants { get; set; }

        /// <summary>
        /// Обсуждения в комнате.
        /// </summary>
        public ICollection<Guid> Discussions { get; set; }
    }
}
