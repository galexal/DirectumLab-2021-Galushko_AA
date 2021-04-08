using System;

namespace DataService.Models
{
    /// <summary>
    /// Базовая сущность.
    /// </summary>
    public class Entity : IEntity, IEquatable<Entity>
    {
        /// <summary>
        /// Ид сущности.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Конструктор сущности.
        /// </summary>
        /// <param name="id">Ид.</param>
        public Entity(Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Сравнение сущностей.
        /// </summary>
        /// <param name="other">Сравниваемая сущность.</param>
        /// <returns>Результат сравнения.</returns>
        public bool Equals(Entity other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
