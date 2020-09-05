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
    public class ProductsRepository : IProductsRepository
    {
        protected static readonly DataContext context = new DataContext();

        protected static IRepository<Product> _repository;

        public ProductsRepository(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public IEnumerable<Measurment> GetMeasurments()
        {
            return context.Measurments.AsEnumerable();
        }

        public Product GetProductById(int Id)
        {
            return _repository.GetById(Id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetAll();
        }

        public Product Insert(ProductDto model)
        {
            var product = new Product { NameAr = model.NameAr, NameEn = model.NameEn, CreatedAt = DateTime.Now, CategoryId = model.CategoryId, CountryId = model.CountryId, DescreptionAr = model.DescreptionAr, DescreptionEn = model.DescreptionEn };

            _repository.Insert(product);

            return product;
        }

        public void InsertProductMeasurment(ProductSpecificationDto model)
        {
            var productMeasurment = new ProductSpecification { CreatedAt = DateTime.Now, MeasurmentId = model.MeasurmentId, ProductId = model.ProductId, Price = model.Price };

            context.ProductSpecifications.Add(productMeasurment);
            context.SaveChanges();

        }

        public void InsertProductPicture(ProductPictureDto model)
        {
            var productPicture = new ProductPicture { CreatedAt = DateTime.Now, Image = model.Image, ProductId = model.ProductId };

            context.ProductPictures.Add(productPicture);

            context.SaveChanges();
        }

        public void Update(Product model)
        {
            _repository.Update(model);
        }
    }
}
