using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Little_Car_Shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public uint price { get; set; }
        public string ShopCartId { get; set; }
    }
}
