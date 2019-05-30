using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200395854ass1.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public String Index()
        {
            return "Hello from Custom.index()";
        }

        // GET: /custom/browse
        public String Browse()
        {
            return "Hello from Custom.Browse()";
        }

        // GET: /Custom/Details
        public String Details()
        {
            return "Hello from Custom.Details()";
        }
    }
}