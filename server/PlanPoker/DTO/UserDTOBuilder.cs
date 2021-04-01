using DataService.Models;
using System;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class UserDTOBuilder
    {
        public UserDTO Builder(User user)
        {
            var userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.Name = user.Name;
            userDTO.Token = user.Token;
            return userDTO;
        }
    }
}
