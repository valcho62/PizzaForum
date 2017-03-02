

using PizzaForumApp.Data;

namespace PizzaForumApp.Services
{
    public abstract class Service
    {

        public PizzaForumContex Contex { get;  }
        protected Service()
        {
            this.Contex = Data.Data.Contex;
        }
    }
}
