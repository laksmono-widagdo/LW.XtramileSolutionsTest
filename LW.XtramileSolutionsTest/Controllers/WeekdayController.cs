using LW.XtramileSolutionsTest.Services;
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
        private readonly IWeekdayCalculator _calculator;

        public WeekdayController(
            ILogger<WeekdayController> logger,
            IWeekdayCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet("{fromDate}/{toDate}")]
        public double Get(DateTime fromDate, DateTime toDate)
        {
            _calculator.FromDate = fromDate;
            _calculator.ToDate = toDate;

            return _calculator.Calculate();
        }
    }
}
