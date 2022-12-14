using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICandidateService
    {
        IDataResult<Candidate> GetById(int candidateId);
        IDataResult<List<Candidate>> GetAll();
        IResult Add(Candidate candidate);
        IResult Update(Candidate candidate);
        IResult Delete(Candidate candidate);
    }
}
