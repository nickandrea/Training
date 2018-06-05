using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheckWebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public String Index()
        {
            return "Index";
        }

        public String About()
        {
            return "About";
        }
    }
}