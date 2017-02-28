

using PizzaForumApp.Data;
using SimpleHttpServer;
using SimpleMVC;

namespace PizzaForumApp
{
    class StartUp
    {
        static void Main()
        {
            var contex = new PizzaForumContex();
            contex.Database.Initialize(true);

            HttpServer server = new HttpServer(80, RouteTable.Routes);
            MvcEngine.Run(server, "PizzaForumApp");
        }
    }
}
