using System;

namespace Fsd.Cs.Services.Date
{
    public class DateTimeService
    {
        private static string _dateStringFormat = "yyyy.MM.dd";
        private static string _timeStringFormat = "HH:mm:ss";
        private static string _fullDateStringFormat = $"{_dateStringFormat} {_timeStringFormat}";

        public string GetDateTimeString(DateTime date)
        {
            return date.ToString(_fullDateStringFormat);
        }

        public string GetDateString(DateTime date)
        {
            return date.ToString(_dateStringFormat);
        }

        public string GetTimeString(DateTime date)
        {
            return date.ToString(_timeStringFormat);
        }

        public string GetCustomString(DateTime date, string format)
        {
            return date.ToString(format);
        }
    }
}
