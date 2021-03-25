using System;

namespace DataService.Models
{
    /// <summary>
    /// Участник.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор участника.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public User(string name)
        {
            this.Name = name;
        }
    }
}
