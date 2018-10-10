using System;

namespace program
{
    class DayMonthYear : DateRange
    {
        int olderDate;
        
        public override string GetDate()
        {
            if (Convert.ToInt32(DateRange.year[0]) < Convert.ToInt32(DateRange.year[1]))
                { olderDate = 0; }
            else olderDate = 1;
            return String.Concat(DateRange.day[olderDate], '.', DateRange.month[olderDate], '.', DateRange.year[olderDate], " - ", DateRange.day[1 - olderDate], '.', DateRange.month[1 - olderDate], '.', DateRange.year[1 - olderDate]);           
        }
    }
}
