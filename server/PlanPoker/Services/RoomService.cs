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
        /// <summary>
        /// Репозиторий комнаты.
        /// </summary>
        private readonly IRepository<Room> roomRepository;

        /// <summary>
        /// Репозиторий пользователей.
        /// </summary>
        private readonly IRepository<User> userRepository;

        /// <summary>
        /// Конструктор сервиса комнаты.
        /// </summary>
        /// <param name="roomRepository">Репозиторий комнаты.</param>
        /// <param name="userRepository">Репозиторий пользователей.</param>
        public RoomService(IRepository<Room> roomRepository, IRepository<User> userRepository)
        {
            this.roomRepository = roomRepository;
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Создать комнату.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Ид хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        public Room Create(string name, Guid ownerId)
        {
            if (string.IsNullOrEmpty(name))
                throw new FormatException("Имя комнаты не может быть пустым.");
            var newRoom = new Room(name, ownerId);
            this.roomRepository.Save(newRoom);
            return newRoom;
        }

        /// <summary>
        /// Получить состояние комнаты.
        /// </summary>
        /// <param name="roomId">Ид комнаты.</param>
        /// <returns>Комната.</returns>
        public Room Get(Guid roomId)
        {
            return this.roomRepository.Get(roomId);
        }

        /// <summary>
        /// Добавить пользователя в комнату.
        /// </summary>
        /// <param name="userId">ИД пользователя.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <returns>Комната.</returns>
        public Room AddUser(Guid userId, Guid roomId)
        {
            var room = this.roomRepository.Get(roomId);
            room.Participants.Add(userId);
            this.roomRepository.Save(room);
            return room;
        }

        /// <summary>
        /// Удалить порльзователя из комнаты.
        /// </summary>
        /// <param name="userId">ИД пользователя.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен пользователя или хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        public Room RemoveUser(Guid userId, Guid roomId, string token)
        {
            var room = this.roomRepository.Get(roomId);
            var ownerId = room.OwnerId;
            var owner = this.userRepository.Get(ownerId);
            var user = this.userRepository.Get(userId);
            if (!(owner.Token.Equals(token) || user.Token.Equals(token)))
                throw new UnauthorizedAccessException("Удалить другого пользователя может только хозяин комнаты.");
            room.Participants.Remove(userId);
            this.roomRepository.Save(room);
            return room;
        }

        /// <summary>
        /// Изменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">ИД нового хозяина комнаты.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен текущего хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        public Room ChangeOwner(Guid userId, Guid roomId, string token)
        {
            var room = this.roomRepository.Get(roomId);
            var ownerId = room.OwnerId;
            var owner = this.userRepository.Get(ownerId);
            if (!owner.Token.Equals(token))
                throw new UnauthorizedAccessException("Сменить хозяина комнаты может только текущий хозяин комнаты.");
            room.OwnerId = userId;
            this.roomRepository.Save(room);
            return room;
        }
    }
}
