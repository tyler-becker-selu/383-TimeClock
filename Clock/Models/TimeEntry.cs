using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clock.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

      }
}