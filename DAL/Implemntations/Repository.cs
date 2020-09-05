using Context;
using DAL.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Implemntations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DataContext context;
        private DbSet<T> entities;
        public Repository(DataContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(int id)
        {
            T entity = entities.AsNoTracking().SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsNoTracking().AsEnumerable();
        }

        public IEnumerable<T> GetAllByCreatedAt(DateTime dateTime)
        {
            return entities.AsNoTracking().Where(s => s.CreatedAt == dateTime).AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.AsNoTracking().SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
