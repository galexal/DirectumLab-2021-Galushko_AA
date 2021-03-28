using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public User Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public User Save(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public User Get(Guid id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        public IQueryable<User> GetAll() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public User Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
