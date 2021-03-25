using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// Создаnть комнату.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Хозяин комнаты.</param>
        /// <returns>Новая комната.</returns>
        public void Create(string name, Guid ownerId)
        {
            this.CurrentRoom = new Room(name, ownerId);
        }

        /// <summary>
        /// Добавить участника.
        /// </summary>
        /// <param name="user">ИД участника.</param>
        public void AddUser(Guid userId)
        {
            if (!this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.Participants.Append(userId);
        }

        /// <summary>
        /// Удалить участника.
        /// </summary>
        /// <param name="user">ИД участника.</param>
        public void RemoveUser(Guid userId)
        {
            if(this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.Participants.Remove(userId);
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="user">ИД участника.</param>
        public void ChangeOwner(Guid userId)
        {
            if (this.CurrentRoom.Participants.Contains(userId))
                this.CurrentRoom.OwnerId = userId;
        }
    }
}
