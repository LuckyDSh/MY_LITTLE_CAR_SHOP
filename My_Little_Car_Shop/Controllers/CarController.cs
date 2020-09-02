using Microsoft.AspNetCore.Mvc;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.ViewModels;

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

        public ViewResult List()
        {
            //var cars = _allCars.Cars;
            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Automobiles";

            ViewBag.title = "Cars List Shop";
            return View(obj);
        }
    }
}
