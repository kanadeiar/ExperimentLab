using Microsoft.AspNetCore.Mvc;

namespace Uqs.Weather.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet(Name = "GetSample")]
    public string Get()
    {
        return "one";
    }
}