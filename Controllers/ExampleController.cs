using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace swashbuckle_generic_action_missing.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly ILogger<ExampleController> _logger;

    public ExampleController(ILogger<ExampleController> logger)
    {
        _logger = logger;
    }

    [HttpPost("generic")]
    public IActionResult Post<T>([FromBody] T profile)
      where T : BaseProfile
    {
        _logger.LogInformation("Received profile: {profile}", profile.GetType().Name);

        return NoContent();
    }

    [HttpPut("base")]
    public IActionResult Post([FromBody] BaseProfile profile)
    {
        _logger.LogInformation("Received profile: {profile}", profile.GetType().Name);

        return NoContent();
    }
}
