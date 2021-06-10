using System;
using System.Collections.Generic;
using System.Text;

namespace LW.XtramileSolutionsTest.Services
{
    public interface IDayCalculator
    {
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }

        double Calculate();
    }
}
