using System;

namespace DataService.Models
{
    /// <summary>
    /// Базовый интерфейс сущности.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        Guid Id { get; }
    }
}
