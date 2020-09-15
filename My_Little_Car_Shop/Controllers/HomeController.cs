/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.AspNetCore.Mvc;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.ViewModels;

namespace My_Little_Car_Shop.Controllers
{
    public class HomeController:Controller
    {
        private IAllCars _carRep;
        public HomeController(IAllCars allCars)
        {
            _carRep = allCars;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = _carRep.GetFavCars
            };

            return View(homeCars);
        }
    }
}
