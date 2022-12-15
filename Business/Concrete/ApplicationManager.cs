using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
            applicationDal.Add(application);
            return new SuccessResult(Messages.ApplicationAdded);
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

        public IResult Update(Application application)
        {
            applicationDal.Update(application);
            return new SuccessResult(Messages.ApplicationUpdated);
        }
    }
}
