using DataService;
using DataService.Models;
using PlanPoker.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервис обсуждения.
    /// </summary>
    public class DiscussionService
    {
        public readonly IRepository<Discussion> repository;

        public DiscussionService(IRepository<Discussion> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Начать обсуждение.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        public Discussion Start(string name)
        {
            var newDiscussion = new Discussion(name);
            newDiscussion.StartAt = DateTime.Now;
            this.repository.Save(newDiscussion);
            return newDiscussion;
        }

        /// <summary>
        /// Закрыть обсуждение.
        /// </summary>
        public Discussion Close(Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            discussion.EndAt = DateTime.Now;
            this.repository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Добавить оценку.
        /// </summary>
        /// <param name="vote">Оценка участника.</param>
        public Discussion AddVote(Vote vote, Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            discussion.Votes.Add(vote);
            this.repository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Изменить оценку.
        /// </summary>
        /// <param name="newVote">Новая оценка участника.</param>
        public Discussion ChangeVote(Vote newVote, Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            var oldVote = (Vote)discussion.Votes.Where(v => v.UserId == newVote.UserId).Select(v=>v);
            discussion.Votes.Remove(oldVote);
            discussion.Votes.Add(newVote);
            this.repository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Получить результаты голосования.
        /// </summary>
        /// <returns>Коллекция голосов.</returns>
        public List<Vote> GetResults(Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            return discussion.Votes;
        }
    }
}
