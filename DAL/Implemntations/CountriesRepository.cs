using Context;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Implemntations
{
    public class CountriesRepository : ICountriesRepository
    {
        protected static readonly DataContext context = new DataContext();

        protected static IRepository<Country> _repository;

        public CountriesRepository(IRepository<Country> repository)
        {
            _repository = repository;
        }

        public Country Insert(CountryDto model)
        {
            var country = new Country { NameAr = model.NameAr, NameEn = model.NameEn, CreatedAt = DateTime.Now };

            _repository.Insert(country);

            return country;
        }

        public IEnumerable<Country> GetCountries()
        {
            return _repository.GetAll();
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public Country GetCountryById(int Id)
        {
            return _repository.GetById(Id);
        }

        public void Update(Country model)
        {
            _repository.Update(model);
        }
    }
}
