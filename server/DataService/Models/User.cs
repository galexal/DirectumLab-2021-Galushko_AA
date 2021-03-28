using System;

namespace DataService.Models
{
    /// <summary>
    /// Участник.
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор участника.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public User(string name) : base(new Guid())
        {
            this.Name = name;
        }
    }
}
