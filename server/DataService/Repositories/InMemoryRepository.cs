using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataService.Repositories
{
    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly IList<T> entities = new List<T>();

        public T Get(Guid id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public T Save(T entity)
        {
            if (!entities.Contains(entity))
                this.entities.Add(entity);
            else 
            {
                entities.Remove(entity);
                entities.Add(entity);
            } 
            
            return entity;
        }

        public T Delete(Guid id)
        {
            var entity = this.entities.SingleOrDefault(e => e.Id == id);
            entities.Remove(entity);
            return entity;
        }
    }
}
