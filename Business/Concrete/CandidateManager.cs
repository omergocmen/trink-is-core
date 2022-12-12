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
    public class CandidateManager : ICandidateService
    {
        ICandidateDal candidateDal;
        public CandidateManager(ICandidateDal candidateDal)
        {
            this.candidateDal = candidateDal;
        }

        public IDataResult<List<Candidate>> GetAll()
        {
            return new SuccessDataResult<List<Candidate>>(candidateDal.GetAll(),Messages.CandidatesListed);
        }

        public IDataResult<Candidate> GetById(int candidateId)
        {
            return new SuccessDataResult<Candidate>(candidateDal.Get(p => p.CandidateId == candidateId), Messages.CandidateFound);
        }
    }
}
