using PizzaForum.Models;
using PizzaForumApp.Models;

namespace PizzaForumApp.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PizzaForumContex : DbContext
    {
     
        public PizzaForumContex()
            : base("name=PizzaForumContex")
        {
        }

         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<Topic> Topics { get; set; }
         public virtual DbSet<Reply> Replies { get; set; }
         public virtual DbSet<Session> Sessions { get; set; }
    }

    
}