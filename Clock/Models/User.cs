using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clock.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public int RoleId { get; set; }
        public bool LogFlag { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }



    }
}