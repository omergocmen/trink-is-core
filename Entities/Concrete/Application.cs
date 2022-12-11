using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete 
{
    public class Application: IEntity
    {
        public int candidateId { get; set; }
        public int jobAnnouncementId { get; set; }
        public string description { get; set; }
        public enum candidateCommunicationInfo { get; set; }
    }
}


