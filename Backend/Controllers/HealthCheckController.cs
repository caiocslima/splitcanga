using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public string HealthCheck ()
    {
        return $"Server Online! {DateTime.Now}";
    }
}
