using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Silicon.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var courses = await _context.Courses.ToListAsync();
        return Ok(courses);
    }
}
