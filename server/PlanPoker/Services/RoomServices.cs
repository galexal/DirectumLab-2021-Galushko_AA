using DataService.Models;
using System;
using System.Linq;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервисы комнаты.
    /// </summary>
    public class RoomServices
    {
        /// <summary>
        /// Состояние текущей комнаты.
        /// </summary>
        public Room CurrentRoom { get; set; }

        /// <summary>
        /// Создать комнату.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        public void Create(string name, Guid ownerId)
        {
            this.CurrentRoom = new Room(name, ownerId);
        }

        /// <summary>
        /// Добавить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void AddUser(Guid userId)
        {
            if (!this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.Participants.Append(userId);
        }

        /// <summary>
        /// Удалить участника.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void RemoveUser(Guid userId)
        {
            if (this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.Participants.Remove(userId);
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">ИД участника.</param>
        public void ChangeOwner(Guid userId)
        {
            if (this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.OwnerId = userId;
        }
    }
}
