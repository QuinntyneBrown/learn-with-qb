using System.Collections.Generic;

namespace LearnWithQB.Server.Models
{
    public class Role : BaseEntity
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
