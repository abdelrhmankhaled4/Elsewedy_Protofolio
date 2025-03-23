using Elsewedy_Platform.Models.DTO;
using Elsewedy_Platform.repo_courses.Achivment_repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elsewedy_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchivmentsController : ControllerBase
    {
        private readonly IAchivments context;
        public AchivmentsController(IAchivments context)
        {
            this.context = context;
        }
        [HttpPost("add")]
        public IActionResult add(Achivments_DTO_add x)
        {
            var xq = context.add(x); 
            if(xq)
            {
                return Ok(new {Bool = true});
            }
            return NotFound(new {Bool = false});
        }
        [HttpGet("get")]
        public IActionResult get()
        {
            return Ok(context.getall());
        }
        [HttpDelete]
        public IActionResult delete(string title)
        {
            context.delete(title);
            return Ok();
        }
    }
}
