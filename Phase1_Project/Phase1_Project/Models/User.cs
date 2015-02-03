using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase1_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Role Role { get; set; }
    }
}