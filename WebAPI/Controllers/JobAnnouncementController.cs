using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobAnnoncementController : ControllerBase
    {
        IJobAnnouncementService jobAnnouncementService;
        IHttpContextAccessor httpContextAccessor;
        public JobAnnoncementController(IJobAnnouncementService jobAnnouncementService, IHttpContextAccessor httpContextAccessor)
        {
            this.jobAnnouncementService = jobAnnouncementService;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = jobAnnouncementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int jobAnnouncementId)
        {
            var result = jobAnnouncementService.GetById(jobAnnouncementId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = jobAnnouncementService.GetByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyemployerid")]
        public IActionResult GetByEmployerId(int employerId)
        {
            var result = jobAnnouncementService.GetByEmployerId(employerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyexperience")]
        public IActionResult GetByExperience(int experience)
        {
            var result = jobAnnouncementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyaddress")]
        public IActionResult GetByAddress(string address)
        {
            var result = jobAnnouncementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalljobannouncementdetail")]
        public IActionResult GetAllJobAnnouncementDetail()
        {
            var result = jobAnnouncementService.GetAllJobAnnouncementDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getalljobannouncementdetailbyemployerid")]
        public IActionResult GetAllJobAnnouncementDetailByEmployerId(int employerId)
        {
            var result = jobAnnouncementService.GetAllJobAnnouncementDetailByEmployerId(employerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalljobannouncementdetailbycandidateid")]
        public IActionResult GetAllJobAnnouncementDetailByCandidateId(int candidateId)
        {
            var result = jobAnnouncementService.GetAllJobAnnouncementDetailByCandidateId(candidateId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalljobannouncementdetailbyid")]
        public IActionResult GetAllJobAnnouncementDetailById(int jobAnnouncementId)
        {
            var result = jobAnnouncementService.GetAllJobAnnouncementDetailById(jobAnnouncementId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(JobAnnouncement jobAnnouncement)
        {
            jobAnnouncement.EmployerId = Convert.ToInt32(httpContextAccessor.HttpContext
            .User?.Claims?.FirstOrDefault
            (claim => claim.Type == ClaimTypes.NameIdentifier)?.Value);
            var result = jobAnnouncementService.Add(jobAnnouncement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(JobAnnouncement jobAnnouncement)
        {
            var result = jobAnnouncementService.Delete(jobAnnouncement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(JobAnnouncement jobAnnouncement)
        {
            var result = jobAnnouncementService.Update(jobAnnouncement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
