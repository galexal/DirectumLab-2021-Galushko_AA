using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public Room Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        public Room Save(Room entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Room Get(Guid id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        public IQueryable<Room> GetAll() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        public Room Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
