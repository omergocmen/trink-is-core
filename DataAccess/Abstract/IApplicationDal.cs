using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IApplicationDal: IEntityRepository<Application>
    {
        public List<ApplicationDetailDto> GetAllApplicationDetail();
        public List<ApplicationDetailDto> GetApplicationDetailByCandidateId(int candidateId);
        public List<ApplicationDetailDto> GetApplicationDetailByJobAnnouncementId(int candidateId);

    }
}
