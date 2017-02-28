using System.ComponentModel.DataAnnotations;
using PizzaForumApp.Data;


namespace PizzaForum.Models
{
    public class Session
    {
        [Key]
        public string SessionId { get; set; }
        public bool IsActive { get; set; }
        public virtual User User { get; set; }
        public override string ToString()
        {
            return $"{this.SessionId}\t{this.User.Id}";
        }
    }
}