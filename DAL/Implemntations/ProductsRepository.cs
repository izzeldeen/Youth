﻿using Context;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
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


        public IEnumerable<Product> GetProductByContry(int CountryId , int CategoryId)
        {
            if(CategoryId == 0)
            {
                return context.Products.Where(x => x.CountryId == CountryId).ToList();
            }

            return context.Products.Where(x => x.CountryId == CountryId && x.CategoryId == CategoryId);
        }

        public ProductPicture GetProductPictuerById(int ProductId)
        {
            return context.ProductPictures.FirstOrDefault(x => x.ProductId == ProductId);
        }

        public ProductSpecification GetProductSpecification(int ProductId)
        {
            return context.ProductSpecifications.Include(x=> x.Product).FirstOrDefault(x => x.ProductId == ProductId);
        }

        public List<Product> GetProductByIDS(List<int> IDs)
        {
             return IDs.Select(id => context.Products.Find(id)).OrderBy(x=>x.Id).ToList();
        }

        
    }
}
