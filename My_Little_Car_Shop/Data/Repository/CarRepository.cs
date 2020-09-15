/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.EntityFrameworkCore;
using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace My_Little_Car_Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDB)
        {
            this.appDBContent = appDB;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDBContent.Car.
            Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjCar(int carId) =>
            appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
