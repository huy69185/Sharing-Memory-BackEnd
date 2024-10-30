using MemorySharingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class MomentController : ControllerBase
{
    private readonly MemorySharingPlatformContext _context;

    public MomentController(MemorySharingPlatformContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Moment>>> GetPublicMoments()
    {
        return await _context.Moments
            .Where(m => m.IsPublic == true)
            .OrderByDescending(m => m.CreatedAt)
            .ToListAsync();
    }
}
