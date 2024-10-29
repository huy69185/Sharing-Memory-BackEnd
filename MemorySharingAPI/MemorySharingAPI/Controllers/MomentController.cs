using MemorySharingAPI.Data;
using MemorySharingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class MomentController : ControllerBase
{
    private readonly AppDbContext _context;

    public MomentController(AppDbContext context)
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
