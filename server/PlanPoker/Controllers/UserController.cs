using DataService.Models;
using Microsoft.AspNetCore.Mvc;
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
        public User Create(string name)
        {
            return this.userService.Create(name);
        }

        [HttpGet]
        public User ChangeName(string newName, Guid userId)
        {
            return this.userService.ChangeName(newName, userId);
        }
    }
}
