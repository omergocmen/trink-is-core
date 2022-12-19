using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfApplicationDal : EfEntityRepositoryBase<Application, ApplicationContext>, IApplicationDal
    {
        public List<ApplicationDetailDto> GetAllApplicationDetail()
        {
            using (var context = new ApplicationContext())
            {
                var result = from a in context.Applications
                             join c in context.Users
                                on a.CandidateId equals c.UserId
                             join ja in context.JobAnnouncements
                                on a.JobAnnouncementId equals ja.JobAnnouncementId
                             select new ApplicationDetailDto
                             {
                                  CandidateId = c.UserId,
                                  CandidateFirstName = c.FirstName,
                                  CandidateEmail = c.Email,
                                  CandidateLastName = c.LastName,
                                  ApplicationDescription = a.Description,
                                  ApplicationId = a.ApplicationId,
                                  JobAnnouncementId = ja.JobAnnouncementId
                                 
                             };
                return result.ToList();
            }
            throw new NotImplementedException();
        }

        public List<ApplicationDetailDto> GetApplicationDetailByCandidateId(int candidateId)
        {
            using (var context = new ApplicationContext())
            {
                var result = from a in context.Applications
                             join c in context.Users
                                on a.CandidateId equals c.UserId
                             join ja in context.JobAnnouncements
                                on a.JobAnnouncementId equals ja.JobAnnouncementId
                             select new ApplicationDetailDto
                             {
                                 CandidateId = c.UserId,
                                 CandidateFirstName = c.FirstName,
                                 CandidateEmail = c.Email,
                                 CandidateLastName = c.LastName,
                                 ApplicationDescription = a.Description,
                                 ApplicationId = a.ApplicationId,
                                 JobAnnouncementId = ja.JobAnnouncementId

                             };
                return result.Where(p=>p.CandidateId==candidateId).ToList();
            }
            throw new NotImplementedException();
        }

        public List<ApplicationDetailDto> GetApplicationDetailByJobAnnouncementId(int jobAnnouncementId)
        {
            using (var context = new ApplicationContext())
            {
                var result = from a in context.Applications
                             join c in context.Users
                                on a.CandidateId equals c.UserId
                             join ja in context.JobAnnouncements
                                on a.JobAnnouncementId equals ja.JobAnnouncementId
                             select new ApplicationDetailDto
                             {
                                 CandidateId = c.UserId,
                                 CandidateFirstName = c.FirstName,
                                 CandidateEmail = c.Email,
                                 CandidateLastName = c.LastName,
                                 ApplicationDescription = a.Description,
                                 ApplicationId = a.ApplicationId,
                                 JobAnnouncementId = ja.JobAnnouncementId

                             };
                return result.Where(p => p.JobAnnouncementId == jobAnnouncementId).ToList();
            }
            throw new NotImplementedException();
        }
    }
}
