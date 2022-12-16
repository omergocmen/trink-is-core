using Core.Entities;
using Entities.Abstract;
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
    public class Category:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }

        [JsonIgnore]
        [DataMember]
        public virtual ICollection<JobAnnouncement> ? JobAnnouncements { get; set; }
    }
}
