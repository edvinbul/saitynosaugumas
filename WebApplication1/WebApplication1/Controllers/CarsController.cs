using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            } else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electro Cars")).OrderBy(i => i.id);
                    currCategory = "Electro Cars";
                } else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                        {
                            cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Classic Cars")).OrderBy(i => i.id);
                    currCategory = "Classic Cars";
                }
                {

                }
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory

            };

            ViewBag.Title = "Page with cars";
            /*CarsListViewModel obj =  new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Cars";*/
            
            return View(carObj);
        }

    }
}
