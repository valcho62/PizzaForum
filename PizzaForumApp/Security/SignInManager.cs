using System.Linq;
using System.Runtime.Remoting.Contexts;
using PizzaForumApp.Data;
using SimpleHttpServer.Models;
using SimpleHttpServer.Utilities;

namespace PizzaForumApp.Security
{
    public class SignInManager
    {
       

        public bool IsAuthenticated(HttpSession session)
        {
            return Data.Data.Contex.Sessions.Any(x => x.IsActive && x.SessionId == session.Id);
        }

        public void Logout(HttpResponse response, string sessionId)
        {
            var currentSession = Data.Data.Contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);
            currentSession.IsActive = false;
           Data.Data.Contex.SaveChanges();

            var session = SessionCreator.Create();
            var sessionCookie = new Cookie("sessionId", session.Id + "; HttpOnly; path=/");
            response.Header.AddCookie(sessionCookie);
        }
    }
}
