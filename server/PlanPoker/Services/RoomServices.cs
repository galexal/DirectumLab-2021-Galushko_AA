using DataService;
using DataService.Models;
using DataService.Repositories;
using System;
using System.Linq;

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
            var newRoom = this.Repository.Create();
            newRoom.Name = name;
            newRoom.OwnerId = ownerId;
            this.Repository.Save(newRoom);
            return newRoom;
        }

        /// <summary>
        /// Добавить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void AddUser(Guid userId, Room room)
        {
            if (!room.Participants.Contains(userId))
                room.Participants.Append(userId);
        }

        /// <summary>
        /// Удалить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void RemoveUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void ChangeOwner(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
