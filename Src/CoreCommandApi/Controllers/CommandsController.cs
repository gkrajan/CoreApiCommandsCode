
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace CoreCommandApi.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class CommandsController : ControllerBase
{

[HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
    return new string[]{"this","is","hard","coded"};
}


}
}   