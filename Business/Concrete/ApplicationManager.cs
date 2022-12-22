using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            this.applicationDal = applicationDal;
        }

        public IResult Add(Application application)
        {
            var Application = applicationDal.Get(p => p.CandidateId == application.CandidateId && p.JobAnnouncementId == application.JobAnnouncementId);
            if (Application == null)
            {
                applicationDal.Add(application);
                return new SuccessResult(Messages.ApplicationAdded);
            }
            else
            {
                throw new ApplicationException("Daha Önce Bu İlana Başvuru Yapıldı");
            }

        }

        public IResult Delete(Application catapplicationegory)
        {
            applicationDal.Delete(catapplicationegory);
            return new SuccessResult(Messages.ApplicationDeleted);
        }

        public IDataResult<List<Application>> GetAll()
        {
            return new SuccessDataResult<List<Application>>(applicationDal.GetAll(),Messages.ApplicationListed);   
        }

        public IDataResult<Application> GetById(int applicationId)
        {
            return new SuccessDataResult<Application>(applicationDal.Get(p=>p.ApplicationId==applicationId), Messages.ApplicationFound);
        }

        public IDataResult<List<Application>> GetByJobAnnouncementId(int jobAnnouncementId)
        {
            return new SuccessDataResult<List<Application>>(applicationDal.GetAll(p => p.JobAnnouncementId == jobAnnouncementId), Messages.ApplicationFound);
        }

        public IDataResult<List<Application>> GetByCandidateId(int candidateId)
        {
            return new SuccessDataResult<List<Application>>(applicationDal.GetAll(p => p.CandidateId == candidateId), Messages.ApplicationFound);
        }

        public IResult Update(Application application)
        {
            applicationDal.Update(application);
            return new SuccessResult(Messages.ApplicationUpdated);
        }

        public IDataResult<List<ApplicationDetailDto>> GetAllApplicationDetail()
        {
            return new SuccessDataResult<List<ApplicationDetailDto>>(applicationDal.GetAllApplicationDetail(), Messages.ApplicationFound);
        }

        public IDataResult<List<ApplicationDetailDto>> GetAllApplicationDetailByCandidateId(int candidateId)
        {
            return new SuccessDataResult<List<ApplicationDetailDto>>(applicationDal.GetApplicationDetailByCandidateId(candidateId), Messages.ApplicationFound);
        }

        public IDataResult<List<ApplicationDetailDto>> GetAllApplicationDetailByJobAnnouncementId(int jobAnnouncementId)
        {
            return new SuccessDataResult<List<ApplicationDetailDto>>(applicationDal.GetApplicationDetailByJobAnnouncementId(jobAnnouncementId), Messages.ApplicationFound);
        }
    }
}
