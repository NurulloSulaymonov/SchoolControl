using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {


        protected string GetVersion()
        {
            return "1.0.1";
        }

        

    }
}