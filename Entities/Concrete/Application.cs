﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete 
{
    public class Application: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; } 

        public int CandidateId { get; set; }
        [ForeignKey("CandidateId")]
        public virtual Candidate Candidate { get; set; }


        public int JobAnnouncementId { get; set; }
        [ForeignKey("JobAnnouncementId")]

        public virtual JobAnnouncement JobAnnouncement { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? Description { get; set; }
        public CommunicationInfo CandidateCommunicationInfo { get; set; }
    }

    public enum CommunicationInfo
    {
        PhoneNumber=1,
        Email=2
    }
}




/*
Sınıf içindeki özellikler örneğin id int gibi 
bunlar PascalCase olmalıdır yani Id, CustomerId, CategoryId

Method isimleri PascalCase olmalıdır örneğin; GetById()
Method içindeki değişkenler camelCase olmalıdır örneğin; GetById(int id,string customerName)

 */


