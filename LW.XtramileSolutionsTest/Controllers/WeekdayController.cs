using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LW.XtramileSolutionsTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeekdayController : ControllerBase
    {
        private readonly ILogger<WeekdayController> _logger;

        public WeekdayController(ILogger<WeekdayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
