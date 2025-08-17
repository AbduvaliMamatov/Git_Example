using Microsoft.AspNetCore.Mvc;

namespace Git_Example.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GitsControllers : ControllerBase
{
    [HttpGet]
    public Task<IActionResult> GetGitAsync()
        => Task.FromResult<IActionResult>(Ok());

    [HttpGet("test")]
    public Task<IActionResult> GetTestAsync()
        => Task.FromResult<IActionResult>(Ok());
}