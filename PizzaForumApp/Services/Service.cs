

using PizzaForumApp.Data;

namespace PizzaForumApp.Services
{
    public abstract class Service
    {
        public PizzaForumContex contex;

        protected Service()
        {
            this.contex = new PizzaForumContex();
        }
    }
}
