using Core.Entities;
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
    public class JobAnnouncement : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobAnnouncementId { get; set; }
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        [JsonIgnore]
        public virtual Employer Employer { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [DataMember]
        [JsonIgnore]
        public virtual Category Category { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        
        [JsonIgnore]
        [DataMember]
        public virtual ICollection<Application> Applications { get; set; }
    }
}
