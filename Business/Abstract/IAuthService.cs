using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Candidate> RegisterCandidate(CandidateRegisterDto candidateRegisterDto);
        IDataResult<Candidate> LoginCandidate(CandidateLoginDto candidateLoginDto);
        IDataResult<Employer> RegisterEmployer(EmployerRegisterDto employerRegisterDto);
        IDataResult<Employer> LoginEmployer(EmployerLoginDto employerLoginDto);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
