using DataService.Models;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Конструктор DTO комнаты.
    /// </summary>
    public class RoomDTOBuilder
    {
        /// <summary>
        /// Создать DTO комнаты.
        /// </summary>
        /// <param name="room">Комната.</param>
        /// <returns>DTO комнаты.</returns>
        public RoomDTO Builder(Room room)
        {
            var roomDTO = new RoomDTO();
            roomDTO.Id = room.Id;
            roomDTO.Name = room.Name;
            roomDTO.OwnerId = room.OwnerId;
            roomDTO.Participants = room.Participants;
            roomDTO.Discussions = room.Discussions;
            return roomDTO;
        }
    }
}
