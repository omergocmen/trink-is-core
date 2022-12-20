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
    public class EmployerManager : IEmployerService
    {
        IEmployerDal employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            this.employerDal = employerDal;
        }

        public IResult Add(Employer employer)
        {
            employerDal.Add(employer);
            return new SuccessResult(Messages.EmployerAdded);
        }

        public IResult Delete(Employer employer)
        {
            employerDal.Delete(employer);
            return new SuccessResult(Messages.EmployerDeleted);
        }

        public IDataResult<List<Employer>> GetAll()
        {
            return new SuccessDataResult<List<Employer>>(employerDal.GetAll(), Messages.EmployersListed);
        }

        public IResult Update(Employer employer)
        {
            employerDal.Update(employer);
            return new SuccessResult(Messages.EmployerUpdated);
        }
        public IDataResult<Employer> GetByEmail(string email)
        {
            return new SuccessDataResult<Employer>(employerDal.Get(p => p.Email == email), Messages.EmployerFound);
        }

        public IDataResult<Employer> GeByCompanyName(string companyName)
        {
            return new SuccessDataResult<Employer>(employerDal.Get(p=>p.CompanyName==companyName),Messages.EmployerFound);
        }

        public IDataResult<Employer> GetById(int employerId)
        {
            return new SuccessDataResult<Employer>(employerDal.Get(p => p.UserId == employerId), Messages.EmployerFound);
        }
    }
}
