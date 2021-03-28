using DataService.Models;
using DataService.Repositories;
using System;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервисы участника.
    /// </summary>
    public class UserServices
    {
        public UserRepository Repository { get; set; }

        /// <summary>
        /// Создать учачтника.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public User Create(string name)
        {
            var newUser = this.Repository.Create();
            newUser.Name = name;
            this.Repository.Save(newUser);
            return newUser;

        }

        /// <summary>
        /// Изменить имя.
        /// </summary>
        /// <param name="newName">Новое имя.</param>
        public void ChangeName(string newName)
        {
            throw new NotImplementedException();
        }
    }
}
