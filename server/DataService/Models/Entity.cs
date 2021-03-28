using System;
using System.Collections.Generic;
using System.Text;

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
