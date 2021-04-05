using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataService.Repositories
{
    /// <summary>
    /// Базовый репозиторий.
    /// </summary>
    /// <typeparam name="T">Тип репозитория.</typeparam>
    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Список сущностей.
        /// </summary>
        private readonly IList<T> entities = new List<T>();

        /// <summary>
        /// Получение экземпляра сущности по ид.
        /// </summary>
        /// <param name="id">Ид.</param>
        /// <returns>Экземпляр сущности.</returns>
        public T Get(Guid id)
        {
            return this.entities.SingleOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Получить все экземпляры сущности.
        /// </summary>
        /// <returns>Все экземпляры сущности.</returns>
        public IQueryable<T> GetAll()
        {
            return this.entities.AsQueryable();
        }

        /// <summary>
        /// Сохранить экземпляр сущности.
        /// </summary>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns>Cущность.</returns>
        public T Save(T entity)
        {
            if (!this.entities.Contains(entity))
                this.entities.Add(entity);
            else
            {
                this.entities.Remove(entity);
                this.entities.Add(entity);
            }

            return entity;
        }

        /// <summary>
        /// Удалить экземпляр сущности.
        /// </summary>
        /// <param name="id">Ид сущности.</param>
        /// <returns>Экземпляр сущности.</returns>
        public T Delete(Guid id)
        {
            var entity = this.entities.SingleOrDefault(e => e.Id == id);
            this.entities.Remove(entity);
            return entity;
        }
    }
}
