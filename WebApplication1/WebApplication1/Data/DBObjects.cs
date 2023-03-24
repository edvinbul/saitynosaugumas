using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {

                        name = "Tesla",
                        shortDesc = "2021|New car",
                        longdesc = "Tesla Electric Economic Family Car",
                        img = "/img/Tesla.jpeg",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electro Cars"]
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
                        Category = Categories["Classic Cars"]
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
                        Category = Categories["Classic Cars"]
                    }

                    );
            }
            content.SaveChanges();

        }
            private static Dictionary<string, Category> category;
            public static Dictionary<string, Category> Categories
            {
            get
               {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Electro Cars", desc = "Cars type"},
                        new Category { categoryName = "Classic Cars", desc = "Cars type with internal combustion vehicles"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
               }

            }
        
    }
}
