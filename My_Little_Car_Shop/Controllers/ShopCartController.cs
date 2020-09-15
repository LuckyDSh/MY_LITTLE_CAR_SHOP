/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.AspNetCore.Mvc;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using My_Little_Car_Shop.ViewModels;
using System.Linq;

namespace My_Little_Car_Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars allCars, ShopCart shopCart)
        {
            _carRep = allCars;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopCartItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
        
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(c => c.id == id);

            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
