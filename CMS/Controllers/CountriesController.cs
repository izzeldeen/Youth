using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Helpers;
using CMS.Models;
using CMS.ViewModels;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]

    public class CountriesController : Controller
    {
        private readonly ICountriesRepository _countriesRepository;
        private readonly ModelValidations _modelValidations;
        public CountriesController(ICountriesRepository countriesRepository, ModelValidations modelValidations)
        {
            _countriesRepository = countriesRepository;
            _modelValidations = modelValidations;
        }

        public IActionResult Index()
        {
            var countries = _countriesRepository.GetCountries();
            var model = new CountriesViewModel();
            var list = new List<CountryViewModel>();
            foreach(var elem in countries)
            {
                var country = new CountryViewModel { Arabic = elem.NameAr, English = elem.NameEn, CreatedAt = elem.CreatedAt, Id = elem.Id };
                list.Add(country);
            }

            model.Countries = list;
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Action(CountryModel model)
        {
            if (_modelValidations.IsObjectNull(model))
                return RedirectToAction("Add", "Countries");

            if (!_modelValidations.IsValid(model))
                return RedirectToAction("Add", "Countries");

            var dto = new CountryDto { NameAr = model.NameAr, NameEn = model.NameEn };

            var country = _countriesRepository.Insert(dto);

            return RedirectToAction("Index", "Countries");
        }

        public IActionResult Delete(int Id)
        {
            _countriesRepository.Delete(Id);
            return RedirectToAction("Index", "Countries");
        }

        public IActionResult Edit(int Id)
        {
            var country = _countriesRepository.GetCountryById(Id);
            var model = new CountryModel { NameEn = country.NameEn, NameAr = country.NameAr, Id = Id, CreatedAt = country.CreatedAt, UpdatedAt = country.UpdatedAt};
            return View(model);
        }

        public IActionResult EditAction(CountryModel model)
        {
            var country = new Country { Id = model.Id, NameAr = model.NameAr, NameEn = model.NameEn, UpdatedAt = DateTime.Now, CreatedAt = model.CreatedAt};
            _countriesRepository.Update(country);
            return RedirectToAction("Index", "Countries");
        }
    }
}