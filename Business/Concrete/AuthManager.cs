using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{   //Bu Servis Register olma ya da Login olma durumlarını kontrol ediyor
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ICandidateService _candidateService;
        private IEmployerService _employerService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, ICandidateService candidateService, IEmployerService employerService)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _candidateService = candidateService;
            _employerService = employerService;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<Candidate> LoginCandidate(CandidateLoginDto candidateLoginDto)
        {
            Candidate candidate = _candidateService.GetByEmail(candidateLoginDto.Email).Data;
            if (candidate.Password == candidateLoginDto.Password)
            {
                return new SuccessDataResult<Candidate>(candidate, Messages.AccessTokenCreated);
            }
            throw new Exception("Giriş Başarısız");
        }

        public IDataResult<Employer> LoginEmployer(EmployerLoginDto employerLoginDto)
        {
            Employer employer = _employerService.GetByEmail(employerLoginDto.Email).Data;
            if (employer.Password == employerLoginDto.Password)
            {
                return new SuccessDataResult<Employer>(employer, Messages.AccessTokenCreated);
            }
            throw new Exception("Giriş Başarısız");
        }


        public IDataResult<Employer> RegisterEmployer(EmployerRegisterDto employerRegisterDto)
        {
            throw new NotImplementedException();
        }
        public IDataResult<Candidate> RegisterCandidate(CandidateRegisterDto candidateRegisterDto)
        {
            throw new NotImplementedException();
        }

    }
}
