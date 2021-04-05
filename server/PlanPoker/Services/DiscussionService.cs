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
        /// <summary>
        /// Репозиторий обсуждений.
        /// </summary>
        private readonly IRepository<Discussion> repository;

        /// <summary>
        /// Конструктор сервиса обсуждений.
        /// </summary>
        /// <param name="repository">Репозиторий обсуждений.</param>
        public DiscussionService(IRepository<Discussion> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Начать обсуждение.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        /// <returns>Обсуждение.</returns>
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
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
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
        /// <param name="vote">Оценка пользователя.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
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
        /// <param name="newVote">Новая оценка пользователя.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Обсуждение.</returns>
        public Discussion ChangeVote(Vote newVote, Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            var oldVote = discussion.Votes.Where(v => v.UserId == newVote.UserId).Select(v => v);
            discussion.Votes.Remove(oldVote.ElementAt(0));
            discussion.Votes.Add(newVote);
            this.repository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Получить результаты голосования.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Коллекция голосов.</returns>
        public IEnumerable<Vote> GetResults(Guid discussionId)
        {
            var discussion = this.repository.Get(discussionId);
            return discussion.Votes;
        }
    }
}
