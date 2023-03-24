using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();


        public IEnumerable<Car> Cars { 
            get
            {
                return new List<Car> 
                {
                    new Car {

                        name = "Tesla",
                        shortDesc = "2021|New car",
                        longdesc = "Tesla Electric Economic Family Car",
                        img = "/img/Tesla.jpeg",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Alfa Romeo Giulia",
                        shortDesc = "2022|New Car",
                        longdesc = "Alfa Romeo Sport Car Giulia with 400AG",
                        img = "/img/Guilia.png",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        name = "BMW 5 Series",
                        shortDesc = "2022|New Car",
                        longdesc = "BMW 5 Series Sedan Comfort Car with 300AG",
                        img = "/img/5.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }

                };
            }
        
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
