using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ICountriesRepository
    {
        IEnumerable<Country> GetCountries();
        Country Insert(CountryDto model);
        void Delete(int Id);
        void Update(Country model);
        Country GetCountryById(int Id);
    }
}
