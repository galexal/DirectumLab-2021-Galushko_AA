using System;

namespace DataService.Models
{
    /// <summary>
    /// Сущность пользователь.
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Токен пользователя.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Конструктор пользователя.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        public User(string name) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.Token = Guid.NewGuid().ToString();
        }
    }
}
