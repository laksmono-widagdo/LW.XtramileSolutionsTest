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
    public class BusinessdayController : ControllerBase
    {
        private readonly ILogger<BusinessdayController> _logger;
        private readonly IBusinessdayCalculator _calculator;

        private DateTime[] _publicHolidays = new DateTime[] 
        {
            new DateTime(2014, 7, 17),
            new DateTime(2014, 8, 6),
            new DateTime(2014, 8, 15)
        };

        public BusinessdayController(
            ILogger<BusinessdayController> logger,
            IBusinessdayCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet("{fromDate}/{toDate}")]
        public double Get(DateTime fromDate, DateTime toDate)
        {
            _calculator.FromDate = fromDate;
            _calculator.ToDate = toDate;
            _calculator.Holidays = _publicHolidays;

            return _calculator.Calculate();
        }
    }
}
