using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using PlanPoker.Services;
using PlanPoker.ValueObject;
using System;
using System.Collections.Generic;

namespace PlanPoker.Controllers
{
    /// <summary>
    /// Контроллер.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DiscussionController : ControllerBase
    {
        private readonly DiscussionService discussionService;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="roomService">Сервис.</param>
        public DiscussionController(DiscussionService discussionService)
        {
            this.discussionService = discussionService;
        }

        [HttpGet]
        public Discussion Start(string name)
        {
            return this.discussionService.Start(name);
        }

        [HttpGet]
        public Discussion Close(Guid discussionId)
        {
            return this.discussionService.Close(discussionId);
        }

        [HttpPost]
        public Discussion AddVote(Vote vote, Guid discussionId)
        {
            return this.discussionService.AddVote(vote, discussionId);
        }

        [HttpGet]
        public Discussion ChangeVote(Vote newVote, Guid discussionId)
        {
            return this.discussionService.ChangeVote(newVote, discussionId);
        }

        [HttpGet]
        public List<Vote> GetResults(Guid discussionId)
        {
            return this.discussionService.GetResults(discussionId);
        }
    }
}
