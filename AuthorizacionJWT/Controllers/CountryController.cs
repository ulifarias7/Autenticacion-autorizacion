using AuthorizacionJWT.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizacionJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var listCountry = CountryContan.Countrys;

            return Ok(listCountry);
        }
    }
}
