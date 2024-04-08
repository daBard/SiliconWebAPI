using Microsoft.AspNetCore.Mvc;

namespace Silicon.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok();
    }
}
