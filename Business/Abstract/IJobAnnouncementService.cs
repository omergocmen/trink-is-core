using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobAnnouncementService
    {
        IDataResult<JobAnnouncement> GetById(int jobannouncementId);
        IDataResult<List<JobAnnouncement>> GetAll();
        IDataResult<List<JobAnnouncement>> GetByCategoryId(int categoryId);
        IDataResult<List<JobAnnouncement>> GetByEmployerId(int employerId);
        IDataResult<List<JobAnnouncement>> GetByExperience();
        IDataResult<List<JobAnnouncement>> GetByAddress();
        IDataResult<List<JobAnnouncementDetailDto>> GetAllJobAnnouncementDetail();
        IDataResult<List<JobAnnouncementDetailDto>> GetAllJobAnnouncementDetailByEmployerId(int employerId);
        IDataResult<JobAnnouncementDetailDto> GetAllJobAnnouncementDetailById(int jobAnnouncementId);

        IResult Add(JobAnnouncement jobAnnouncement);
        IResult Update(JobAnnouncement jobAnnouncement);
        IResult Delete(JobAnnouncement jobAnnouncement);
    }
}
