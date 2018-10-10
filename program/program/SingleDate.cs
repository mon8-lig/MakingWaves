using System;

namespace program
{
    class SingleDate : DateRange
    {
        public override string GetDate()
        {
            return String.Concat(DateRange.day[0], '.', DateRange.month[0], '.', DateRange.year[0]);
        }
    }
}
