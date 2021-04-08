using System;

namespace PlanPoker.DTO
{
    /// <summary>
    /// DTO пользователя.
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// Ид пользователя.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }
    }
}
