using System;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class UserDTO
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        public string Token { get; set; }
    }
}
