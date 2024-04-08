using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Silicon.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscriberController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpPost]
    public async Task<IActionResult> SubscribeAsync(string email)
    {
        if(ModelState.IsValid)
        {
            if (await _context.Subscribers.AnyAsync(x => x.Email == email))
            {
                return Conflict();
            }
            else
            {
                await _context.AddAsync(new SubscriberEntity { Email = email });
                await _context.SaveChangesAsync();
                return Ok();
            }
            
        }

        return BadRequest();        
    }

    [HttpDelete]
    public async Task<IActionResult> UnsubscribeAsync(string email)
    {
        if (ModelState.IsValid)
        {
            var subscriber = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
            if (subscriber == null)
                return NotFound();

            _context.Remove(subscriber);
            await _context.SaveChangesAsync();
            return Ok();   
        }

        return BadRequest();
    }
}
