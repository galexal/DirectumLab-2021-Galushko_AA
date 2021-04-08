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
        /// Сохранить экземпляр сущности.
        /// </summary>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns>Cущность.</returns>
        T Save(T entity);

        /// <summary>
        /// Получение экземпляра сущности по ид.
        /// </summary>
        /// <param name="id">Ид.</param>
        /// <returns>Экземпляр сущности.</returns>
        T Get(Guid id);

        /// <summary>
        /// Получить все экземпляры сущности.
        /// </summary>
        /// <returns>Все экземпляры сущности.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Удалить экземпляр сущности.
        /// </summary>
        /// <param name="id">Ид сущности.</param>
        /// <returns>Экземпляр сущности.</returns>
        T Delete(Guid id);
    }
}
