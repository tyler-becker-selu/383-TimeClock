using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase1_Project.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }

    }
}