using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationService
    {
        IDataResult<Application> GetById(int applicationId);
        IDataResult<List<Application>> GetAll();

        IDataResult<List<Application>> GetByCandidateId(int candidateId);
        IDataResult<List<Application>> GetByJobAnnouncementId(int jobAnnouncementId);

        IResult Add(Application application);
        IResult Update(Application application);
        IResult Delete(Application application);
    }
}
