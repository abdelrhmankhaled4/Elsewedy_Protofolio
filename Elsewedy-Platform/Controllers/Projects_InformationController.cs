using Elsewedy_Platform.Models.DTO;
using Elsewedy_Platform.repo_courses.projects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elsewedy_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Projects_InformationController : ControllerBase
    {
        private readonly IProject project;
        public Projects_InformationController(IProject project)
        {
            this.project = project;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = project.Get_All();
            if(list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Post(Project_Infromation_DTO_add x)
        {
            var post = project.Add_Project(x);
            return Ok(new { Bool = post});
        }
        [HttpPut]
        public IActionResult update_statue(string email,string status)
        {
            project.update_statue(email,status);
            return Ok();
        }
    }
}
