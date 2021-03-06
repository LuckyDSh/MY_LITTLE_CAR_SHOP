﻿/*
 *  TickLuck Team
 *  All rights reserved 
 */

using System.Collections.Generic;

namespace My_Little_Car_Shop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }

        public List<Car> Cars { get; set; }
    }
}
