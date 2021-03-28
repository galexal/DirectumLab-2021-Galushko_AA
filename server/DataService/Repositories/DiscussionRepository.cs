using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repositories
{
    public class DiscussionRepository : IRepository<Discussion>
    {
        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public Discussion Save(Discussion entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Discussion Get(Guid id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        public IQueryable<Discussion> GetAll() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Discussion Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
