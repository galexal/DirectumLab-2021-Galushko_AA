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
        private readonly IRepository<Discussion> discussionRepository;

        /// <summary>
        /// Репозиторий комнаты.
        /// </summary>
        private readonly IRepository<Room> roomRepository;

        /// <summary>
        /// Репозиторий пользователей.
        /// </summary>
        private readonly IRepository<User> userRepository;

        /// <summary>
        /// Конструктор сервиса обсуждений.
        /// </summary>
        /// <param name="discussionRepository">Репозиторий обсуждений.</param>
        /// <param name="roomRepository">Репозиторий комнаты.</param>
        /// <param name="userRepository">Репозиторий пользователей.</param>
        public DiscussionService(IRepository<Discussion> discussionRepository, IRepository<Room> roomRepository, IRepository<User> userRepository)
        {
            this.discussionRepository = discussionRepository;
            this.roomRepository = roomRepository;
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Начать обсуждение.
        /// </summary>
        /// <param name="name">Имя обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Обсуждение.</returns>
        public Discussion Start(string name, Guid roomId, string token)
        {
            var room = this.roomRepository.Get(roomId);
            var ownerId = room.OwnerId;
            var owner = this.userRepository.Get(ownerId);
            if (!owner.Token.Equals(token))
                throw new UnauthorizedAccessException("Начать дискуссию может только хозяин комнаты.");
            if (string.IsNullOrEmpty(name))
                throw new FormatException("Тема дискуссии не может быть пустой.");
            var newDiscussion = new Discussion(name);
            newDiscussion.StartAt = DateTime.Now;
            this.discussionRepository.Save(newDiscussion);
            return newDiscussion;
        }

        /// <summary>
        /// Закрыть обсуждение.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен хозяина комнаты.</param>
        /// <returns>Обсуждение.</returns>
        public Discussion Close(Guid discussionId, Guid roomId, string token)
        {
            var room = this.roomRepository.Get(roomId);
            var ownerId = room.OwnerId;
            var owner = this.userRepository.Get(ownerId);
            if (!owner.Token.Equals(token))
                throw new UnauthorizedAccessException("Закрыть дискуссию может только хозяин комнаты.");
            var discussion = this.discussionRepository.Get(discussionId);
            discussion.EndAt = DateTime.Now;
            this.discussionRepository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Добавить или изменить оценку.
        /// </summary>
        /// <param name="vote">Оценка пользователя.</param>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <param name="roomId">Ид комнаты.</param>
        /// <param name="token">Токен пользователя.</param>
        /// <returns>Обсуждение.</returns>
        public Discussion Vote(Vote vote, Guid discussionId, Guid roomId, string token)
        {
            var room = this.roomRepository.Get(roomId);
            var user = this.userRepository.Get(vote.UserId);
            if (!(user.Token.Equals(token) && room.Participants.Contains(user.Id)))
                throw new UnauthorizedAccessException("Проголосовать может только сам участник комнаты.");
            var discussion = this.discussionRepository.Get(discussionId);
            var oldVote = discussion.Votes.Where(v => v.UserId == vote.UserId).Select(v => v);
            if (discussion.Votes.Contains(oldVote.ElementAt(0)))
                discussion.Votes.Remove(oldVote.ElementAt(0));
            discussion.Votes.Add(vote);
            this.discussionRepository.Save(discussion);
            return discussion;
        }

        /// <summary>
        /// Получить результаты голосования.
        /// </summary>
        /// <param name="discussionId">Ид обсуждения.</param>
        /// <returns>Коллекция голосов.</returns>
        public IEnumerable<Vote> GetResults(Guid discussionId)
        {
            var discussion = this.discussionRepository.Get(discussionId);
            return discussion.Votes;
        }
    }
}
