using System.IO;
using System.Text;
using PizzaForumApp.BindingModels;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace PizzaForumApp.Views.User
{
    public class Login :IRenderable
    {
        public string Render()
        {
           
            var sb = new StringBuilder();
            sb.Append(File.ReadAllText("../../content/header.html"));
            sb.Append(File.ReadAllText("../../content/nav-not-logged.html"));
            sb.Append(File.ReadAllText("../../content/login.html"));
            sb.Append(File.ReadAllText("../../content/footer.html"));
            return sb.ToString();
        }

        
    }
}
