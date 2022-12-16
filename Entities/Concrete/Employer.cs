using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Entities.Concrete
{

    [Table("Employers")]
    public class Employer : User
    {
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string? PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? WebAddress { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? CompanyName { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        [DataMember]
        public virtual ICollection<JobAnnouncement> JobAnnouncements { get; set; }
    }
}
