﻿using System.IO;
using System.Text;
using SimpleMVC.Interfaces;

namespace PizzaForumApp.Views.User
{
    public class Register : IRenderable
    {
        public string Render()
        {
            var sb = new StringBuilder();
            sb.Append(File.ReadAllText("../../content/header.html"));
            sb.Append(File.ReadAllText("../../content/nav-not-logged.html"));
            sb.Append(File.ReadAllText("../../content/register.html"));
            sb.Append(File.ReadAllText("../../content/footer.html"));
            return sb.ToString();
        }
    }
}
