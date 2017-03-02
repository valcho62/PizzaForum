using System.Linq;
using System.Text.RegularExpressions;
using PizzaForumApp.BindingModels;
using PizzaForumApp.Data;

namespace PizzaForumApp.Services
{
    public class AddUserService :Service
    {
        public AddUserService():base(){}

        public bool ValidateUser(AddUserBindingModel model)
        {
            var regUsername = Regex.Match(model.Username, "[a-z0-9]*");
            var regPassword = Regex.Match(model.Password, "[0-9]*");
            if (Data.Data.Contex.Users.Any(x => x.Username == model.Username || x.Email == model.Email))
            {
                return false;
            }
            if (model.Username.Length < 3 || !regUsername.Success)
            {
                return false;
            }
            if (model.Password.Length !=4 || ! regPassword.Success)
            {
                return false;
            }
            if (!model.Password.Equals(model.PasswordCheck))
            {
                return false;
            }

            return true;
        }

        public void AddUser(AddUserBindingModel model)
        {
            var user = new User();
            user.Username = model.Username;
            user.Email = model.Email;
            user.Password = model.Password;
            if (Data.Data.Contex.Users.Count() == 0)
            {
                user.IsAdmin = true;
            }
            else
            {
                user.IsAdmin = false;
            }
            Data.Data.Contex.Users.Add(user);
            Data.Data.Contex.SaveChanges();
        }
    }
}
