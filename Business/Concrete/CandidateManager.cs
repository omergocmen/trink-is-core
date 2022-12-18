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

        public IResult Add(Candidate candidate)
        {
            candidateDal.Add(candidate);
            return new SuccessResult(Messages.CandidateAdded);
        }

        public IResult Delete(Candidate candidate)
        {
            candidateDal.Delete(candidate);
            return new SuccessResult(Messages.CandidateDeleted);
        }

        public IDataResult<List<Candidate>> GetAll()
        {
            return new SuccessDataResult<List<Candidate>>(candidateDal.GetAll(),Messages.CandidatesListed);
        }

        public IDataResult<Candidate> GetById(int candidateId)
        {
            return new SuccessDataResult<Candidate>(candidateDal.Get(p => p.UserId == candidateId), Messages.CandidateFound);
        }
        public IDataResult<Candidate> GetByEmail(string email)
        {
            return new SuccessDataResult<Candidate>(candidateDal.Get(p => p.Email == email), Messages.CandidateFound);
        }

        public IResult Update(Candidate candidate)
        {
            candidateDal.Update(candidate);
            return new SuccessResult(Messages.CandidateUpdated);
        }
    }
}
