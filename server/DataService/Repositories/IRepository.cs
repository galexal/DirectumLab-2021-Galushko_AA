using DataService.Models;
using System;
using System.Linq;

namespace DataService
{
    /// <summary>
    /// Интерфейс репозитория.
    /// </summary>
    /// <typeparam name="T">Тип данных репозитория.</typeparam>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="entity">Объект для сохранения.</param>
        /// <returns>Сохраненный объект.</returns>
        T Save(T entity);

        /// <summary>
        /// Получение.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        T Get(Guid id);

        /// <summary>
        /// Получение всех.
        /// </summary>
        /// <returns>Коллекция.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Удаление.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Объект.</returns>
        T Delete(Guid id);
    }
}
