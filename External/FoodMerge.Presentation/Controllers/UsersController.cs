using Microsoft.AspNetCore.Mvc;

namespace FoodMerge.Presentation.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok("A lot of users!");
    }
}