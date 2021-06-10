using System;
using System.Collections.Generic;
using System.Text;

namespace LW.XtramileSolutionsTest.Services
{
    public interface IBusinessdayCalculator: IDayCalculator
    {
        DateTime[] Holidays { get; set; }
    }
}
