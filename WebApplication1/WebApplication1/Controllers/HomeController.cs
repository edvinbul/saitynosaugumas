using WebApplication1.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;
using WebApplication1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private IAllCars _carRep;

        public HomeController (IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel { 
            
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }

    
}
