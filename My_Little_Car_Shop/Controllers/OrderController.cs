/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.AspNetCore.Mvc;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;

namespace My_Little_Car_Shop.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders,ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout(Order order) 
        {
            shopCart.listShopItems = shopCart.GetShopCartItems();
            if (shopCart.listShopItems.Count == 0)
                ModelState.AddModelError("", "You should have some orders");
            if (ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order is successfuly completed";
            return View();
        }

    }
}
