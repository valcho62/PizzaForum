using System.Collections.Generic;
using System.Linq;
using PizzaForumApp.BindingModels;
using PizzaForumApp.Data;

namespace PizzaForumApp.Services
{
    public class CategoryService :Service
    {
        public CategoryService() : base() { }

        public void AddNewCategory(AddNewCategoryBindingModel model)
        {
            if (!Contex.Categories.Any(x => x.Name == model.Name))
            {
                var category = new Category();
                category.Name = model.Name;
                category.Topics = new List<Topic>();
                Contex.Categories.Add(category);
                Contex.SaveChanges();
            }
        }
    }
}
