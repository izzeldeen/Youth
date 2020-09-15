using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //Add By izz
        IEnumerable<Product> GetProductByContry(int CountryId , int CategoryId);
        public ProductPicture GetProductPictuerById(int ProductId);
        public ProductSpecification GetProductSpecification(int ProductId);
        public List<Product> GetProductByIDS(List<int> IDs);
        Task<List<Product>> GetFeaturedProducts();
        public List<ProductPicture> GetProductPictuerIsNotMain(int ProductId);


    }
}
