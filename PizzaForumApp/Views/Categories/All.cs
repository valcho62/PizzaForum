using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Views.Categories
{
    public class All :IRenderable
    {
        public string Render()
        {
            var part = new StringBuilder();

            var allCategories = Data.Data.Contex.Categories.ToArray();
            foreach (var cate in allCategories)
            {
                var temp = File.ReadAllText("../../content/admin-categories.html");
                part.Append( string.Format())
            }
            var sb = new StringBuilder();
            sb.Append(File.ReadAllText("../../content/header.html"));
            sb.Append(File.ReadAllText("../../content/nav-logged.html"));
            sb.Append(File.ReadAllText("../../content/admin-categories.html"));
            sb.Append(File.ReadAllText("../../content/footer.html"));
            return sb.ToString();
        }
    }
}
