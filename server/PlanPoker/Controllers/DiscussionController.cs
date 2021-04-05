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
        /// <returns>Обсуждение.</returns>
        [HttpGet]
        public DiscussionDTO Start(string name)
        {
            var discussion = this.discussionService.Start(name);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Закрытие обсуждения.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
        [HttpGet]
        public DiscussionDTO Close(Guid discussionId)
        {
            var discussion = this.discussionService.Close(discussionId);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Добавить голос.
        /// </summary>
        /// <param name="vote">Голос.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
        [HttpPost]
        public DiscussionDTO AddVote(Vote vote, Guid discussionId)
        {
            var discussion = this.discussionService.AddVote(vote, discussionId);
            return new DiscussionDTOBuilder().Builder(discussion);
        }

        /// <summary>
        /// Изменить голос.
        /// </summary>
        /// <param name="newVote">Новый голос.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
        [HttpGet]
        public DiscussionDTO ChangeVote(Vote newVote, Guid discussionId)
        {
            var discussion = this.discussionService.ChangeVote(newVote, discussionId);
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
