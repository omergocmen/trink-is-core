using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete 
{
    public class Applications: IEntity
    {
        public int candidate_id { get; set; }
        public int job_announcement_id { get; set; }
        public string description { get; set; }
        public enum candidate_communication_info { get; set; }
    }
}


