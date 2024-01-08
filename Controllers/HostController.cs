using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostController : ControllerBase
    {

        // GET: api/AppUser
        [HttpGet]
        [Obsolete]
        public String Get()
        {
            return  Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }

    }
}