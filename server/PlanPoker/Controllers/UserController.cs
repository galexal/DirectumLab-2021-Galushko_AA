using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using PlanPoker.DTO;
using PlanPoker.Services;
using System;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Сервис пользователя.
        /// </summary>
        private readonly UserService userService;

        /// <summary>
        /// Конструктор контроллера пользователя.
        /// </summary>
        /// <param name="userService">Сервис пользователя.</param>
        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Создать пользователя.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        /// <returns>Пользователь.</returns>
        [HttpGet]
        public User Create(string name)
        {
            return this.userService.Create(name);
        }

        /// <summary>
        /// Сменить имя пользователя.
        /// </summary>
        /// <param name="newName">Новое имя пользователя.</param>
        /// <param name="userId">Ид пользователя.</param>
        /// <param name="token">Токен пользователя.</param>
        /// <returns>Пользователь.</returns>
        [HttpGet]
        public UserDTO ChangeName(string newName, Guid userId, string token)
        {
            var user = this.userService.ChangeName(newName, userId, token);
            return new UserDTOBuilder().Builder(user);
        }
    }
}
