using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Git_Example.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GitsControllers : ControllerBase
{

    public GitsControllers()
    {

    }
    
    [HttpPost]
    public Task<IActionResult> CreateGitAsync() => Task.FromResult<IActionResult>(Ok());
    
    [HttpPut]
    public Task<IActionResult> PutGitAsync() => Task.FromResult<IActionResult>(Ok());

    [HttpGet]
    public Task<IActionResult> GetGitAsync() => Task.FromResult<IActionResult>(Ok());

    [HttpGet("test")]
    public Task<IActionResult> GetTestAsync() => Task.FromResult<IActionResult>(Ok());

}