using DataService;
using DataService.Models;
using System;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервис комнаты.
    /// </summary>
    public class RoomService
    {
        public readonly IRepository<Room> repository;

        public RoomService(IRepository<Room> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Создать комнату.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        public Room Create(string name, Guid ownerId)
        {
            var newRoom = new Room(name, ownerId);
            this.repository.Save(newRoom);
            return newRoom;
        }

        /// <summary>
        /// Добавить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room AddUser(Guid userId, Guid roomId)
        {
            var room = this.repository.Get(roomId);
            room.Participants.Add(userId);
            this.repository.Save(room);
            return room;
        }

        /// <summary>
        /// Удалить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room RemoveUser(Guid userId, Guid roomId)
        {
            var room = this.repository.Get(roomId);
            room.Participants.Remove(userId);
            this.repository.Save(room);
            return room;
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room ChangeOwner(Guid userId, Guid roomId)
        {
            var room = this.repository.Get(roomId);
            room.OwnerId = userId;
            this.repository.Save(room);
            return room;
        }
    }
}
