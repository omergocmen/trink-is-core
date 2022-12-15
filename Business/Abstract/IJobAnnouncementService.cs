﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobAnnouncementService
    {
        IDataResult<JobAnnouncement> GetById(int jobannouncementId);
        IDataResult<List<JobAnnouncement>> GetAll();
        IResult Add(JobAnnouncement jobAnnouncement);
        IResult Update(JobAnnouncement jobAnnouncement);
        IResult Delete(JobAnnouncement jobAnnouncement);
    }
}