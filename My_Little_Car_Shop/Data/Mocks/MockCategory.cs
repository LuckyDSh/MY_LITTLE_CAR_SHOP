/*
 *  TickLuck Team
 *  All rights reserved 
 */

using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;

namespace My_Little_Car_Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                     new Category{ categoryName = "Electro Cars", desc="Tesla Car" },
                     new Category{ categoryName = "ICE Cars", desc="General Motors Car" }
                };
            }
        }
    }
}
