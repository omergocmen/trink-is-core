﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfJobAnnouncementDal : EfEntityRepositoryBase<JobAnnouncement, ApplicationContext>, IJobAnnouncementDal
    {
        public List<JobAnnouncementDetailDto> GetAllJobAnnouncementDetail()
        {

                using (var context = new ApplicationContext())
                {
                    var result = from ja in context.JobAnnouncements
                                 join c in context.Categories
                                    on ja.CategoryId equals c.CategoryId
                                 join emp in context.Users
                                    on ja.EmployerId equals emp.UserId
                                 select new JobAnnouncementDetailDto { 
                                     CategoryId=c.CategoryId,
                                     CompanyName = ja.Employer.CompanyName,
                                     CategoryName = c.CategoryName,
                                     JobAnnouncementId=ja.JobAnnouncementId,
                                     EmployerId=emp.UserId,
                                     EmployerName=emp.FirstName+" "+emp.LastName,
                                     Address=ja.Address,
                                     Description=ja.Description,
                                     Experience=ja.Experience,
                                     Salary = ja.Salary,
                                     CreatedAt=ja.CreatedAt
                                 };
                    return result.OrderByDescending(p => p.CreatedAt).ToList();
                }
                throw new NotImplementedException();
        }

        public List<JobAnnouncementDetailDto> GetAllJobAnnouncementDetailByEmployerId(int employerId)
        {

            using (var context = new ApplicationContext())
            {
                var result = from ja in context.JobAnnouncements
                             join c in context.Categories
                                on ja.CategoryId equals c.CategoryId
                             join emp in context.Users
                                on ja.EmployerId equals emp.UserId
                             select new JobAnnouncementDetailDto
                             {
                                 CategoryId = c.CategoryId,
                                 CompanyName = ja.Employer.CompanyName,
                                 CategoryName = c.CategoryName,
                                 JobAnnouncementId = ja.JobAnnouncementId,
                                 EmployerId = emp.UserId,
                                 EmployerName = emp.FirstName + " " + emp.LastName,
                                 Address = ja.Address,
                                 Description = ja.Description,
                                 Experience = ja.Experience,
                                 Salary = ja.Salary,
                                 CreatedAt = ja.CreatedAt
                             };
                return result.Where(p=>p.EmployerId == employerId).OrderByDescending(p => p.CreatedAt).ToList();
            }
            throw new NotImplementedException();
        }
        public List<JobAnnouncementApplicationDetailDto> GetAllJobAnnouncementDetailByCandidateId(int candidateId)
        {

            using (var context = new ApplicationContext())
            {
                var result = from ja in context.JobAnnouncements
                             join c in context.Categories
                                on ja.CategoryId equals c.CategoryId
                             join emp in context.Users
                                on ja.EmployerId equals emp.UserId
                             join app in context.Applications
                                on ja.JobAnnouncementId equals app.JobAnnouncementId
                             select new JobAnnouncementApplicationDetailDto
                             {
                                 CategoryId = c.CategoryId,
                                 CompanyName = ja.Employer.CompanyName,
                                 CategoryName = c.CategoryName,
                                 JobAnnouncementId = ja.JobAnnouncementId,
                                 EmployerId = emp.UserId,
                                 EmployerName = emp.FirstName + " " + emp.LastName,
                                 Address = ja.Address,
                                 Description = ja.Description,
                                 Experience = ja.Experience,
                                 Salary = ja.Salary,
                                 CreatedAt = ja.CreatedAt,
                                 ApplicationId = app.ApplicationId,
                                 CandidateId = app.CandidateId,
                                 CandidateFirstName = app.Candidate.FirstName,
                                 CandidateLastName = app.Candidate.LastName
                             };
                return result.Where(p => p.CandidateId == candidateId).OrderByDescending(p=>p.CreatedAt).ToList();
            }
            throw new NotImplementedException();
        }


        public JobAnnouncementDetailDto GetAllJobAnnouncementDetailById(int jobAnnouncementId)
        {

            using (var context = new ApplicationContext())
            {
                var result = from ja in context.JobAnnouncements
                             join c in context.Categories
                                on ja.CategoryId equals c.CategoryId
                             join emp in context.Users
                                on ja.EmployerId equals emp.UserId
                             select new JobAnnouncementDetailDto
                             {
                                 CategoryId = c.CategoryId,
                                 CompanyName=ja.Employer.CompanyName,
                                 CategoryName = c.CategoryName,
                                 JobAnnouncementId = ja.JobAnnouncementId,
                                 EmployerId = emp.UserId,
                                 EmployerName = emp.FirstName + " " + emp.LastName,
                                 Address = ja.Address,
                                 Description = ja.Description,
                                 Experience = ja.Experience,
                                 Salary = ja.Salary,
                                 CreatedAt = ja.CreatedAt
                             };
                return result.SingleOrDefault(p => p.JobAnnouncementId == jobAnnouncementId);
            }
            throw new NotImplementedException();
        }
    }
}
