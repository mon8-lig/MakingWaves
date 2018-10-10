using System;

namespace program
{
    class Day : DateRange
    {
        public override string GetDate()
        {
            int olderDate;
            if (Convert.ToInt32(DateRange.day[0]) < Convert.ToInt32(DateRange.day[1]))
                { olderDate = 0; }
            else olderDate = 1;

            return String.Concat(DateRange.day[olderDate], " - ", DateRange.day[1 - olderDate], '.', DateRange.month[olderDate], '.', DateRange.year[olderDate]);
        }
    }
}
