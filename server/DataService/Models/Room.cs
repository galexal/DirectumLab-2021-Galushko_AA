using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models
{
    /// <summary>
    /// Комната.
    /// </summary>
    public class Room : IEntity
    {
        /// <summary>
        /// Id.
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Хозяин комнаты.
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Участники.
        /// </summary>
        public List<Guid> Participants { get; set; }

        /// <summary>
        /// Обсуждения.
        /// </summary>
        public List<Guid> Discussions { get; set; }

        /// <summary>
        /// Конструктор комнаты.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        public Room(string name, Guid ownerId)
        {
            this.Name = name;
            this.OwnerId = ownerId;
        }
    }
}
