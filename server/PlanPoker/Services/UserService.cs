using DataService;
using DataService.Models;
using PlanPoker.DTO;
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
        public UserDTO Create(string name)
        {
            var newUser = new User(name);
            this.repository.Save(newUser);
            return new UserDTOBuilder().Builder(newUser);

        }

        /// <summary>
        /// Изменить имя пользователя.
        /// </summary>
        /// <param name="newName">Новое имя пользователя.</param>
        public UserDTO ChangeName(string newName, Guid userId, string token)
        {
            var user = this.repository.Get(userId);
            if (!user.Token.Equals(token))
                throw new UnauthorizedAccessException();
            user.Name = newName;
            this.repository.Save(user);
            return new UserDTOBuilder().Builder(user);
        }
    }
}
