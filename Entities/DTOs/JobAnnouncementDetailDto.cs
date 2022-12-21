using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class JobAnnouncementDetailDto:IDto
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
        public DateTime ? CreatedAt { get; set; }
    }
}
