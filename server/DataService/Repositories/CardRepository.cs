using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repositories
{
    public class CardRepository : IRepository<Card>
    {
        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public Card Save(Card entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Card Get(Guid id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        public IQueryable<Card> GetAll() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Card Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
