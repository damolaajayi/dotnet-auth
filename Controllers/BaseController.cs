using Dotnet_Auth.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Auth.Controllers
{
    public class BaseController : ControllerBase
    {
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}
