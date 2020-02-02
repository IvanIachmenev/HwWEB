using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW5.Models;
using HW5.ViewModels;

namespace HW5.Controllers
{
    public class HomeController : Controller
    {
        List<Brand> brands;
        List<Water> water;
        public HomeController()
        {
            Brand Slavda = new Brand { Id = 1, Name = "Slavda", Country = "Russia", CreationDate = DateTime.Now };
            Brand Swallow = new Brand { Id = 2, Name = "Swallow", Country = "Russia", CreationDate = DateTime.Now };
            Brand Monastry = new Brand { Id = 3, Name = "Monastry", Country = "Russia", CreationDate = DateTime.Now };
            brands = new List<Brand> { Slavda, Swallow, Monastry };

            water = new List<Water>
            {
                new Water
                {
                    Id = 1, Name = "Bottle 0.5L", Count = 10,
                    Price = 65, Brand = Swallow, Volume = 0.5,
                    CreationDate = DateTime.Now
                },
                new Water
                {
                    Id = 2, Name = "Bottle 1L", Count = 20,
                    Price = 75, Brand = Monastry, Volume = 1,
                    CreationDate = DateTime.Now
                },
                new Water
                {
                    Id = 3, Name = "Bottle 19L", Count = 5,
                    Price = 110, Brand = Slavda, Volume = 19,
                    CreationDate = DateTime.Now
                }
            };
        }

        public IActionResult Index(int? brandId)
        {
            // формируем список компаний для передачи в представление
            List<BrandModel> brandModels = brands.Select(c => new BrandModel { Id = c.Id, Name = c.Name }).ToList();
            // добавляем на первое место
            brandModels.Insert(0, new BrandModel { Id = 0, Name = "ALL" });

            IndexViewModel ivm = new IndexViewModel { Brands = brandModels, Waters = water };

            // если передан id компании, фильтруем список
            if(brandId != null && brandId > 0)
            {
                ivm.Waters = water.Where(p => p.Brand.Id == brandId);
            }
            return View(ivm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
