using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataService.Models;


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

        public void Save(T entity)
        {
            this.entities.Add(entity);
        }

        public void Delete(Guid id)
        {
            var entity=this.entities.SingleOrDefault(e=>e.Id==id);
            entities.Remove(entity);
        }
    }
}
