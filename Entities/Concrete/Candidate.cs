﻿using Core.Entities;
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

    [Table("Candidates")]
    public class Candidate : User
    {
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string? PhoneNumber { get; set; }

        [JsonIgnore]
        [DataMember]
        public virtual ICollection<Application> ? Applications { get; set; }
    }
}
