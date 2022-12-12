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
        public IDataResult<List<Application>> GetAll()
        {
            return new SuccessDataResult<List<Application>>(applicationDal.GetAll(),Messages.ApplicationListed);   
        }

        public IDataResult<Application> GetById(int applicationId)
        {
            return new SuccessDataResult<Application>(applicationDal.Get(p=>p.ApplicationId==applicationId), Messages.ApplicationFound);
        }
    }
}
