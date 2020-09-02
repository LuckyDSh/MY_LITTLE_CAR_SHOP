using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;

namespace My_Little_Car_Shop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
