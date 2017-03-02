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
            var user = Data.Data.Contex.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user != null)
            {
                var sessio = new Session();
                sessio.SessionId = session.Id;
                sessio.IsActive = true;
                sessio.User = user;

                Data.Data.Contex.Sessions.Add(sessio);
                Data.Data.Contex.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
