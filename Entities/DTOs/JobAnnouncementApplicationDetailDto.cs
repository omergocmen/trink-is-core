using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class JobAnnouncementApplicationDetailDto:IDto
    {
        public int JobAnnouncementId { get; set; }
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public string CompanyName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int CandidateId { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public int ApplicationId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
