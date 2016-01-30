using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnWithQB.Server.Models
{
    public class Customer: Person
    {
        public Customer()
        {
        }

        [ForeignKey("Profile")]
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}