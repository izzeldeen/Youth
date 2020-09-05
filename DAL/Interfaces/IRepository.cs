using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByCreatedAt(DateTime dateTime);
        T GetById(int Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int Id);
    }
}
