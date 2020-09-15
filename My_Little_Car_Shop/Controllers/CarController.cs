/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.AspNetCore.Mvc;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using My_Little_Car_Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Little_Car_Shop.Controllers
{
    public class CarController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }

        [Route("Cars/List")] [Route ("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            //var cars = _allCars.Cars;
            //CarListViewModel obj = new CarListViewModel();
            //obj.AllCars = _allCars.Cars;
            //obj.currCategory = "Automobiles";

            //ViewBag.title = "Cars List Shop";

            string _category = category;
            IEnumerable<Car> cars = null; // bad practice
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(c => c.id);
            }
            else
            { // change fuel classic and electro if needed
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electro")).OrderBy(i => i.id);
                    currCategory = "Electro Cars";
                }
                else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("classic")).OrderBy(i => i.id);
                    currCategory = "Classic Cars";
                }
            }

            var carObj = new CarListViewModel
            {
                AllCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title("Automobile page");

            return View(carObj);
        }


    }
}
