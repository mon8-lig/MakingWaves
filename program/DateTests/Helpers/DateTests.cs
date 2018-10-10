using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace program.Tests
{
    [TestClass()]
    public class DateTests
    {
        [TestMethod()]
        public void TheSameYearTheSameMonthTest()
        {
            var dateRange = new DateRange();
            DateRange.year = new string[] { "2017" };
            DateRange.month = new string[] { "01" };
            DateRange.day = new string[] { "01", "05" };
            dateRange.IsYearDifferent = false;
            dateRange.IsMonthDifferent = false;
            dateRange.IsDayDifferent = true;

            var date = Helpers.DateHelper.GetDateRange(dateRange);
            Assert.AreEqual("01 - 05.01.2017", date.GetDate());
        }

        [TestMethod()]
        public void TheSameYearDifferentMonthTest()
        {
            var dateRange = new DateRange();
            DateRange.year = new string[] { "2017" };
            DateRange.month = new string[] { "01", "02" };
            DateRange.day = new string[] { "01", "05" };
            dateRange.IsYearDifferent = false;
            dateRange.IsMonthDifferent = true;
            dateRange.IsDayDifferent = true;

            var date = Helpers.DateHelper.GetDateRange(dateRange);
            Assert.AreEqual("01.01 - 05.02.2017", date.GetDate());
        }

        [TestMethod()]
        public void DifferentYearTheSameMonthTest()
        {
            var dateRange = new DateRange();
            DateRange.year = new string[] { "2016", "2017" };
            DateRange.month = new string[] { "01", "01" };
            DateRange.day = new string[] { "01", "05" };
            dateRange.IsYearDifferent = true;
            dateRange.IsMonthDifferent = true;
            dateRange.IsDayDifferent = true;

            var date = Helpers.DateHelper.GetDateRange(dateRange);
            Assert.AreEqual("01.01.2016 - 05.01.2017", date.GetDate());
        }

        [TestMethod()]
        public void DifferentYearDifferentMonthTest()
        {
            var dateRange = new DateRange();
            DateRange.year = new string[] { "2016", "2017" };
            DateRange.month = new string[] { "12", "02" };
            DateRange.day = new string[] { "01", "05" };
            dateRange.IsYearDifferent = true;
            dateRange.IsMonthDifferent = true;
            dateRange.IsDayDifferent = true;

            var date = Helpers.DateHelper.GetDateRange(dateRange);
            Assert.AreEqual("01.12.2016 - 05.02.2017", date.GetDate());
        }

        [TestMethod()]
        public void TheSameDateTest()
        {
            var dateRange = new DateRange();
            DateRange.year = new string[] { "2016" };
            DateRange.month = new string[] { "12" };
            DateRange.day = new string[] { "01" };
            dateRange.IsYearDifferent = false;
            dateRange.IsMonthDifferent = false;
            dateRange.IsDayDifferent = false;

            var date = Helpers.DateHelper.GetDateRange(dateRange);
            Assert.AreEqual("01.12.2016", date.GetDate());
        }
    }
}