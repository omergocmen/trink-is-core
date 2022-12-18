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
        [Column(TypeName = "nvarchar(100)")]
        public string? WebAddress { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? CompanyName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? TaxNumber { get; set; }


        [JsonIgnore]
        [DataMember]
        public virtual ICollection<JobAnnouncement> ? JobAnnouncements { get; set; }
    }
}
