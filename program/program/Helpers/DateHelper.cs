using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Helpers
{
    public static class DateHelper
    {
        private static readonly Dictionary<Func<DateRange, bool>, Func<DateRange>> dict =
                 new Dictionary<Func<DateRange, bool>, Func<DateRange>>()
            {
                { h=> h.IsYearDifferent, () => new DayMonthYear() },
                { h=> !h.IsYearDifferent && h.IsMonthDifferent && h.IsDayDifferent, () => new DayMonth() },
                { h=> !h.IsYearDifferent && !h.IsMonthDifferent && h.IsDayDifferent, () => new Day() },
                { h=> !h.IsYearDifferent && !h.IsMonthDifferent && !h.IsDayDifferent, () => new SingleDate() },
            };

        public static DateRange GetDateRange(DateRange datePattern)
        {
            foreach (var item in dict)
            {
                if (item.Key(datePattern))
                    return item.Value();
            }
            throw new ApplicationException("Should not get there as any option should match");
        }
    }
}
