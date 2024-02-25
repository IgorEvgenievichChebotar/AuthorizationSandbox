using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationSandbox.Controllers;

[ApiController]
[Authorize]
public class TestController : ControllerBase
{
    [HttpGet("/")]
    public async Task<IActionResult> Root()
    {
        await Task.Yield();
        return Ok("You are authorized!");
    }
}