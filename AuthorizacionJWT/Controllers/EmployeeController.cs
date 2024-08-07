using AuthorizacionJWT.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizacionJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = ("Administrador"))]
        public IActionResult Get()
        {
            var listEmployee = EmployeeContant.Employees;

            return Ok(listEmployee);
        }
    }
}
