using System;

namespace LW.XtramileSolutionsTest.Services
{
    public class BusinessdayCalculator : WeekdayCalculator, IBusinessdayCalculator
    {
        public DateTime[] Holidays { get; set; }

        public override double Calculate()
        {
            double totalWeekDays = base.Calculate();

            foreach (DateTime ph in Holidays)
            {
                if (ph > FromDate && ph < ToDate && ph.DayOfWeek != DayOfWeek.Sunday && ph.DayOfWeek != DayOfWeek.Saturday)
                {
                    totalWeekDays--;
                }
            }

            return totalWeekDays;
        }
    }
}
