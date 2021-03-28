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
        /// Начать обсуждение.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        public void Start(string name)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Изменить оценку.
        /// </summary>
        /// <param name="oldVote">Старая оценка участника.</param>
        /// <param name="newVote">Новая оценка участника.</param>
        public void ChangeVote(Vote oldVote, Vote newVote)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получить результаты голосования.
        /// </summary>
        /// <returns>Коллекция голосов.</returns>
        public List<Vote> GetResults()
        {
            throw new NotImplementedException();
        }
    }
}
