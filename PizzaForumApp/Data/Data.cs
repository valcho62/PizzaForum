namespace PizzaForumApp.Data
{
    public class Data
    {
        private static PizzaForumContex contex;

        public static PizzaForumContex Contex
        {
            get { return contex ?? (contex = new PizzaForumContex()); }
        }
    }
}
