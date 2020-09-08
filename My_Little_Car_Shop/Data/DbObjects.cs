using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace My_Little_Car_Shop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            //content content = content.ApplicationServices.GetRequiredService<content>();

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                #region Adding Cars to content
                content.AddRange(             
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Electro Car",
                        longDesc = "The real joy of the Leaf isn’t the money, it’s the motor, and its charming grace",
                        img = "/img/Nissan-Leaf.jpg",
                        price = 55000,
                        isFavorite = true,
                        isAvailable = false,
                        Category = Categories["Electro"]
                    },
                     new Car
                     {
                         name = "Tesla Model 3",
                         shortDesc = "Electro Car",
                         longDesc = "Everything Tesla has done up to this point has been building towards the Model 3",
                         img = "/img/Tesla Model 3.jpg",
                         price = 60000,
                         isFavorite = true,
                         isAvailable = true,
                         Category = Categories["Electro"]
                     },
                      new Car
                      {
                          name = "Jaguar I-Pace",
                          shortDesc = "Electro Car",
                          longDesc = " A rapid, desirable, good-looking SUV that happens to be powered by electricity",
                          img = "/img/Jaguar I-Pace.jpg",
                          price = 55000,
                          isFavorite = false,
                          isAvailable = true,
                          Category = Categories["Electro"]
                      },
                       new Car
                       {
                           name = "Tesla Model S",
                           shortDesc = "Electro Car",
                           longDesc = "There’s no denying the Model S is a mightily impressive achievement",
                           img = "/img/Tesla Model S.jpg",
                           price = 50000,
                           isFavorite = true,
                           isAvailable = true,
                           Category = Categories["Electro"]
                       },
                     new Car
                     {
                         name = "BMW-M3",
                         shortDesc = "ICE Car",
                         longDesc = "Fast and Agressive",
                         img = "/img/BMW-M3.jpeg",
                         price = 40000,
                         isFavorite = true,
                         isAvailable = true,
                         Category = Categories["Classical"]
                     },
                      new Car
                      {
                          name = "Subaru BRZ",
                          shortDesc = "ICE Car",
                          longDesc = "Get big-time fun in a small package",
                          img = "/img/Subaru BRZ.jpeg",
                          price = 35000,
                          isFavorite = true,
                          isAvailable = true,
                          Category = Categories["Classical"]
                      },
                       new Car
                       {
                           name = "Nissan 370Z",
                           shortDesc = "ICE Car",
                           longDesc = "Smooth lines flow from front to back",
                           img = "/img/Nissan 370Z.jpg",
                           price = 45000,
                           isFavorite = true,
                           isAvailable = true,
                           Category = Categories["Classical"]
                       },
                        new Car
                        {
                            name = "Chevrolet Camaro",
                            shortDesc = "ICE Car",
                            longDesc = " Sports car that has significant available power",
                            img = "/img/Chevrolet Camaro.jpg",
                            price = 50000,
                            isFavorite = true,
                            isAvailable = true,
                            Category = Categories["Classical"]
                        },
                         new Car
                         {
                             name = "Lamborghini Aventador",
                             shortDesc = "ICE Car",
                             longDesc = " Incredible power and agressive character, this car is for real drivers",
                             img = "/img/lamborghini aventador.jpg",
                             price = 100000,
                             isFavorite = true,
                             isAvailable = true,
                             Category = Categories["Classical"]
                         });
                #endregion
                
                content.SaveChanges();
            }
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string,Category> Categories
        {
            #region GET
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category
                        {
                            categoryName = "Electro",
                            desc = "Modern Transport"
                        },
                        new Category
                        {
                            categoryName = "Classical",
                            desc = "Cars with ICE"
                        }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.categoryName, item);
                    }

                }
                    return category;
            }
            #endregion
        }
    }
}
