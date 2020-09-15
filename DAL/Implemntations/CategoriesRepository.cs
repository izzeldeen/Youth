using Context;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Implemntations
{
    public class CategoriesRepository : ICategoriesRepository
    {
        protected static readonly DataContext context = new DataContext();

        protected static IRepository<Category> _repository;

        public CategoriesRepository(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _repository.GetAll();
        }

        public Category GetCategoryById(int Id)
        {
            return _repository.GetById(Id);
        }

        public Category Insert(CategoryDto model)
        {
            var category = new Category { NameAr = model.NameAr, NameEn = model.NameEn, CreatedAt = DateTime.Now, Banner = model.Banner };

            _repository.Insert(category);

            return category;
        }

        public void Update(Category model)
        {
            _repository.Update(model);
        }

        public IEnumerable<Category> GetLastFourCategories() => context.Categories.OrderByDescending(x => x.UpdatedAt).Take(4);
        
    }
}
