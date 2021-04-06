using Microsoft.AspNetCore.Mvc;
using PlanPoker.DTO;
using PlanPoker.Services;
using PlanPoker.ValueObject;
using System;
using System.Collections.Generic;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер обсуждений.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DiscussionController : ControllerBase
    {
        /// <summary>
        /// Сервис обсуждений.
        /// </summary>
        private readonly DiscussionService discussionService;

        /// <summary>
        /// Конструктор контроллера обсуждений.
        /// </summary>
        /// <param name="discussionService">Сервис обсуждений.</param>
        public DiscussionController(DiscussionService discussionService)
        {
            this.discussionService = discussionService;
        }

        /// <summary>
        /// Запуск обсуждения.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Обсуждение.</returns>
        [HttpGet]
        public DiscussionDTO Start(string name, Guid roomId, string token)
        {
            var discussion = this.discussionService.Start(name, roomId, token);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Закрытие обсуждения.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Обсуждение.</returns>
        [HttpGet]
        public DiscussionDTO Close(Guid discussionId, Guid roomId, string token)
        {
            var discussion = this.discussionService.Close(discussionId, roomId, token);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Добавить или изменить оценку.
        /// </summary>
        /// <param name="vote">Голос.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен пользователя.</param>
        /// <returns>Обсуждение.</returns>
        [HttpPost]
        public DiscussionDTO Vote(Vote vote, Guid discussionId, Guid roomId, string token)
        {
            var discussion = this.discussionService.Vote(vote, discussionId, roomId, token);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Получить результаты обсуждения.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Список голосов.</returns>
        [HttpGet]
        public IEnumerable<Vote> GetResults(Guid discussionId)
        {
            return this.discussionService.GetResults(discussionId);
        }
    }
}
