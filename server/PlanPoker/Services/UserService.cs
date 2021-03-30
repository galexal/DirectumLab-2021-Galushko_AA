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
        public readonly IRepository<User> repository;

        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Создать пользователя.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        public User Create(string name)
        {
            var newUser = new User(name);
            this.repository.Save(newUser);
            return newUser;

        }

        /// <summary>
        /// Изменить имя пользователя.
        /// </summary>
        /// <param name="newName">Новое имя пользователя.</param>
        public User ChangeName(string newName, Guid userId)
        {
            var user = this.repository.Get(userId);
            user.Name = newName;
            this.repository.Save(user);
            return user;
        }
    }
}
