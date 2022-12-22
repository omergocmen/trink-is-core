using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IJobAnnouncementDal : IEntityRepository<JobAnnouncement>
    {
        public List<JobAnnouncementDetailDto> GetAllJobAnnouncementDetail();
        public List<JobAnnouncementDetailDto> GetAllJobAnnouncementDetailByEmployerId(int employerId);
        public List<JobAnnouncementApplicationDetailDto> GetAllJobAnnouncementDetailByCandidateId(int candidateId);
        public JobAnnouncementDetailDto GetAllJobAnnouncementDetailById(int jobAnnouncementId);

    }
}
