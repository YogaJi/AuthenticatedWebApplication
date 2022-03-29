using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticatedWebApplication.Controllers
{
    public class TestController : Controller
    {
        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }
    }
}
