using DataService;
using DataService.Models;
using System;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервис пользователя.
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Репозиторий пользователей.
        /// </summary>
        private readonly IRepository<User> repository;

        /// <summary>
        /// Конструктор сервиса пользователей.
        /// </summary>
        /// <param name="repository">Репозиторий пользователей.</param>
        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Создать пользователя.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        /// <returns>Пользователь.</returns>
        public User Create(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new FormatException("Имя пользователя не может быть пустым");
            var newUser = new User(name);
            this.repository.Save(newUser);
            return newUser;
        }

        /// <summary>
        /// Изменить имя пользователя.
        /// </summary>
        /// <param name="newName">Новое имя пользователя.</param>
        /// <param name="userId">Ид пользователя.</param>
        /// <param name="token">Токен пользователя.</param>
        /// <returns>Пользователь.</returns>
        public User ChangeName(string newName, Guid userId, string token)
        {
            if (string.IsNullOrEmpty(newName))
                throw new FormatException("Имя пользователя не может быть пустым");
            var user = this.repository.Get(userId);
            if (user == null || !user.Token.Equals(token))
                throw new UnauthorizedAccessException("Сменить имя может только сам пользователь.");
            user.Name = newName;
            this.repository.Save(user);
            return user;
        }
    }
}
