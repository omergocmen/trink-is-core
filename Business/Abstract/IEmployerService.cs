using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        IDataResult<Employer> GetById(int employerId);
        public IDataResult<Employer> GetByEmail(string email);
        public IDataResult<Employer> GeByCompanyName(string companyName);
        IDataResult<List<Employer>> GetAll();
        IResult Add(Employer employer);
        IResult Update(Employer employer);
        IResult Delete(Employer employer);
    }
}
