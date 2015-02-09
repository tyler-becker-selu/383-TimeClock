using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clock.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }

       [Column(TypeName = "DateTime2")]
        public DateTime? TimeIn { get; set; }
        
        [Column(TypeName = "DateTime2")]
        public DateTime? TimeOut { get; set; }
        
        public int UserId { get; set; }
        public virtual User User { get; set; }

      }
}