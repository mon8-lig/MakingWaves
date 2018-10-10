namespace program
{
    public class DateRange
    {
        public static string[] year;
        public static string[] month;
        public static string[] day;

        public virtual string GetDate() { return ""; }

        public bool IsYearDifferent{ get; set; }

        public bool IsMonthDifferent { get; set; }

        public bool IsDayDifferent { get; set; }
    }
}
