using System.IO;
using System.Text;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Views.Categories
{
    public class Edit :IRenderable
    {
        public string Render()
        {
            var sb = new StringBuilder();
            sb.Append(File.ReadAllText("../../content/header.html"));
            sb.Append(File.ReadAllText("../../content/nav-logged.html"));
            sb.Append(File.ReadAllText("../../content/admin-category-edit.html"));
            sb.Append(File.ReadAllText("../../content/footer.html"));
            return sb.ToString();
        }
    }
}
