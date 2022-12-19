using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ApplicationDetailDto:IDto
    {
        public int ApplicationId { get; set; }
        public string ApplicationDescription { get; set; }  
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateEmail { get; set; }
        public int CandidateId { get; set; }
        public int JobAnnouncementId { get; set; }

    }
}
