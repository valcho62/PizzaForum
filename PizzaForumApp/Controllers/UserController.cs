using PizzaForumApp.BindingModels;
using PizzaForumApp.Data;
using PizzaForumApp.Security;
using PizzaForumApp.Services;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Controllers
{
    public class UserController:Controller
    {
        public SignInManager manager;
        PizzaForumContex contex = new PizzaForumContex();
        public UserController()
        {

            this.manager = new SignInManager(contex);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Register(AddUserBindingModel model,HttpResponse response)
        {
            var service = new AddUserService();
            if (service.ValidateUser(model))
            {
                service.AddUser(model);
                Redirect(response,"/home/index");
                return null;
            }
            return this.View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Login(LoginBindingModel model, HttpResponse response,HttpSession session)
        {
            var service = new LoginService();
            if (service.LoginUser(model,session))
            {
                Redirect(response,"");
            }
            return this.View();
        }
        [HttpGet]
        public IActionResult Logout(HttpResponse response,HttpSession session)
        {
            manager.Logout(response,session.Id);
            Redirect(response,"/home/index");
            return null;
        }
    }
}
