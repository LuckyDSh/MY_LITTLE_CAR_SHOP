/*
 *  TickLuck Team
 *  All rights reserved 
 */

using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using System;

namespace My_Little_Car_Shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrderRepository(AppDBContent appDBContent,ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Orders.Add(order);

            var item = shopCart.listShopItems;
            foreach (var el in item)
            {
                var orderDetail = new OrderDetail
                {
                    carId = el.car.id,
                    orderId = order.id,
                    price = el.car.price
                };

                appDBContent.OrderDetails.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
