using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;

namespace My_Little_Car_Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car getObjCar(int carId);
    }
}
