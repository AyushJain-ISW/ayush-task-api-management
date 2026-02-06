using Microsoft.AspNetCore.Mvc;

namespace TaskManagementApi.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    /// <summary>
    /// Health check endpoint
    /// </summary>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { status = "Healthy", timestamp = DateTime.UtcNow });
    }
}
