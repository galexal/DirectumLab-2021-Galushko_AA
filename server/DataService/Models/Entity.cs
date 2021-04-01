using System;

namespace DataService.Models
{
    public class Entity : IEntity, IEquatable<Entity>
    {
        public Guid Id { get; }

        public Entity(Guid id)
        {
            this.Id = id;
        }

        public bool Equals(Entity other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
