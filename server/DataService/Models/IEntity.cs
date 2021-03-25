using System;

namespace DataService.Models
{
    /// <summary>
    /// Интерфейс идентификатора.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        Guid Id { get; }
    }
}
