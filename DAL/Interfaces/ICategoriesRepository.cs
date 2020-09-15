using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> GetCategories();
        Category Insert(CategoryDto model);
        void Delete(int Id);
        void Update(Category model);
        Category GetCategoryById(int Id);
        IEnumerable<Category> GetLastFourCategories();

    }
}
