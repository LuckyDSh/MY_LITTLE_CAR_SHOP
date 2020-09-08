using My_Little_Car_Shop.Data.Interfaces;
using My_Little_Car_Shop.Data.Models;
using System.Collections.Generic;

namespace My_Little_Car_Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDB)
        {
            this.appDBContent = appDB;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
