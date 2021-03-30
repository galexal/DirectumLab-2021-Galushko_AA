using System;

namespace DataService.Models
{
    public class Entity : IEntity
    {
        public Guid Id { get; }

        public Entity(Guid id)
        {
            this.Id = id;
        }
    }
}
