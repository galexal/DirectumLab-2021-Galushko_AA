using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlanPoker.DTO;
using PlanPoker.Services;
using System;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер комнаты.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RoomController : ControllerBase
    {
        /// <summary>
        /// Сервис комнаты.
        /// </summary>
        private readonly RoomService roomService;

        /// <summary>
        /// Конструктор контроллера комнаты.
        /// </summary>
        /// <param name="roomService">Сервис комнаты.</param>
        public RoomController(RoomService roomService)
        {
            this.roomService = roomService;
        }

        /// <summary>
        /// Создание комнаты.
        /// </summary>
        /// <param name="name">Имя комнаты.</param>
        /// <param name="ownerId">Ид хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        [HttpGet]
        public RoomDTO Create(string name, Guid ownerId)
        {
            var room = this.roomService.Create(name, ownerId);
            return new RoomDTOBuilder().Builder(room);
        }

        /// <summary>
        /// Добавить пользователя в комнату.
        /// </summary>
        /// <param name="userId">Ид пользователя.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        [HttpGet]
        public RoomDTO AddUser(Guid userId, Guid roomId, string token)
        {
            var room = this.roomService.AddUser(userId, roomId, token);
            return new RoomDTOBuilder().Builder(room);
        }

        /// <summary>
        /// Удалить пользователя из комнаты.
        /// </summary>
        /// <param name="userId">Ид пользователя.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        [HttpGet]
        public RoomDTO RemoveUser(Guid userId, Guid roomId, string token)
        {
            var room = this.roomService.RemoveUser(userId, roomId, token);
            return new RoomDTOBuilder().Builder(room);
        }

        /// <summary>
        /// Сменить хозяина комнаты.
        /// </summary>
        /// <param name="userId">Ид нового хозяина комнаты.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен предыдущего хозяина комнаты.</param>
        /// <returns>Комната.</returns>
        [HttpGet]
        public RoomDTO ChangeOwner(Guid userId, Guid roomId, string token)
        {
            var room = this.roomService.ChangeOwner(userId, roomId, token);
            return new RoomDTOBuilder().Builder(room);
        }

        /// <summary>
        /// Получить состояние комнаты.
        /// </summary>
        /// <param name="roomId">Ид комнаты.</param>
        /// <returns>Комната.</returns>
        [HttpGet]
        public RoomDTO GetRoomDTO(Guid roomId)
        {
            var room = this.roomService.Get(roomId);
            return new RoomDTOBuilder().Builder(room);
        }
    }
}
