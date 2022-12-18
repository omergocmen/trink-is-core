using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        IApplicationService applicationService;
        public ApplicationController(IApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = applicationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycandidateid")]
        public IActionResult GetByCandidateId(int candidateId)
        {
            var result = applicationService.GetByCandidateId(candidateId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyjobannouncementid")]
        public IActionResult GetByJobAnnouncementId(int jobAnnouncementId)
        {
            var result = applicationService.GetByJobAnnouncementId(jobAnnouncementId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Application application)
        {
            var result = applicationService.Add(application);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Application application)
        {
            var result = applicationService.Delete(application);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Application application)
        {
            var result = applicationService.Update(application);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
