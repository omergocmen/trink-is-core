using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobAnnouncementManager : IJobAnnouncementService
    {
        IJobAnnouncementDal jobAnnouncementDal;
        public JobAnnouncementManager(IJobAnnouncementDal jobAnnouncementDal)
        {
            this.jobAnnouncementDal = jobAnnouncementDal;
        }

        public IDataResult<List<JobAnnouncement>> GetAll()
        {
            return new SuccessDataResult<List<JobAnnouncement>>(jobAnnouncementDal.GetAll(), Messages.JobAnnouncementsListed);
        }

        public IDataResult<JobAnnouncement> GetById(int jobannouncementId)
        {
            return new SuccessDataResult<JobAnnouncement>(jobAnnouncementDal.Get(p => p.JobAnnouncementId == jobannouncementId), Messages.JobAnnouncementsFound);
        }
    }
}
