using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using PizzaForumApp.Models;

namespace PizzaForumApp.Data
{
    public class Topic
    {
        public Topic()
        {
            this.Replies =new HashSet<Reply>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual User Author { get; set; }
        public string Content { get; set; }
        public DateTime? PublishDate { get; set; }
        public ICollection<Reply> Replies { get; set; }
    }
}
