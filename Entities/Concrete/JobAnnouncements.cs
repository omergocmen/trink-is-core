using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class JobAnnouncements : IEntity
    {
        public int job_announcement_id { get; set; }
        public int creater_id { get; set; }
        public string description { get; set; }
        public int experience { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public DateTime createdAt { get; set; } 
        public int category_id { get; set; }
    }
}
