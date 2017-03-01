using System.Linq;
using PizzaForum.Models;
using PizzaForumApp.BindingModels;
using SimpleHttpServer.Models;

namespace PizzaForumApp.Services
{
    public class LoginService : Service
    {
        public LoginService():base(){}

        public bool LoginUser(LoginBindingModel model, HttpSession session)
        {
            var user = contex.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user != null)
            {
                var sessio = new Session();
                sessio.SessionId = session.Id;
                sessio.IsActive = true;
                sessio.User = user;

                contex.Sessions.Add(sessio);
                contex.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
