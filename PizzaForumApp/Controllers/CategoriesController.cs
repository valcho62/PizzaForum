using PizzaForumApp.Data;
using PizzaForumApp.Security;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Controllers
{
   public class CategoriesController :Controller
    {
        public SignInManager manager;
        PizzaForumContex contex = new PizzaForumContex();
        public CategoriesController()
        {

            this.manager = new SignInManager(contex);
        }
        public IActionResult All()
       {
           return View();
       }
    }
}
