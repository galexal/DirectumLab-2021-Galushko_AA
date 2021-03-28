using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repositories
{
    public class VoteRepository : IRepository<Vote>
    {
        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public Vote Save(Vote entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Vote Get(Guid id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        public IQueryable<Vote> GetAll() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Vote Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
