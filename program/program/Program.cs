using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDateRange(args);
        }

        private static void ShowDateRange(string[] args)
        {
            if (args.Length > 2)
                Console.WriteLine("Please input just two dates");
            else
            {
                char[] delimiters = new char[] { '.', '-', '/' };
                string[] day = new string[2];
                string[] month = new string[2];
                string[] year = new string[2];

                for (int i = 0; i < 2; i++)
                {
                    string[] s = args[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    day[i] = s[0];
                    month[i] = s[1];
                    year[i] = s[2];
                }
                var dateRange = new DateRange();
                DateRange.year = year;
                DateRange.month = month;
                DateRange.day = day;
                dateRange.IsYearDifferent = !Int32.Equals(year[0], year[1]);
                dateRange.IsMonthDifferent = !Int32.Equals(month[0], month[1]);
                dateRange.IsDayDifferent = !Int32.Equals(day[0], day[1]);

                var date = Helpers.DateHelper.GetDateRange(dateRange);
                Console.WriteLine(date.GetDate());
            }
            Console.ReadKey();
        }
    }
}
