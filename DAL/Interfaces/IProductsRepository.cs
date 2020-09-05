using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Measurment> GetMeasurments();
        Product Insert(ProductDto model);
        void InsertProductPicture(ProductPictureDto model);
        void InsertProductMeasurment(ProductSpecificationDto model);
        void Delete(int Id);
        void Update(Product model);
        Product GetProductById(int Id);
    }
}
