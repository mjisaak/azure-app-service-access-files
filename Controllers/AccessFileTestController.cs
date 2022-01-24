using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace access_file_test.Controllers;

[ApiController]
[Route("[controller]")]
public class AccessFileTestController : ControllerBase
{
    

    public AccessFileTestController()
    {
        
    }

    [HttpGet(Name = "Get")]
    public IActionResult Get()
    {

        var content = System.IO.File.ReadAllText("test.json");

        return Ok(content);
    }
}
