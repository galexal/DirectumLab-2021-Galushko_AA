using Microsoft.AspNetCore.Mvc;
using PlanPoker.DTO;
using PlanPoker.Services;
using System;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="userService">Сервис пользователя.</param>
        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public UserDTO Create(string name)
        {
            return this.userService.Create(name);
        }

        [HttpGet]
        public UserDTO ChangeName(string newName, Guid userId, string token)
        {
            return this.userService.ChangeName(newName, userId, token);
        }
    }
}
