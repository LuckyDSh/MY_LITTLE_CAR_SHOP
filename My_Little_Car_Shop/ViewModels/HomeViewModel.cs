/*
 *  TickLuck Team
 *  All rights reserved 
 */

using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace My_Little_Car_Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
