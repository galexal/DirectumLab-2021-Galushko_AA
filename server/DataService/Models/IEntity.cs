using System;

namespace DataService.Models
{
    /// <summary>
    /// Интерфейс сущности.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Ид.
        /// </summary>
        Guid Id { get; }
    }
}
