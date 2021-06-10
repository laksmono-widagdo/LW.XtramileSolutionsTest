using System;

namespace LW.XtramileSolutionsTest.Services
{
    public class WeekdayCalculator
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual double Calculate()
        {
            if (ToDate > FromDate)
            {
                double totalDays = (ToDate - FromDate).TotalDays - 1;
                double totalWeekEnd = 2 * ((totalDays - (6 - (int)FromDate.DayOfWeek + (int)ToDate.DayOfWeek)) / 7);

                if (FromDate.DayOfWeek != DayOfWeek.Saturday) totalWeekEnd++;
                if (ToDate.DayOfWeek != DayOfWeek.Sunday) totalWeekEnd++;

                return totalDays - totalWeekEnd;
            }

            return 0;
        }
    }
}
