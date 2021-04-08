using DataService.Models;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Конструктор DTO пользователя.
    /// </summary>
    public class UserDTOBuilder
    {
        /// <summary>
        /// Создать DTO пользователя.
        /// </summary>
        /// <param name="user">Пользователь.</param>
        /// <returns>DTO пользователя.</returns>
        public UserDTO Builder(User user)
        {
            var userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.Name = user.Name;
            return userDTO;
        }
    }
}
