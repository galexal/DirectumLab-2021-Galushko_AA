using DataService.Models;

namespace PlanPoker.DTO
{
    /// <summary>
    /// Конструктор DTO обсуждения.
    /// </summary>
    public class DiscussionDTOBuilder
    {
        /// <summary>
        /// Создать DTO обсуждения.
        /// </summary>
        /// <param name="discussion">Обсуждение.</param>
        /// <returns>DTO обсуждения.</returns>
        public DiscussionDTO Builder(Discussion discussion)
        {
            var discussionDTO = new DiscussionDTO();
            discussionDTO.Id = discussion.Id;
            discussionDTO.Name = discussion.Name;
            discussionDTO.StartAt = discussion.StartAt;
            discussionDTO.EndAt = discussion.EndAt;
            discussionDTO.Votes = discussion.Votes;
            return discussionDTO;
        }
    }
}
