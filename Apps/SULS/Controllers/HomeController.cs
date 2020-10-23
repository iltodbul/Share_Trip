using System;
using System.Collections.Generic;
using System.Text;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SULS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index()
        {
            return this.View();
        }
    }
}
