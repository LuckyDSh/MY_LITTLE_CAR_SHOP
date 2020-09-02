using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;

namespace My_Little_Car_Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
