using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
  
    //[Authorize(Policy = "ApiUser")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        public DashboardController()
        {

        }

        // GET api/dashboard/home
        [HttpGet("home")]
        public IActionResult GetHome()
        {
            return new OkObjectResult(new { Message = "This is secure data!" });
        }
    }
}
