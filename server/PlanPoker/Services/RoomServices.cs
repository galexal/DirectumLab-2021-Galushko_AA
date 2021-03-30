using DataService.Models;
using DataService.Repositories;
using System;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервисы комнаты.
    /// </summary>
    public class RoomServices
    {
        public RoomRepository Repository { get; set; }

        /// <summary>
        /// Создать комнату.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        public Room Create(string name, Guid ownerId)
        {
            var newRoom = new Room(name, ownerId);
            this.Repository.Save(newRoom);
            return newRoom;
        }

        /// <summary>
        /// Добавить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room AddUser(Guid userId, Guid roomId)
        {
            var room = this.Repository.Get(roomId);
            room.Participants.Add(userId);
            this.Repository.Save(room);
            return room;
        }

        /// <summary>
        /// Удалить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room RemoveUser(Guid userId, Guid roomId)
        {
            var room = this.Repository.Get(roomId);
            room.Participants.Remove(userId);
            this.Repository.Save(room);
            return room;
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public Room ChangeOwner(Guid userId, Guid roomId)
        {
            var room = this.Repository.Get(roomId);
            room.OwnerId = userId;
            this.Repository.Save(room);
            return room;
        }
    }
}
