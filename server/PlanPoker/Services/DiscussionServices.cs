using DataService.Models;
using System;
using System.Collections.Generic;

namespace PlanPoker.Services
{
    /// <summary>
    /// Сервисы обсуждения.
    /// </summary>
    public class DiscussionServices
    {
        /// <summary>
        /// Состояние текущего обсуждения.
        /// </summary>
        public Discussion CurrentDiscussion { get; set; }

        /// <summary>
        /// Начать обсуждение.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        public void Start(string name)
        {
            this.CurrentDiscussion = new Discussion(name);
        }

        /// <summary>
        /// Закрыть обсуждение.
        /// </summary>
        public void Close()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавить оценку.
        /// </summary>
        /// <param name="vote">Оценка участника.</param>
        public void AddVote(Vote vote)
        {
            if (!this.CurrentDiscussion.Votes.Contains(vote))
                this.CurrentDiscussion.Votes.Add(vote);
        }

        /// <summary>
        /// Изменить оценку.
        /// </summary>
        /// <param name="oldVote">Старая оценка участника.</param>
        /// <param name="newVote">Новая оценка участника.</param>
        public void ChangeVote(Vote oldVote, Vote newVote)
        {
            if (this.CurrentDiscussion.Votes.Contains(oldVote))
            {
                this.CurrentDiscussion.Votes.Remove(oldVote);
                this.CurrentDiscussion.Votes.Add(newVote);
            }
        }

        /// <summary>
        /// Получить результаты голосования.
        /// </summary>
        /// <returns>Коллекция голосов.</returns>
        public List<Vote> GetResults()
        {
            return this.CurrentDiscussion.Votes;
        }
    }
}
