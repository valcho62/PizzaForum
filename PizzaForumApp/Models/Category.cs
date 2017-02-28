using System.Collections.Generic;

namespace PizzaForumApp.Data
{
   public class Category
    {
        public Category()
        {
            this.Topics =new HashSet<Topic>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
