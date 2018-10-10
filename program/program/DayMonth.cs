using System;

namespace program
{
    class DayMonth : DateRange
    {
        public override string GetDate()
        {
            int olderDate;
            if (Convert.ToInt32(DateRange.month[0]) < Convert.ToInt32(DateRange.month[1]))
                { olderDate = 0; }
            else olderDate = 1;

            return String.Concat(DateRange.day[olderDate], '.', DateRange.month[olderDate], " - ", DateRange.day[1 - olderDate], '.', DateRange.month[1 - olderDate], '.', DateRange.year[olderDate]);
        }
    }
}
