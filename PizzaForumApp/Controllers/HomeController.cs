using PizzaForumApp.Data;
using PizzaForumApp.Security;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Controllers
{
    public class HomeController :Controller
    {
        public SignInManager manager;
        PizzaForumContex contex = new PizzaForumContex();
        public HomeController()
        {

            this.manager = new SignInManager(contex);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
