using System;

namespace DataService.Models
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор пользователя.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public User(string name) : base(Guid.NewGuid())
        {
            this.Name = name;
        }
    }
}
