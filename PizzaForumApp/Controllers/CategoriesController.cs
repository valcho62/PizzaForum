using System.Linq;
using System.Runtime.Remoting.Contexts;
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
   public class CategoriesController :Controller
    {
        public SignInManager manager;
        
        public CategoriesController()
        {

            this.manager = new SignInManager();
        }
        [HttpGet]
        public IActionResult All()
       {
           return View();
       }
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(AddNewCategoryBindingModel model,HttpResponse response,HttpSession session)
        {
            if (Data.Data.Contex.Sessions.First(x => x.SessionId == session.Id).User.IsAdmin)
            {
                var service = new CategoryService();
                service.AddNewCategory(model);
            }
            Redirect(response,"/home/indexlogged");
            return null;
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
