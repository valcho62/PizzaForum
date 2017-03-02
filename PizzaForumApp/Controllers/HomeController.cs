using PizzaForumApp.Data;
using PizzaForumApp.Security;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Controllers
{
    public class HomeController :Controller
    {
        public SignInManager manager;
        
        public HomeController()
        {

            this.manager = new SignInManager();
        }
        [HttpGet]
        public IActionResult Index(HttpSession session,HttpResponse response)
        {
            if (this.manager.IsAuthenticated(session))
            {
                Redirect(response,"/home/indexlogged");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Indexlogged()
        {
            return View();
        }
    }
}
