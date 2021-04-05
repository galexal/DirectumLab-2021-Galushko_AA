using System;
using System.Collections.Generic;

namespace DataService.Models
{
    /// <summary>
    /// Сущность комната.
    /// </summary>
    public class Room : Entity
    {
        /// <summary>
        /// Имя комнаты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Хозяин комнаты.
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Участники комнаты.
        /// </summary>
        public ICollection<Guid> Participants { get; }

        /// <summary>
        /// Обсуждения в комнате.
        /// </summary>
        public ICollection<Guid> Discussions { get; }

        /// <summary>
        /// Конструктор комнаты.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        public Room(string name, Guid ownerId) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.OwnerId = ownerId;
            this.Participants = new List<Guid>();
            this.Discussions = new List<Guid>();
        }
    }
}
