using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobAnnoncementController : ControllerBase
    {
        IJobAnnouncementService jobAnnouncementService;
        public JobAnnoncementController(IJobAnnouncementService jobAnnouncementService)
        {
            this.jobAnnouncementService = jobAnnouncementService;
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

        [HttpPost("add")]
        public IActionResult Add(JobAnnouncement jobAnnouncement)
        {
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
